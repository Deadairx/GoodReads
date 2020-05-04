using System;
using System.Collections.Generic;
using System.Text;

namespace GoodReads.Domain
{
    public class UserBookLibrary
    {
        public User User { get; protected set; }

        private UserBookLibrary()
        {

        }

        public static UserBookLibrary Create(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("UserId is Required");
            }
            return new UserBookLibrary();
        }
    }
}
