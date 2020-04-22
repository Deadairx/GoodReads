using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodReads.Domain;

namespace Infrastructure
{
    public class BookLibraryStaticMemoryRepository : IBookLibraryRepository
    {
        private static BookLibrary _memoryBookLibrary;

        // TO DO: Refactor into array
        static BookLibraryStaticMemoryRepository()
        {
            _memoryBookLibrary = new BookLibrary();
            _memoryBookLibrary.Add("Iliad");
            _memoryBookLibrary.Add("Dracula");
            _memoryBookLibrary.Add("Beowulf");
            _memoryBookLibrary.Add("Captain Underpants");
            _memoryBookLibrary.Add("Where the Red Fern Grows");
            _memoryBookLibrary.Add("Odyssey");
            _memoryBookLibrary.Add("Green Eggs and Ham");
            _memoryBookLibrary.Add("The Hungry Caterpillar");
            _memoryBookLibrary.Add("Ender's Game");
            _memoryBookLibrary.Add("Redwall");
            _memoryBookLibrary.Add("A Tale of Two Cities");
        }

        public Book GetById(int id)
        {
            return _memoryBookLibrary.Get(id);
        }
    }
}
