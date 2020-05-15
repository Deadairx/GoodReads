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
            var expectedBook1 = BookRating.Create(1, 4);
            var expectedBook2 = BookRating.Create(2, 3);
            var expectedBook3 = BookRating.Create(3, 5);

            IUserBookLibraryRepository userBookLibraryRepository = 
                new UserBookLibraryStaticMemoryRepository();

            // Act
            var actual = userBookLibraryRepository.GetBookListByUserId(userId);

            // Assert
            actual.Should().ContainEquivalentOf(expectedBook1);
            actual.Should().ContainEquivalentOf(expectedBook2);
            actual.Should().ContainEquivalentOf(expectedBook3);
        }

        // TODO: Add Static Memory
        [Fact]
        public void GetBookListByUserId_GivenDifferentValidUserId_ReturnsUsersBookList()
        {

        }
    }
}
