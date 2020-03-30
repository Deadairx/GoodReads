using System;
using System.Collections.Generic;

namespace GoodReads.Logic
{
    public class BookLibrary
    {
        private List<string> books = new List<string>();

        public void Add(string bookToAdd)
        {
            books.Add(bookToAdd);
        }

        public string Get(int bookID)
        {
            return books[bookID];
        }

        public List<string> GetAll()
        {
            return books;
        }
    }
}
