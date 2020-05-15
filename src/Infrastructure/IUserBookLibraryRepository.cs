using GoodReads.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IUserBookLibraryRepository
    {
        List<BookRating> GetBookListByUserId(int userId);
    }
}
