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

        [Fact]
        public void AddBookRating_GivenBookId_AddsBookToUserBookLibrary()
        {
            // Arrange
            var expectedRating = 3;
            var user = User.Create();
            var userBookLibrary = UserBookLibrary.Create(user);

            // Act
            userBookLibrary.AddBookRating(3, expectedRating);

            // Assert
            userBookLibrary.GetBookRating(3).Rating.Should().Be(expectedRating);
        }

        [Fact]
        public void AddBookRating_GivenExistingBookId_UpdateRating()
        {
            // Arrange
            var expectedRating = 3;
            var bookId = 3;
            var user = User.Create();
            var userBookLibrary = UserBookLibrary.Create(user);
            userBookLibrary.AddBookRating(bookId, 1);

            // Act
            userBookLibrary.AddBookRating(bookId, expectedRating);

            // Assert
            userBookLibrary.GetBookRating(bookId).Rating.Should().Be(expectedRating);
        }

        [Fact]
        public void GetBookRating_GivenNonExistentBookId_ThrowException()
        {
            // Arrange
            var bookId = 3;
            var user = User.Create();
            var userBookLibrary = UserBookLibrary.Create(user);

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => 
                userBookLibrary.GetBookRating(bookId));
        }
    }
}
