using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodReads.Logic
{
    public class BookLibrary
    {
        private List<Book> books = new List<Book>();

        public void Add(string bookToAdd)
        {
            // Need to get highest Id
            // Id's could not be consecutive
            // tempId could return null (result/operation result pattern)
            var tempId = books.Where(b => b.Id == ).Select(b => b.Id);
            var book = Book.Create(, bookToAdd);
            books.Add(bookToAdd);
        }

        public string Get(int bookID)
        {
            return books[bookID];
        }

        public List<string> GetAll()
        {
            return books;
        }

        public void Edit(int bookId, string newBookTitle)
        {
            books[bookId] = newBookTitle;
        }

        public void Delete(int bookId)
        {
            books.RemoveAt(bookId);
        }
    }
}
