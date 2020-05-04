using System;
using System.Collections.Generic;
using System.Text;

namespace GoodReads.Domain
{
    public class User
    {
        private User()
        {

        }

        public static User Create()
        {
            return new User();
        }
    }
}
