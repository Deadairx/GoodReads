using FluentAssertions;
using GoodReads.Domain;
using System;
using System.Collections.Generic;
using Xunit;

namespace GoodReads.Tests.Domain
{
    public class BookLibraryTests
    {
        [Fact]
        public void Add_GivenBookTitle_AddBookToLibrary()
        {
            // Arrange
            var expectedBookTitle = "A Tale of Two Cities";
            var bookLibrary = new BookLibrary();

            // Act
            bookLibrary.Add(expectedBookTitle);

            // Assert
            List<string> actual = bookLibrary.GetAll();
            actual.Should().Contain(expectedBookTitle);
        }

        [Fact]
        public void Get_GivenBookId_ReturnSpecifiedBook()
        {
            // Arrange
            var bookLibrary = new BookLibrary();
            var expectedBookTitle = "Fellowship of the Ring";
            bookLibrary.Add("A Tale of Two Cities");
            bookLibrary.Add(expectedBookTitle);
            bookLibrary.Add("Pride and Prejudice and Zombies");

            // Act
            var actual = bookLibrary.Get(1);

            // Assert
            actual.Title.Should().Be(expectedBookTitle);
        }

        [Fact]
        public void Get_GivenBookIdOutOfRange_ThrowError()
        {
            // Arrange
            var bookLibrary = new BookLibrary();
            bookLibrary.Add("A Tale of Two Cities");
            bookLibrary.Add("Fellowship of the Ring");
            bookLibrary.Add("Pride and Prejudice and Zombies");

            // Act
            Assert.Throws<KeyNotFoundException>(() => bookLibrary.Get(5));
        }

        [Fact]
        public void Edit_GivenBookIdAndNewTitle_ChangesBookId()
        {
            // Arrange
            var bookLibrary = new BookLibrary();
            var expectedBookTitle = "War and Peace";
            bookLibrary.Add("A Tale of Two Cities");
            bookLibrary.Add("Fellowship of the Ring");
            bookLibrary.Add("Pride and Prejudice and Zombies");

            // Act
            bookLibrary.Edit(1, expectedBookTitle);

            // Assert
            var actual = bookLibrary.Get(1);
            actual.Title.Should().Be(expectedBookTitle);
        }

        [Fact]
        public void Delete_GivenBookId_RemovesBookFromLibrary()
        {
            // Arrange
            var bookLibrary = new BookLibrary();
            bookLibrary.Add("A Tale of Two Cities");
            bookLibrary.Add("Fellowship of the Ring");
            bookLibrary.Add("Pride and Prejudice and Zombies");

            // Act
            bookLibrary.Delete(1);

            // Assert
            Assert.Throws<KeyNotFoundException>(() => bookLibrary.Get(1));
        }
    }
}
