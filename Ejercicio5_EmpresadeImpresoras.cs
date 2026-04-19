using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Empresa_de_impresoras
{
    internal class Ejercicio5_EmpresadeImpresoras
    {
        static void Main(string[] args)
        {
            double precio = 650;
            double precioIVA = precio * 1.12;

            Console.Write("Cantidad de impresoras: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Forma de pago:");
            Console.WriteLine("1 Efectivo");
            Console.WriteLine("2 Tarjeta");
            Console.WriteLine("3 Vale");

            int pago = Convert.ToInt32(Console.ReadLine());

            double subtotal = cantidad * precioIVA;
            double descuento = 0;

            switch (pago)
            {
                case 1:
                    descuento = subtotal * 0.10;
                    break;
                case 2:
                    descuento = subtotal * 0.05;
                    break;
                case 3:
                    descuento = subtotal * 0.15;
                    break;
            }

            double total = subtotal - descuento;

            Console.WriteLine("Cantidad: Q." + cantidad);
            Console.WriteLine("Precio con IVA: Q." + precioIVA);
            Console.WriteLine("Subtotal: Q." + subtotal);
            Console.WriteLine("Descuento: Q." + descuento);
            Console.WriteLine("Total a pagar: Q." + total);
        }
    }
}

