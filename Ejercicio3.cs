using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio3_de_Clase
{
    internal class Ejercicio3 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clasificacion de letras");
            Console.Write("Dame una letra: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (letra)
            {
                case 'A':
                    Console.WriteLine("Excelente");
                    break;
                case 'B':
                    Console.WriteLine("Bueno");
                    break;
                case 'C':
                    Console.WriteLine("Regular");
                    break;
                case 'D':
                    Console.WriteLine("Deficiente");
                    break;
                case 'F':
                    Console.WriteLine("Reprobado");
                    break;
                default:
                    Console.WriteLine("Digite una letra entre A,B,C,D,F");
                    break;
            }
        }
    }
}
