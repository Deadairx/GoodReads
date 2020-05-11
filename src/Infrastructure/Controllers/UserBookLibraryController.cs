using System.Collections.Generic;
using GoodReads.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookLibraryController : ControllerBase
    {
        // GET: api/UserBookLibrary
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserBookLibrary/5
        [HttpGet("{id}", Name = "Get")]
        public int Get(int userId, int bookId)
        {
            var user = GoodReads.Domain.User.Create();
            var userBookLibrary = UserBookLibrary.Create(user);
            return 4;
        }

        // POST: api/UserBookLibrary
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/UserBookLibrary/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
