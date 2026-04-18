using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_en_Clase
{
    internal class Ejercicio2enClase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operacines Básicas");

            Console.Write("Ingrese un numero: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Opcion de Operaciones");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Resultado: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + (a * b));
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine("Resultado: " + (a / b));
                    else
                        Console.WriteLine("No se puede dividir entre 0");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
