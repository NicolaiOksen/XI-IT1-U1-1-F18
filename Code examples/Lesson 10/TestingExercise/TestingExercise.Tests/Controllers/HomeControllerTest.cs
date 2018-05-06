using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using TestingExercise.Controllers;
using Xunit;

namespace TestingExercise.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Test()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Index();

            // Assert
            result.ShouldNotBeNull();
            result.ShouldBeOfType<ViewResult>();
            (result as ViewResult).ViewData.Count.ShouldBe(0);
        }
    }
}
