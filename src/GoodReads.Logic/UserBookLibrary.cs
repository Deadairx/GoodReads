using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodReads.Domain
{
    public class UserBookLibrary
    {
        public User User { get; protected set; }
        private readonly List<BookRating> _bookRatings = new List<BookRating>();

        private UserBookLibrary()
        {

        }

        protected UserBookLibrary(User user)
        {
            this.User = user;
        }

        public static UserBookLibrary Create(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("UserId is Required");
            }

            return new UserBookLibrary(user);
        }

        private bool HasBook(int bookId)
        {
            return _bookRatings.Any(br => br.BookId == bookId);
        }

        public void AddBookRating(int bookId, int bookRating)
        {
            var newBookRating = BookRating.Create(bookId, bookRating);
            if (HasBook(bookId))
            {
                GetBookRating(bookId).UpdateRating(bookRating);
            }
            else
            {
                _bookRatings.Add(newBookRating);
            }
        }

        public BookRating GetBookRating(int bookId)
        {
            return _bookRatings.Single(br => br.BookId == bookId);
        }
    }
}
