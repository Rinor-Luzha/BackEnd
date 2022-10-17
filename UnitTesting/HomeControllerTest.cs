using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ratings.Elefanti.Data;
using FakeItEasy;
using FluentAssertions;
using Ratings.Elefanti.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTesting
{
    public class HomeControllerTest
    {
        private readonly Fake<IApplicationDbContext> _db = new();

        private readonly HomeController homeController;

        public HomeControllerTest()
        {
            homeController = new HomeController(_db.FakedObject);
        }



        [Fact]
        public void GetMovies_ShouldReturnAllMovies()
        {

            //Arrange
            /* No need to arrange anything else */

            //Act
            var result = homeController.GetMovies();

            //Assert
            result.Should().BeOfType(typeof(OkObjectResult));
        }

    }
}
