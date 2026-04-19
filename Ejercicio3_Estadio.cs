using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Estadio
{
    internal class Ejercicio3_Estadio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sectores del estadio");
            Console.WriteLine("1. Palco");
            Console.WriteLine("2. Tribuna");
            Console.WriteLine("3. Preferencia");
            Console.WriteLine("4. General");

            int sector = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de entradas: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            double precio = 0;

            switch (sector)
            {
                case 1:
                    precio = 300;
                    break;
                case 2:
                    precio = 125;
                    break;
                case 3:
                    precio = 75;
                    break;
                case 4:
                    precio = 50;
                    break;
                default:
                    Console.WriteLine("Esta opción de sector no es valida");
                    break;
            }

            double total = precio * cantidad;
            Console.WriteLine("Total a pagar: Q." + total);
        }

    }
}
