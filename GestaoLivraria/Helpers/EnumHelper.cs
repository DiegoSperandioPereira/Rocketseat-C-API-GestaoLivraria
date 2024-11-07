using System.ComponentModel;
using System.Reflection;

namespace GestaoLivraria.Helpers
{
    public static class EnumHelper
    {
        public static string GetEnumDescription<T>(this T enumValue) where T : Enum
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return enumValue.ToString();
        }
    }
}
