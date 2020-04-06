using System;
using System.Collections.Generic;
using System.Text;

namespace GoodReads.Logic
{
    class Book
    {
        // interal will allow book to be accessed only in this project
        // protected allows inherited classes to access properties
        public int Id { get; protected set; }
        public string Title { get; protected set; }

        protected Book()
        {

        }

        private Book(int bookId, string bookTitle)
        {
            Id = bookId;
            Title = bookTitle;
        }

        public static Book Create(int bookId, string bookTitle)
        {
            return new Book(bookId, bookTitle);
        }

        public void SetTitle(string newBookTitle)
        {
            Title = newBookTitle;
        }
    }
}
