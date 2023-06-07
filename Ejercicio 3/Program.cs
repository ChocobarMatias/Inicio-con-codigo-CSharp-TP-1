using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lado, Perimetro;

            Console.WriteLine(" ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("--- Calculo del Perimetro de un cuadrado ---");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" ");

            Console.Write(" Ingresar valor del Lado de un Caudrado = ");
            Lado = int.Parse(Console.ReadLine());

            Perimetro = 4 * Lado;

            Console.WriteLine(" ");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.Write(" Perimetro del Caudrado = ");
            Console.WriteLine(Perimetro);
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.ReadKey();

        }
    }
}
