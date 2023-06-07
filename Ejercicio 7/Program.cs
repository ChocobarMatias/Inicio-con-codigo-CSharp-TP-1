using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" +++ Comparacion de dos Numeros +++ ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" ");

            double num1, num2, suma, diferencia, producto, div;

            Console.Write(" Ingresar primer Numero :");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write(" Ingresar el segundo Numero :");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (num2 != 0)
            {
                if (num1 > num2)
                {
                    suma = num1 + num2;
                    diferencia = num1 - num2;
                    Console.Write(" Suma de los dos numeros es: " + suma);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.Write(" Diferencia de los dos numeros es: " + diferencia);
                    Console.WriteLine(" ");
                }
                else
                {
                    producto = (num1 * num2);
                    div = num1 / num2;
                    Console.Write(" Producto de los numeros es: " + producto);
                    Console.WriteLine(" ");
                    Console.Write(" Division de los dos numeros es: " + div);

                }
            }
            else
            {
                Console.WriteLine(" No se puede dividir en 0 ");
            }
            Console.ReadKey();

        }
    }
}
