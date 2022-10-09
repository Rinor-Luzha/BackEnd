using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Dtos;
using Ratings.Elefanti.Models;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

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
                Rating = double.Parse(String.Format("{0:#,0.00}", movie.Rating)),
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

        [HttpPost("comment")]
        public IActionResult PostMovieComment(CommentDto dto)
        {
            User user = _userRepository.GetById(dto.UserId);
            if (user == null)
            {
                return BadRequest(new
                {
                    message = "Invalid User ID"
                });
            }
            Movie movie = _movieRepository.GetById(dto.MovieId);
            if (movie == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Movie ID"
                });
            }
            // Todo: Add check if this failed
            MovieComment movieComment = new MovieComment { Movie = movie, User = user, Comment = dto.Comment };
            _movieCommentRepository.Create(movieComment);
            return Created("Success", movieComment);
        }
        [HttpPut("comment")]
        public IActionResult ChangeMovieComment(ChangeCommentDto dto)
        {
            MovieComment movieComment = _movieCommentRepository.GetById(dto.Id);
            if (movieComment == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Comment ID"
                });
            }

            movieComment.Comment = dto.Comment;
            // Todo: Add check if this failed
            _movieCommentRepository.Update(movieComment);
            return Ok(movieComment);
        }

        [HttpDelete("comment")]
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
        private int GetRating(int movieid, int userid)
        {
            var rating = (from ratings in _db.Ratings
                          where ratings.User.Id == userid
                          where ratings.Movie.Id == movieid
                          select ratings).ToList();
            if (rating.Count == 0)
            {
                return -1;

            }
            return rating[0].Id;
        }


        [HttpPost("rating")]
        public IActionResult RateMovie(RatingDto dto)
        {
            User user = _userRepository.GetById(dto.UserId);
            if (user == null)
            {
                return BadRequest(new
                {
                    message = "Invalid User ID"
                });
            }
            Movie movie = _movieRepository.GetById(dto.MovieId);
            if (movie == null)
            {
                return BadRequest(new
                {
                    message = "Invalid Movie ID"
                });
            }

            int ratingId = GetRating(dto.MovieId, dto.UserId);

            if (ratingId == -1)
            {
                Rating newRating = new Rating { Movie = movie, User = user, RatingNr = dto.Rating };
                _ratingRepository.Create(newRating);
                return Ok(newRating);
            }
            //Todo: validate rating
            //Todo: Check for failure
            return ChangeRating(dto);
        }

        [HttpPut("rating")]
        public IActionResult ChangeRating(RatingDto dto)
        {

            int ratingId = GetRating(dto.MovieId, dto.UserId);


            if (ratingId == -1)
            {
                return BadRequest(new
                {
                    message = "Invalid Rating ID"
                });
            }

            Rating oldRating = _ratingRepository.GetById(ratingId);
            oldRating.RatingNr = dto.Rating;

            // Todo: Add check if this failed
            _ratingRepository.Update(oldRating);
            return Ok(oldRating);
        }

        [HttpDelete("rating")]
        public IActionResult DeleteRating(RatingDto dto)
        {
            int ratingId = GetRating(dto.MovieId, dto.UserId);


            if (ratingId == -1)
            {
                return BadRequest(new
                {
                    message = "Invalid Rating ID"
                });
            }

            // Todo: Add check if this failed
            _ratingRepository.Remove(_ratingRepository.GetById(ratingId));
            return NoContent();
        }
    }
}
