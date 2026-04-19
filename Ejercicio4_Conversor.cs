using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Conversor
{
    internal class Ejercicio4_Conversor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de medidas");
            Console.WriteLine("1 Metros");
            Console.WriteLine("2 Pies");
            Console.WriteLine("3 Centimetros");
            Console.WriteLine("4 Pulgadas");

            int op = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine(valor + " metros");
                    break;
                case 2:
                    Console.WriteLine(valor * 3.28 + " pies");
                    break;
                case 3:
                    Console.WriteLine(valor * 100 + " cm");
                    break;
                case 4:
                    Console.WriteLine(valor * 39.37 + " pulgadas");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
