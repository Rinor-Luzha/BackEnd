using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Helpers;
using Ratings.Elefanti.Models;
using System.Text.RegularExpressions;

namespace Ratings.Elefanti.Controllers
{
    [ApiController]
    [Route("/home")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;

        }
        [HttpGet("movies")]
        public IActionResult GetMovies()
        {
            return Ok(_db.Movies);
        }
        [HttpGet("rated")]
        public IActionResult GetRated(int id)
        {
            //Return a list of all the movies that the logged in user has rated together with the rating the he/she has given them
            var rated = (from movies in _db.Movies
                         from ratings in _db.Ratings
                         from users in _db.Users
                         where users.Id == ratings.User.Id
                         where movies.Id == ratings.Movie.Id
                         where users.Id == id
                         select new
                         {
                             Id = ratings.Movie.Id,
                             Description = ratings.Movie.Description,
                             Length = movies.Length,
                             Title = movies.Title,
                             ReleaseDate = movies.ReleaseDate,
                             Rating = ratings.RatingNr,
                             Img = movies.Img
                         }).ToList();

            List<object> ratedWithGenres = new List<object>();

            // Get genres for each movie
            foreach (var movie in rated)
            {
                var genresList = (from genres in _db.Genres
                                  from movieGenres in _db.MovieGenres
                                  where movieGenres.Genre.Id == genres.Id
                                  where movieGenres.Movie.Id == movie.Id
                                  select genres.GenreName).ToList();


                // Complete the details for the movie
                ratedWithGenres.Add(new
                {
                    Id = movie.Id,
                    Description = movie.Description,
                    Length = movie.Length,
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    Img = movie.Img,
                    Rating = double.Parse(String.Format("{0:#,0.00}", movie.Rating)),
                    Genres = genresList
                });
            }
            return Ok(ratedWithGenres);
        }

        [HttpGet("new")]
        public IActionResult GetNewMovies()
        {
            //Return a list of all the rated movies in the database ordered by release date
            var ratedNewMovies = (from movies in _db.Movies
                                  from ratings in _db.Ratings
                                  from users in _db.Users
                                  where users.Id == ratings.User.Id
                                  where movies.Id == ratings.Movie.Id
                                  select movies).Distinct().ToList().OrderByDescending(movie => movie.ReleaseDate);

            List<object> newMovies = new List<object>();

            foreach (Movie movie in ratedNewMovies)
            {
                // Calculate average rating for each movie
                var ratingList = (from ratings in _db.Ratings
                                  where ratings.Movie.Id == movie.Id
                                  group ratings by new { ratings.Movie.Id } into grp
                                  select new
                                  {
                                      Rating = grp.Average(ratings => ratings.RatingNr)
                                  }).ToList()[0];

                // Get genres for each movie
                var genresList = (from genres in _db.Genres
                                  from movieGenres in _db.MovieGenres
                                  where movieGenres.Genre.Id == genres.Id
                                  where movieGenres.Movie.Id == movie.Id
                                  select genres.GenreName).ToList();


                // Complete the details for the movie
                newMovies.Add(new
                {
                    Id = movie.Id,
                    Description = movie.Description,
                    Length = movie.Length,
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    Img = movie.Img,
                    Rating = double.Parse(String.Format("{0:#,0.00}", ratingList.Rating)),
                    Genres = genresList
                });

            }
                return Ok(newMovies);
        }

        [HttpGet("highest")]
        public IActionResult GetHighestRated()
        {
            //Return a list of all the movies in the database ordered by rating (average)
            var highestRated = from movies in _db.Movies
                               from ratings in _db.Ratings
                               from users in _db.Users
                               where users.Id == ratings.User.Id
                               where movies.Id == ratings.Movie.Id
                               group ratings by new { movies.Id, movies.Description, movies.Length, movies.Title, movies.ReleaseDate, movies.Img } into grp
                               orderby grp.Average(ratings => ratings.RatingNr) descending
                               select new
                               {
                                   Id = grp.Key.Id,
                                   Description = grp.Key.Description,
                                   Length = grp.Key.Length,
                                   Title = grp.Key.Title,
                                   ReleaseDate = grp.Key.ReleaseDate,
                                   Img = grp.Key.Img,
                                   Rating = grp.Average(ratings => ratings.RatingNr)
                               };

            List<object> highestWithGenres = new List<object>();

           
            foreach (var movie in highestRated)
            {
                // Get genres for each movie
                var genreList = (from genres in _db.Genres
                                 from movieGenres in _db.MovieGenres
                                 where movieGenres.Genre.Id == genres.Id
                                 where movieGenres.Movie.Id == movie.Id
                                 select genres.GenreName).ToList();

                // Get actors for each movie
                var actorsList = (from movies in _db.Movies
                                  from actor in _db.People
                                  from movieActors in _db.MovieActors
                                  where movies.Id == movie.Id
                                  where movieActors.Actor.Id == actor.Id
                                  where movieActors.Movie.Id == movies.Id
                                  select actor).ToList();


                // Complete the details for the movie
                highestWithGenres.Add(new
                {
                    Id = movie.Id,
                    Description = movie.Description,
                    Length = movie.Length,
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    Img = movie.Img,
                    Rating = double.Parse(String.Format("{0:#,0.00}", movie.Rating)),
                    Genres = genreList,
                    Actors = actorsList
                });
            }
            return Ok(highestWithGenres);
        }

        [HttpGet("recommended")]
        public IActionResult GetRecommendedMovies(int? userid)
        {
            // Get a list of genres that the user likes by checking which movies he has rated
            List<string> genresForUser = new List<string>();
            if (userid != null)
            {
                var genresList = from movies in _db.Movies
                                 from ratings in _db.Ratings
                                 from users in _db.Users
                                 from genres in _db.Genres
                                 from movieGenres in _db.MovieGenres
                                 where movieGenres.Movie.Id == movies.Id
                                 where movieGenres.Genre.Id == genres.Id
                                 where users.Id == ratings.User.Id
                                 where movies.Id == ratings.Movie.Id
                                 where users.Id == userid
                                 group ratings by new { movies.Id, genres.GenreName } into grp
                                 orderby grp.Average(ratings => ratings.RatingNr) descending
                                 select new
                                 {
                                     GenreName = grp.Key.GenreName
                                 };
                foreach (var genre in genresList)
                {
                    genresForUser.Add(genre.GenreName);
                }
            }

            // If the user is logged in and has rated at least one movie
            // then it returns a list of all the movies with genres similiar
            // to the ones the user has rated, ordered by general rating
            if (genresForUser.Count > 0)
            {
                var recommended = from movies in _db.Movies
                                  from ratings in _db.Ratings
                                  from users in _db.Users
                                  from genres in _db.Genres
                                  from movieGenres in _db.MovieGenres
                                  where genresForUser.Contains(genres.GenreName)
                                  where movieGenres.Movie.Id == movies.Id
                                  where movieGenres.Genre.Id == genres.Id
                                  where users.Id == ratings.User.Id
                                  where movies.Id == ratings.Movie.Id
                                  group ratings by new { movies.Id, movies.Description, movies.Length, movies.Title, movies.ReleaseDate, movies.Img } into grp
                                  orderby grp.Average(ratings => ratings.RatingNr) descending
                                  select new
                                  {
                                      Id = grp.Key.Id,
                                      Description = grp.Key.Description,
                                      Length = grp.Key.Length,
                                      Title = grp.Key.Title,
                                      ReleaseDate = grp.Key.ReleaseDate,
                                      Img = grp.Key.Img,
                                      Rating = grp.Average(ratings => ratings.RatingNr),
                                  };

                List<object> recommendedWithGenres = new List<object>();

                // Get genres for each movie
                foreach (var movie in recommended)
                {
                    var genresList = (from genres in _db.Genres
                                      from movieGenres in _db.MovieGenres
                                      where movieGenres.Genre.Id == genres.Id
                                      where movieGenres.Movie.Id == movie.Id
                                      select genres.GenreName).ToList();


                    // Complete the details for the movie
                    recommendedWithGenres.Add(new
                    {
                        Id = movie.Id,
                        Description = movie.Description,
                        Length = movie.Length,
                        Title = movie.Title,
                        ReleaseDate = movie.ReleaseDate,
                        Img = movie.Img,
                        Rating = double.Parse(String.Format("{0:#,0.00}", movie.Rating)),
                        Genres = genresList
                    });
                }
                return Ok(recommendedWithGenres);
            }
            // If the user hasn't logged in or hasn't rated any movie, then it
            // returns a list of movies with specific genres ordered by rating.
            // ?The genres that the app recommends will be changed by the admin every week?
            else
            {
                var allGenresList = _db.Genres.ToList();
                List<string> randomGenres = new List<string>();
                Random rnd = new Random();
                for (int i = 0; i < 3; i++)
                {
                    int randomIndex = rnd.Next(allGenresList.Count);
                    string genre = (allGenresList[randomIndex]).GenreName;
                    if (randomGenres.Contains(genre))
                    {
                        i--;
                        continue;
                    }
                    randomGenres.Add(genre);
                }

                var recommended = from movies in _db.Movies
                                  from ratings in _db.Ratings
                                  from users in _db.Users
                                  from genres in _db.Genres
                                  from movieGenres in _db.MovieGenres
                                  where randomGenres.Contains(genres.GenreName)
                                  where movieGenres.Movie.Id == movies.Id
                                  where movieGenres.Genre.Id == genres.Id
                                  where users.Id == ratings.User.Id
                                  where movies.Id == ratings.Movie.Id
                                  group ratings by new { movies.Id, movies.Description, movies.Length, movies.Title, movies.ReleaseDate, movies.Img } into grp
                                  orderby grp.Average(ratings => ratings.RatingNr) descending
                                  select new
                                  {
                                      Id = grp.Key.Id,
                                      Description = grp.Key.Description,
                                      Length = grp.Key.Length,
                                      Title = grp.Key.Title,
                                      ReleaseDate = grp.Key.ReleaseDate,
                                      Img = grp.Key.Img,
                                      Rating = grp.Average(ratings => ratings.RatingNr)
                                  };
                List<object> recommendedWithGenres = new List<object>();

                // Get genres for each movie
                foreach (var movie in recommended)
                {
                    var genresList = (from genres in _db.Genres
                                      from movieGenres in _db.MovieGenres
                                      where movieGenres.Genre.Id == genres.Id
                                      where movieGenres.Movie.Id == movie.Id
                                      select genres.GenreName).ToList();


                    // Complete the details for the movie
                    recommendedWithGenres.Add(new
                    {
                        Id = movie.Id,
                        Description = movie.Description,
                        Length = movie.Length,
                        Title = movie.Title,
                        ReleaseDate = movie.ReleaseDate,
                        Img = movie.Img,
                        Rating = double.Parse(String.Format("{0:#,0.00}", movie.Rating)),
                        Genres = genresList
                    });
                }
                return Ok(recommendedWithGenres);
            }
        }
        [HttpGet("random")]
        public IActionResult GetRandomMovie(int? userid)
        {
            // First get a list of recommended movies from the last function
            var okResult = GetRecommendedMovies(userid);
            var recommended = (List<object>)((OkObjectResult)okResult).Value;

            // From the list pick a random one and return it
            Random rnd = new Random();
            int randomIndex = rnd.Next(recommended.Count);
            return Ok(recommended[randomIndex]);
        }

        [HttpGet("search")]
        public IActionResult GetQueriedMovies(string? title)
        {
            if (title == null)
            {
                return GetMovies();
            }
            // Lowercase the query
            title = title.ToLower();
            // Remove punctuation
            title = new string(title.Where(c => !char.IsPunctuation(c)).ToArray());
            // Split keywords of title
            string[] keywords = title.Split(" ");

            List<Movie> queriedMovies = new List<Movie>();

            // Get all movies
            var okResult = GetMovies();
            var movies = ((IQueryable<object>)((OkObjectResult)okResult).Value).ToList();

            foreach (Movie movie in movies)
            {
                if (movie.Title.ToLower().Contains(title))
                {
                    queriedMovies.Add(movie);
                    continue;
                }
                if (title.Contains(movie.Title.ToLower()))
                {
                    queriedMovies.Add(movie);
                    continue;
                }

                // Check if any of the movies contain any of the keywords
                if (keywords.Any(keyword => movie.Title.ToLower().Contains(keyword)))
                {
                    queriedMovies.Add(movie);
                }
            }
            return Ok(queriedMovies);
        }
    }
}
