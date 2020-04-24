using FluentAssertions;
using Infrastructure;
using Infrastructure.Controllers;
using Xunit;

namespace Tests.Infrastructure
{
    public class BookLibraryControllerTests
    {
        [Fact]
        public void Get_GivenBookId_ReturnBook()
        {
            // Arrange
            var expectedBookTitle = "Captain Underpants";
            IBookLibraryRepository bookLibraryRepository =
                new BookLibraryStaticMemoryRepository();
            var controller = new BookLibraryController(bookLibraryRepository);

            // Act
            var actual = controller.Get(3);

            // Assert
            actual.Value.Title.Should().Be(expectedBookTitle);
        }

        [Fact]
        public void Get_GivenDifferentBookId_ReturnDifferentBook()
        {
            // Arrange
            var expectedBookTitle = "Where the Red Fern Grows";
            IBookLibraryRepository bookLibraryRepository =
                new BookLibraryStaticMemoryRepository();
            var controller = new BookLibraryController(bookLibraryRepository);

            // Act
            var actual = controller.Get(4);

            // Assert
            actual.Value.Title.Should().Be(expectedBookTitle);
        }
    }
}
