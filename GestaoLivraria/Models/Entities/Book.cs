using System.ComponentModel;

namespace GestaoLivraria.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Gender { get; set; }

        public string Price { get; set; }

        public int QuantityInStock { get; set; }
    }
}
