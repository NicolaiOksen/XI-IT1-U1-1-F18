using TestingExample.Services;
using Xunit;
using FluentAssertions;
using Moq;

namespace TestingExample.Tests.Services
{
    public class SomeOtherServiceTests
    {
        [Fact]
        public void A_test_right_here()
        {
            // Arrange
            ISomeOtherService someOtherService = new SomeOtherService(); // <-- This is not that awesome :(
            var someService = new SomeService(someOtherService);

            // Act
            var value = someService.DoSomething(true);

            // Assert
            value.Should().BeEquivalentTo("Awesome!");
        }

        [Fact]
        public void A_more_correct_test()
        {
            // Arrange
            var someOtherServiceMock = new Mock<ISomeOtherService>();

            someOtherServiceMock.Setup(m => m.DoSomethingThatOthersRelyOn(true)).Returns("Awesome!");
            someOtherServiceMock.Setup(m => m.DoSomethingThatOthersRelyOn(false)).Returns("Crap...");

            var someService = new SomeService(someOtherServiceMock.Object);

            // Act
            var value = someService.DoSomething(true);
            var value2 = someService.DoSomething(false);

            // Assert
            value.Should().BeEquivalentTo("Awesome!");
            value2.Should().BeEquivalentTo("Nooooo");
        }
    }
}
