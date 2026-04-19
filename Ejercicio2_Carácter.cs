using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Vocal_Digito_o_Ninguno
{
    internal class Ejercicio2_Carácter
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un caracter: ");
            char carácter = Convert.ToChar(Console.ReadLine().ToLower());

            if (char.IsDigit(carácter))
            {
                Console.WriteLine("Es un digito");
            }
            else
            {
                switch (carácter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Es una vocal");
                        break;
                    default:
                        Console.WriteLine("No es vocal ni digito");
                        break;
                }
            }
        }
    }
}
