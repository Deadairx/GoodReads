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
            var controller = new BookLibraryController();

            // Act
            controller.Get(3);
        }



    }
}
