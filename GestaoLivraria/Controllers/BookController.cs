using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public static List<Book> _books = new List<Book>();

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            return Ok(_books);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
        public IActionResult Post()
        {
            Book book = new Book() { Id = 1, Title = "Teste2", Author = "Autor2", Gender = GenderEnum.romance.GetEnumDescription(), Price = "2.00", QuantityInStock = 2 };

            _books.Add(book);

            return Created(string.Empty, book);
        }
    }
}
