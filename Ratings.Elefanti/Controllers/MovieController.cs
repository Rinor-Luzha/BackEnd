using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Models;
using System.Reflection.Metadata.Ecma335;

namespace Ratings.Elefanti.Controllers
{
    [ApiController]
    [Route("/movie")]
    public class MovieController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly MovieRepository _movieRepository;
        private readonly UserRepository _userRepository;
        private readonly MovieCommentRepository _movieCommentRepository;
        private readonly RatingRepository _ratingRepository;

        public MovieController(ApplicationDbContext db, MovieRepository movieRepository, UserRepository userRepository, MovieCommentRepository movieCommentRepository, RatingRepository ratingRepository)
        {
            _db = db;
            _movieRepository = movieRepository;
            _userRepository = userRepository;
            _movieCommentRepository = movieCommentRepository;
            _ratingRepository = ratingRepository;
        }

        [HttpGet("details")]
        public IActionResult GetMovie(int movieid)
        {
            // Get movie by id together with it's rating
            var movieList = from movies in _db.Movies
                            from ratings in _db.Ratings
                            from users in _db.Users
                            where movies.Id == movieid
                            where users.Id == ratings.User.Id
                            where movies.Id == ratings.Movie.Id
                            group ratings by new { movies.Id, movies.Description, movies.Length, movies.Title, movies.ReleaseDate, movies.Img } into grp
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

            // Check if the given movie id is valid
            if (movieList.ToList().Count == 0)
            {
                return BadRequest(new
                {
                    message = "Invalid Movie ID"
                });
            }

            var movie = movieList.First();

            // Get the queried movie genres
            var genresList = (from movies in _db.Movies
                              from genres in _db.Genres
                              from movieGenres in _db.MovieGenres
                              where movies.Id == movieid
                              where movieGenres.Genre.Id == genres.Id
                              where movieGenres.Movie.Id == movies.Id
                              select genres.GenreName).ToList();


            // Get the queried movie actors
            var actorsList = (from movies in _db.Movies
                              from actor in _db.People
                              from movieActors in _db.MovieActors
                              where movies.Id == movieid
                              where movieActors.Actor.Id == actor.Id
                              where movieActors.Movie.Id == movies.Id
                              select new { actor, movieActors.CharacterName }).ToList();

            // Get the queried movie writers
            var writersList = (from movies in _db.Movies
                               from writer in _db.People
                               from movieWriters in _db.MovieWriters
                               where movies.Id == movieid
                               where movieWriters.Writer.Id == writer.Id
                               where movieWriters.Movie.Id == movies.Id
                               select new { writer, movieWriters.Credit }).ToList();

            // Get the queried movie directors
            var directorsList = (from movies in _db.Movies
                                 from people in _db.People
                                 from movieDirectors in _db.MovieDirectors
                                 where movies.Id == movieid
                                 where movieDirectors.Director.Id == people.Id
                                 where movieDirectors.Movie.Id == movies.Id
                                 select people).ToList();

            // Concatenate the genres, actors, writers, and directors
            // of the movie to the original queried movie object
            var completeMovie = new
            {
                Id = movie.Id,
                Description = movie.Description,
                Length = movie.Length,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Img = movie.Img,
                Rating = movie.Rating,
                Genres = genresList,
                Actors = actorsList,
                Writers = writersList,
                Directors = directorsList
            };
            return Ok(completeMovie);
        }

        [HttpGet("comments")]
        public IActionResult GetMovieComments(int movieid)
        {
            //ToDo: check if movieid is invalid
            var commentsList = (from movies in _db.Movies
                                from users in _db.Users
                                from movieComments in _db.MovieComments
                                where movies.Id == movieid
                                where movieComments.Movie.Id == movies.Id
                                where movieComments.User.Id == users.Id
                                select new
                                {
                                    Id = movieComments.Id,
                                    User = users,
                                    Comment = movieComments.Comment
                                }).ToList();
            return Ok(commentsList);
        }

        [HttpPost("comments")]
        public IActionResult PostMovieComment(int movieid, int userid, string comment)
        {
            User user = _userRepository.GetById(userid);
            if (user == null)
            {
                return BadRequest(new
                {
                    message = "Invalid User ID"
                });
            }
            Movie movie = _movieRepository.GetById(movieid);
            if (movie == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Movie ID"
                });
            }
            // Todo: Add check if this failed
            MovieComment movieComment = new MovieComment { Movie = movie, User = user, Comment = comment };
            _movieCommentRepository.Create(movieComment);
            return Created("Success", movieComment);
        }
        [HttpPut("comments")]
        public IActionResult ChangeMovieComment(int commentid, string comment)
        {
            MovieComment movieComment = _movieCommentRepository.GetById(commentid);
            if (movieComment == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Comment ID"
                });
            }

            movieComment.Comment = comment;
            // Todo: Add check if this failed
            _movieCommentRepository.Update(movieComment);
            return Ok();
        }

        [HttpDelete("comments")]
        public IActionResult DeleteMovieComment(int commentid)
        {
            MovieComment movieComment = _movieCommentRepository.GetById(commentid);
            if (movieComment == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Comment ID"
                });
            }

            // Todo: Add check if this failed
            _movieCommentRepository.Remove(movieComment);
            return NoContent();
        }

        //Get movie comments, post rating, put rating, remove rating.


        [HttpPost("ratings")]
        public IActionResult RateMovie(int movieid, int userid, int rating)
        {
            User user = _userRepository.GetById(userid);
            if (user == null)
            {
                return BadRequest(new
                {
                    message = "Invalid User ID"
                });
            }
            Movie movie = _movieRepository.GetById(movieid);
            if (movie == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Movie ID"
                });
            }
            //Todo: validate rating
            //Todo: Check for failure
            Rating newRating = new Rating { Movie = movie, User = user, RatingNr = rating };
            _ratingRepository.Create(newRating);
            return Created("Success", newRating);
        }

        [HttpPut("ratings")]
        public IActionResult ChangeRating(int ratingid, int rating)
        {
            Rating oldRating = _ratingRepository.GetById(ratingid);
            if (oldRating == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Rating ID"
                });
            }
            oldRating.RatingNr = rating;
            // Todo: Add check if this failed
            _ratingRepository.Update(oldRating);
            return Ok();
        }

        [HttpDelete("ratings")]
        public IActionResult DeleteRating(int ratingid)
        {
            Rating rating = _ratingRepository.GetById(ratingid);
            if (rating == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Rating ID"
                });
            }
            // Todo: Add check if this failed
            _ratingRepository.Remove(rating);
            return NoContent();
        }
    }
}
