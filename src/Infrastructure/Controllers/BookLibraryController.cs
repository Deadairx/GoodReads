using GoodReads.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookLibraryController : ControllerBase
    {
        private static BookLibrary _memoryBookLibrary;

        // Very first thing that runs in this controller
        // Runs once
        static BookLibraryController()
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

        // GET api/values

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return _memoryBookLibrary.Get(id);
        }

        // POST api/values


        // PUT api/values/5


        // DELETE api/values/5

    }
}
