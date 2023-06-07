using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" --- Calculo del Precio Total a pagar de un Articulo ---");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(" ");

            int precio, cantidad, PrecioTotal;
            Console.Write(" Ingrese el Precio del Articulo que lleva el cliente = $");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write(" Ingrese cuantos Articulos lleva = ");

            cantidad = int.Parse(Console.ReadLine());

            PrecioTotal = precio * cantidad;

            Console.WriteLine(" ");
            Console.WriteLine("--------------------");
            Console.Write(" Total a Pagar = $");
            Console.WriteLine(PrecioTotal);
            Console.WriteLine("--------------------");
            Console.ReadKey();

        }
    }
}
