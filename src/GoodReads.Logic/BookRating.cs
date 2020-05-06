using System;
using System.Collections.Generic;
using System.Text;

namespace GoodReads.Domain
{
    public class BookRating
    {
        public int BookId { get; protected set; }
        public int Rating { get; protected set; }

        private BookRating()
        {

        }

        protected BookRating(int bookId, int bookRating)
        {
            this.BookId = bookId;
            Rating = bookRating;
        }

        public static BookRating Create(int bookId, int bookRating)
        {
            return new BookRating(bookId, bookRating);
        }
    }
}
