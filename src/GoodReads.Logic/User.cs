using System;
using System.Collections.Generic;
using System.Text;

namespace GoodReads.Domain
{
    public class User
    {
        public int Id { get; protected set; }

        private User()
        {

        }

        public static User Create()
        {
            return new User();
        }
    }
}
