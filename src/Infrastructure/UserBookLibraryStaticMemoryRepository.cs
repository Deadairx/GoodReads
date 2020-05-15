using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodReads.Domain;

namespace Infrastructure
{
    public class UserBookLibraryStaticMemoryRepository : IUserBookLibraryRepository
    {
        public List<BookRating> GetBookListByUserId(int userId)
        {
            return new List<BookRating>
            {
                BookRating.Create(1, 4),
                BookRating.Create(2, 3),
                BookRating.Create(3, 5)
            };
        }
    }
}
