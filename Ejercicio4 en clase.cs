using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_en_Clase
{
    internal class Ejercicio4enClase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menú: ");
            Console.WriteLine("1. Hamburguesa");
            Console.WriteLine("2. Pizza");
            Console.WriteLine("3. Pollo frito");
            Console.WriteLine("4. Ensalada");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Usted pidio Hamburguesa");
                    break;
                case 2:
                    Console.WriteLine("Usted pidio Pizza");
                    break;
                case 3:
                    Console.WriteLine("Usted pidio Pollo frito");
                    break;
                case 4:
                    Console.WriteLine("Usted pidio Ensalada");
                    break;
                default:
                    Console.WriteLine("Elija una opción del menú");
                    break;
            }
        }
    }
}
