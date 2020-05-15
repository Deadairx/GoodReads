using FluentAssertions;
using GoodReads.Domain;
using Infrastructure.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.Infrastructure
{
    public class UserBookLibraryControllerTests
    {
        // Eventually test with UserId
        [Fact]
        public void GetUserRating_GivenUserIdAndBookId_ReturnsUserRating()
        {
            // Arrange
            var expectedBookRating = 4;
            var bookId = 1;
            var userId = 1;
            var user = User.Create();
            var userBookLibrary = UserBookLibrary.Create(user);
            var userBookLibraryController = new UserBookLibraryController();
            userBookLibrary.AddBookRating(bookId, expectedBookRating);

            // Act
            var actual = userBookLibraryController.Get(userId, bookId);

            // Assert
            actual.Should().Be(expectedBookRating);
        }

        // TODO: Add UserBookLibraryRepository
        //[Fact]
        //public void GetUserRating_GivenDifferentBookId_ReturnsUserRating()
        //{
        //    // Arrange
        //    var expectedBookRating = 2;
        //    var bookId = 2;
        //    var userId = 1;
        //    var user = User.Create();
        //    var userBookLibrary = UserBookLibrary.Create(user);
        //    var userBookLibraryController = new UserBookLibraryController();
        //    userBookLibrary.AddBookRating(bookId, expectedBookRating);

        //    // Act
        //    var actual = userBookLibraryController.Get(userId, bookId);

        //    // Assert
        //    actual.Should().Be(expectedBookRating);
        //}
    }
}
