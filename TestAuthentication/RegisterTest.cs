using Azure;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Ratings.Elefanti;
using Ratings.Elefanti.Controllers;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Dtos;
using Ratings.Elefanti.Helpers;
using System.Net;
using System.Runtime.Intrinsics.Arm;

namespace TestAuthentication
{
    public class RegisterTest 
    {

        private readonly Fake<IUserRepository> _repository = new();
        private readonly Fake<JwtService> _jwtService = new();
        private readonly AuthController authController;
        public RegisterTest()
        {
            authController = new AuthController(_repository.FakedObject, _jwtService.FakedObject);
        }

        [Theory]
        [InlineData("", "Fisteku", "Filan@fisteku.com", "password1", "2001/02/26")]
        [InlineData("Filan", "", "Filan@fisteku.com", "password1", "2001/02/26")]
        [InlineData("Filan", "Fisteku", "Filanfisteku.com", "password1", "2001/02/26")]
        [InlineData("Filan", "Fisteku", "Filan@fisteku.com", "password", "2001/02/26")]
        [InlineData("Filan", "Fisteku", "Filan@fisteku.com", "pass1", "2001/02/26")]
        [InlineData("Fi", "Fisteku", "Filan@fisteku.com", "password1", "2001/02/26")]
        [InlineData("Filan", "Fi", "Filan@fisteku.com", "password1", "2001/02/26")]
        [InlineData("Filan", "Fisteku", "Filan@fisteku.com", "password1", "2015/02/26")]
        public void Register_ShouldNotCreateUser(string name, string surname, string email, string password, DateTime doB)
        {

            //Arrange

            var dto = new RegisterDto()
            {
                Name = name,
                Surname = surname,
                Password = password,
                Email = email,
                BirthDate = doB
            };

            //Act

            var result = authController.Register(dto);


            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(BadRequestObjectResult));
        }


        [Theory]
        [InlineData("Filan", "Fisteku", "Filan@fisteku.com", "password1", "2001/02/26")]
        [InlineData("Dem", "Alia", "Dem@alia.com", "asdfghjkL!1", "2001/02/26")]
        public void Register_ShouldCreateUser(string name, string surname, string email, string password, DateTime doB)
        {
            //Arrange

            var dto = new RegisterDto()
            {
                Name = name,
                Surname = surname,
                Password = password,
                Email = email,
                BirthDate = doB
            };

            //Act

            var result = authController.Register(dto);


            //Assert

            result.Should().NotBe(typeof(BadRequestObjectResult));


        }

    }
}