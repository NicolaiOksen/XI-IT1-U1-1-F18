using Shouldly;
using System;
using Xunit;

namespace TestingExercise.Tests
{
    public class ExampleTest
    {
        [Fact]
        public void Example()
        {
            // Arrange
            var str = "Nicolai is a developer";

            // Act
            var value = str + " and a geek";

            // Assert
            value.ShouldNotBeNullOrEmpty();
            value.ShouldBe("Nicolai is a developer and a geek");
        }
    }
}
