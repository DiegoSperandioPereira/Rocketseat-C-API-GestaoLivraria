using System.ComponentModel;

namespace GestaoLivraria.Models.Enums
{
    public enum EnumGender
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
