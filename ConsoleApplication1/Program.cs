using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;
            int product;

            Console.WriteLine("*****************************************");
            Console.WriteLine(" Suma y producto de dos numero enteros ");
            Console.WriteLine("*****************************************");
            Console.WriteLine(" ");
            Console.Write("Ingresar un numero entero: ");

            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresar otro numero entero: ");

            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            product = num1 * num2;

            Console.Write("La suma de los numeros enteros ingresados es: "+ suma);
            Console.WriteLine(" ");
            Console.Write("El producto de los numero enteros ingresados es: "+ product);
            Console.WriteLine(" ");
            Console.ReadKey();

        }
    }
}
