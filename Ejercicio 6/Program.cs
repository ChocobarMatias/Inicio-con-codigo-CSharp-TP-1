using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("+++ Sueldo de una Persona +++");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            int sueldo;
            int sueldoimpuesto = 3000;

            Console.Write(" Ingresar Sueldo: $");

            sueldo = int.Parse(Console.ReadLine());

            if (sueldo > sueldoimpuesto)
            { 
            Console.WriteLine(" ");
            Console.WriteLine(" El Sueldo Ingresado debe pagar Impuestos ");
             }
        Console.ReadKey();

        }
    }
}
