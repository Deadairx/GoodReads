using FluentAssertions;
using GoodReads.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GoodReadsTests
{
    public class BookLibraryTests
    {
        [Fact]
        public void Add_GivenBookTitle_AddBookToLibrary()
        {
            // Arrange
            var bookLibrary = new BookLibrary();

            // Act
            bookLibrary.Add("A Tale of Two Cities");

            // Assert
            List<string> actual = bookLibrary.GetAll();
            actual.Should().Contain("A Tale of Two Cities");
        }
    }
}
