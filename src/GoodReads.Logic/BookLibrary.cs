using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodReads.Domain
{
    public class BookLibrary
    {
        private List<Book> books = new List<Book>();

        public void Add(string bookToAdd)
        {
            // Need to get highest Id
            // Needs to detect if books is empty
            int newId = 0;
            if(books.Count > 0)
            {
                newId = books.Max(b => b.Id) + 1;
            }
            var book = Book.Create(newId, bookToAdd);
            books.Add(book);
        }

        public Book Get(int bookID)
        {
            var book = books.SingleOrDefault(b => b.Id == bookID);
            if(book == null)
            {
                throw new KeyNotFoundException();
            }
            return book;
        }

        public List<string> GetAll()
        {
            return books.Select(b => b.Title).ToList();
        }

        public void Edit(int bookId, string newBookTitle)
        {
            var book = books.Single(b => b.Id == bookId);
            books.Remove(book);
            book.SetTitle(newBookTitle);
            books.Add(book);
        }

        public void Delete(int bookId)
        {
            var book = books.Single(b => b.Id == bookId);
            books.Remove(book);
        }

        public void AddRating(int bookId, int rating)
        {
            var book = books.Single(b => b.Id == bookId);
            book.SetRating(rating);
        }
    }
}
