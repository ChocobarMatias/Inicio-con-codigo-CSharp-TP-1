using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("+++ Verificacion de signo de un numero entero +++");
            Console.WriteLine("***************************************************");
            Console.WriteLine(" ");

            int numero;
            Console.Write(" Ingresar un numero Entero :  ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (numero == 0)
            {
                Console.WriteLine(" El numero es Nulo ");
            }
            else
            {
                if (numero > 0)
                {
                    Console.WriteLine(" El numero es Positivo ");
                }
                else
                {
                    Console.WriteLine(" El numero es Negativo ");
                }
            }
            Console.ReadKey();

        }
    }
}
