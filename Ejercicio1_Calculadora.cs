using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Calculadora
{
    internal class Ejercicio1_Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funciones trigonometricas");
            Console.Write("Ingrese angulo en grados: ");
            double angulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Coseno");
            Console.WriteLine("3. Tangente");
            int op = Convert.ToInt32(Console.ReadLine());

            double radio = angulo * Math.PI / 180;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Seno: " + Math.Sin(radio));
                    break;
                case 2:
                    Console.WriteLine("Coseno: " + Math.Cos(radio));
                    break;
                case 3:
                    Console.WriteLine("Tangente: " + Math.Tan(radio));
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
