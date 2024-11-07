using GestaoLivraria.Helpers;
using GestaoLivraria.Models.Entities;
using GestaoLivraria.Models.Enums;

using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private List<Book> _books = new List<Book>();

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Book), StatusCodes.Status400BadRequest)]

        public IActionResult GetById([FromRoute] int id)
        {
            Book? bookToGet = _books.FirstOrDefault(b => b.Id == id);

            if (bookToGet != null)
            {
                return Ok(bookToGet);
            }

            return NotFound(new { Message = "Livro não encontrado." });
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok(_books);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
        public IActionResult Create()
        {
            int count = _books.Count + 1;

            Book book = new()
            {
                Id = count,
                Title = "Teste2",
                Author = "Autor2",
                Gender = EnumGender.romance.GetEnumDescription(),
                Price = "2.00",
                QuantityInStock = 2
            };

            _books.Add(book);

            return Created(string.Empty, book);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int id, [FromBody] Book book)
        {
            Book? bookToUpdate = _books.FirstOrDefault(b => b.Id == id);

            if (bookToUpdate != null)
            {
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Price = book.Price;
                bookToUpdate.QuantityInStock = book.QuantityInStock;

                return NoContent();
            }

            return NotFound(new { Message = "Livro não encontrado." });
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            Book? bookToDelete = _books.FirstOrDefault(b => b.Id == id);

            if (bookToDelete != null)
            {
                _books.Remove(bookToDelete);

                return NoContent();
            }

            return NotFound(new { Message = "Livro não encontrado." });
        }
    }
}
