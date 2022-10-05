using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Helpers;
using Ratings.Elefanti.Models;

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
            List<Movie> Movies = _db.Movies.ToList<Movie>();
            return Ok(Movies);
        }
        [HttpGet("rated")]
        public IActionResult GetRated(int id)
        {
            //Return a list of all the movies that the logged in user has rated together with the rating the he/she has given them
            var Rated = from movies in _db.Movies
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
                        };

            return Ok(Rated);
        }

        [HttpGet("new")]
        public IActionResult GetNewMovies()
        {
            //Return a list of all the movies in the database ordered by release date together with their average rating
            var NewMovies = from movies in _db.Movies
                            from ratings in _db.Ratings
                            from users in _db.Users
                            where users.Id == ratings.User.Id
                            where movies.Id == ratings.Movie.Id
                            group ratings by new { movies.Id, movies.Description, movies.Length, movies.Title, movies.ReleaseDate, movies.Img } into grp
                            orderby grp.Key.ReleaseDate descending
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

            return Ok(NewMovies);
        }

        [HttpGet("highest")]
        public IActionResult GetHighestRated()
        {
            //Return a list of all the movies in the database ordered by rating (average)
            var New = from movies in _db.Movies
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

            return Ok(New);
        }

        [HttpGet("recommended")]
        public IActionResult GetRecommendedMovies(int? userid)
        {
            // Get a list of genres that the user likes by checking which movies he has rated
            List<string> GenresForUser = new List<string>();
            if (userid != null)
            {
                var Genres = from movies in _db.Movies
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
                foreach (var genre in Genres)
                {
                    GenresForUser.Add(genre.GenreName);
                }
            }

            // If the user is logged in and has rated at least one movie
            // then it returns a list of all the movies with genres similiar
            // to the ones the user has rated, ordered by general rating
            if (GenresForUser.Count > 0)
            {
                var Recommended = from movies in _db.Movies
                                  from ratings in _db.Ratings
                                  from users in _db.Users
                                  from genres in _db.Genres
                                  from movieGenres in _db.MovieGenres
                                  where GenresForUser.Contains(genres.GenreName)
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
                return Ok(Recommended);
            }
            // If the user hasn't logged in or hasn't rated any movie, then it
            // returns a list of movies with specific genres ordered by rating.
            // ?The genres that the app recommends will be changed by the admin every week?
            else
            {
                var Genres = _db.Genres.ToList();
                List<string> RandomGenres = new List<string>();
                Random rnd = new Random();
                for (int i = 0; i < 3; i++)
                {
                    int RandomIndex = rnd.Next(Genres.Count);
                    string Genre = (Genres[RandomIndex]).GenreName;
                    if (RandomGenres.Contains(Genre))
                    {
                        i--;
                        continue;
                    }
                    RandomGenres.Add(Genre);
                }

                var Recommended = from movies in _db.Movies
                                  from ratings in _db.Ratings
                                  from users in _db.Users
                                  from genres in _db.Genres
                                  from movieGenres in _db.MovieGenres
                                  where RandomGenres.Contains(genres.GenreName)
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
                return Ok(Recommended);
            }
        }
        [HttpGet("random")]
        public IActionResult GetRandomMovie(int? userid)
        {
            // First get a list of recommended movies from the last function
            var OkResult = GetRecommendedMovies(userid);
            var Recommended = ((IQueryable<object>)((OkObjectResult)OkResult).Value).ToList();

            // From the list pick a random one and return it
            Random rnd = new Random();
            int RandomIndex = rnd.Next(Recommended.Count);
            return Ok(Recommended[RandomIndex]);
        }
    }
}
