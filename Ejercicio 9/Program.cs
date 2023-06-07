using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("++++++ Contador de digitos de un numero ++++++");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");
            int numero;
            Console.Write(" Ingrese un numero entero positivo :");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (numero < 10)
            {
                Console.WriteLine(" El numero tiene un Digito ");
                            }
            else
            {
                if (numero < 100)
                {
                    Console.WriteLine(" El numero tiene dos Digitos");
                }
                else
                    if (numero < 1000)
                {
                    Console.WriteLine(" El numero tiene tres Digitos");
                }
                else
                {
                    Console.WriteLine(" Error numero con muchos Digitos");
                }
            }
            Console.ReadKey();

        }
    }
}
