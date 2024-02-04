using Microsoft.AspNetCore.Mvc;

namespace Darkstore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return SampleData.Books;
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = SampleData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
