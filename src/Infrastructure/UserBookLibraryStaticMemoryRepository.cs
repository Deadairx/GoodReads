using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodReads.Domain;

namespace Infrastructure
{
    public class UserBookCollection
    {
        public int UserId { get; protected set; }
        public List<BookRating> BookRating { get; protected set; }

        protected UserBookCollection(int userId, List<BookRating> bookRatings)
        {
            UserId = userId;
            BookRating = bookRatings;
        }
        public static UserBookCollection Create(int userId, List<BookRating> bookRatings)
        {
            return new UserBookCollection(userId, bookRatings);
        }
    }

    public class UserBookLibraryStaticMemoryRepository : IUserBookLibraryRepository
    {
        static private List<UserBookCollection> userBookCollections = new List<UserBookCollection>
        {
            UserBookCollection.Create(1, new List<BookRating>
            {
                BookRating.Create(1, 4),
                BookRating.Create(2, 3),
                BookRating.Create(3, 5)
            }),
            UserBookCollection.Create(2, new List<BookRating>
            {
                BookRating.Create(1, 1),
                BookRating.Create(2, 5),
                BookRating.Create(3, 2)
            }),
            UserBookCollection.Create(3, new List<BookRating>
            {
                BookRating.Create(1, 3),
                BookRating.Create(2, 4),
                BookRating.Create(3, 1)
            })
        };
        
        public List<BookRating> GetBookListByUserId(int userId)
        {
            // Get User from userId
            return userBookCollections.SingleOrDefault(c => c.UserId == userId).BookRating;
        }

        
    }
}
