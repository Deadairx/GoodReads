using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace GoodReads.Domain.Tests
{
    public class UserBookLibraryTests
    {

        [Fact]
        public void Create_GivenNoUser_ThrowsException()
        {
            // Arrange
            var expectedMessage = "UserId is Required";
            // Act

            // Assert
            var ex = Assert.Throws<ArgumentException>(() => UserBookLibrary.Create(null));
            ex.Message.Should().Be(expectedMessage);
        }

        [Fact]
        public void Create_GivenUser_ReturnsUserBookLibrary()
        {
            // Arrange
            var expectedUser = User.Create();

            // Act
            var userBookLibrary = UserBookLibrary.Create(expectedUser);

            // Assert
            userBookLibrary.User.Should().Be(expectedUser);
        }
    }
}
