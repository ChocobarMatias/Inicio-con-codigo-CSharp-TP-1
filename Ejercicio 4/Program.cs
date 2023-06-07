using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("--- Calculo de la Suma y Promedio de 4 numeros aleatorios ---");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" ");
            int num1, num2, num3, num4, suma, promedio;
            Console.Write("       Ingresar Primer Numero = ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("       Ingresar Segundo Numero = ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("       Ingresar Tercero Numero = ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("       Ingresar Cuarto Numero = ");
            num4 = int.Parse(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;
            promedio = (suma / 4);

            Console.WriteLine(" ");
            Console.WriteLine("       **************");
            Console.Write("        Suma = ");
            Console.WriteLine(suma);
            Console.WriteLine("       **************");
            Console.WriteLine(" ");
            Console.WriteLine("       **************");
            Console.Write("        Promedio = ");
            Console.WriteLine(promedio);
            Console.WriteLine("       **************");

            Console.ReadKey();

        }
    }
}
