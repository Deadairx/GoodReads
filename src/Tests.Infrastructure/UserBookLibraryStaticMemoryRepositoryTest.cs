using FluentAssertions;
using GoodReads.Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.Infrastructure
{
    public class UserBookLibraryStaticMemoryRepositoryTest
    {
        [Fact]
        public void GetBookListByUserId_GivenValidUserId_ReturnsUsersBookList()
        {
            // Arrange
            var userId = 1;
            List<BookRating> expectedBooks = new List<BookRating>
            {
                BookRating.Create(1, 4),
                BookRating.Create(2, 3),
                BookRating.Create(3, 5)
            };

            IUserBookLibraryRepository userBookLibraryRepository = 
                new UserBookLibraryStaticMemoryRepository();

            // Act
            var actual = userBookLibraryRepository.GetBookListByUserId(userId);

            // Assert
            actual.Should().ContainEquivalentOf(expectedBooks);
        }
        
        [Fact]
        public void GetBookListByUserId_GivenDifferentValidUserId_ReturnsUsersBookList()
        {
            // Arrange
            var userId = 2;
            List<BookRating> expectedBooks = new List<BookRating>
            {
                BookRating.Create(1, 1),
                BookRating.Create(2, 5),
                BookRating.Create(3, 2)
            };

            IUserBookLibraryRepository userBookLibraryRepository = 
                new UserBookLibraryStaticMemoryRepository();

            // Act
            var actual = userBookLibraryRepository.GetBookListByUserId(userId);

            // Assert
            actual.Should().ContainEquivalentOf(expectedBooks);
        }

        // TO DO: Update and Create
    }
}
