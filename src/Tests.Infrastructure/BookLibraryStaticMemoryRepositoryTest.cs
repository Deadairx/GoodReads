using FluentAssertions;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.Infrastructure
{
    public class BookLibraryStaticMemoryRepositoryTest
    {
        [Fact]
        public void GetById_GivenValidId_ReturnsBook()
        {
            // Arrange
            var expectedBookTitle = "Captain Underpants";
            IBookLibraryRepository bookLibraryRepository =
                new BookLibraryStaticMemoryRepository();

            // Act
            var actual = bookLibraryRepository.GetById(3);

            // Assert
            actual.Title.Should().Be(expectedBookTitle);
        }

        [Fact]
        public void GetById_GivenDifferentId_ReturnsDifferentBook()
        {
            // Arrange
            var expectedBookTitle = "Beowulf";
            IBookLibraryRepository bookLibraryRepository =
                new BookLibraryStaticMemoryRepository();

            // Act
            var actual = bookLibraryRepository.GetById(2);

            // Assert
            actual.Title.Should().Be(expectedBookTitle);
        }
    }
}
