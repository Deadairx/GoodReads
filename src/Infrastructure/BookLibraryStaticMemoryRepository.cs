using GoodReads.Domain;

namespace Infrastructure
{
    public class BookLibraryStaticMemoryRepository : IBookLibraryRepository
    {
        private static BookLibrary _memoryBookLibrary;

        private static string[] _bookTitles = new string[]
        {
            "Iliad",
            "Dracula",
            "Beowulf",
            "Captain Underpants",
            "Where the Red Fern Grows",
            "Odyssey",
            "Green Eggs and Ham",
            "The Hungry Caterpillar",
            "Ender's Game",
            "Redwall",
            "A Tale of Two Cities"
        };

        static BookLibraryStaticMemoryRepository()
        {
            _memoryBookLibrary = new BookLibrary();
            foreach (var title in _bookTitles)
            {
                _memoryBookLibrary.Add(title);
            }
        }

        public Book GetById(int id)
        {
            return _memoryBookLibrary.Get(id);
        }
    }
}
