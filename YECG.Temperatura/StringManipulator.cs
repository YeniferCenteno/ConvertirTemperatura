using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YECG.Temperatura.UnitTestxUnit
{
    public class StringManipulator
    {
        // Método para invertir una cadena
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Método para eliminar los espacios en blanco de una cadena
        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }

}
