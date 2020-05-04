using GoodReads.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookLibraryController : ControllerBase
    {
        private IBookLibraryRepository _bookLibraryRepository;

        public BookLibraryController(IBookLibraryRepository bookLibraryRepository)
        {
            _bookLibraryRepository = bookLibraryRepository;
        }

        // GET api/values

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return _bookLibraryRepository.GetById(id);
        }

        // POST api/values


        // PUT api/values/5


        // DELETE api/values/5

    }
}
