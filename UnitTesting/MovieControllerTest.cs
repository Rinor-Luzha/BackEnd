using Ratings.Elefanti.Data;
using System;
using Ratings.Elefanti.Controllers;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Ratings.Elefanti.Dtos;
using Ratings.Elefanti.Models;

namespace UnitTesting
{
    public class MovieControllerTest
    {
        private readonly Fake<IApplicationDbContext> _db = new();
        private readonly Fake<IMovieRepository> _movieRepository = new();
        private readonly Fake<IUserRepository> _userRepository = new();
        private readonly Fake<IMovieCommentRepository> _movieCommentRepository = new();
        private readonly Fake<IRatingRepository> _ratingRepository = new();


        private readonly MovieController movieController;

        public MovieControllerTest()
        {
            movieController = new MovieController(_db.FakedObject, _movieRepository.FakedObject, _userRepository.FakedObject, _movieCommentRepository.FakedObject, _ratingRepository.FakedObject);
        }


        [Theory]
        [InlineData(1,1,"This Movie Sucks")]
        [InlineData(3, 2, "This Movie Sucks")]
        [InlineData(5, 4, "This Movie Sucks")]
        [InlineData(4, 5, "This Movie Sucks")]

        public void PostMovieComment_ShouldPostComment(int useId, int movieID, string comment)
        {
            //Arrange
            var dto = new CommentDto()
            {
                UserId = useId,
                MovieId = movieID,
                Comment = comment
            };

            //Act
            var result = movieController.PostMovieComment(dto);

            //Assert

            result.Should().BeOfType(typeof(CreatedResult));

        }


        [Theory]
        [InlineData(1, "Jk This movie is actually good" )]
        [InlineData(5, "I changed my mind it sucks")]
        public void ChangeMovieComment_ShouldChangeComment(int id, string comment)
        {
            //Arrange
            var dto = new ChangeCommentDto()
            {
                Id = id,
                Comment = comment
            };

            //Act
            var result = movieController.ChangeMovieComment(dto);

            //Assert
            result.Should().BeOfType(typeof(OkObjectResult));
        }


        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void DeleteMovieComment_ShouldDeleteComment(int id)
        {
            //Arrange
            
            /* Nothing to Arrange */

            //Act
            var result = movieController.DeleteMovieComment(id);

            //Assert
            result.Should().BeOfType(typeof(NoContentResult));
        }


    }
}
