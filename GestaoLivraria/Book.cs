using System.ComponentModel;

namespace GestaoLivraria
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

    public enum GenderEnum
    {
        [Description("Ficção")]
        ficcao = 0,
        [Description("Romance")]
        romance = 1,
        [Description("Mistério")]
        misterio = 2,
        [Description("Drama")]
        drama = 3,
        [Description("Ação")]
        acao = 4
    }
}
