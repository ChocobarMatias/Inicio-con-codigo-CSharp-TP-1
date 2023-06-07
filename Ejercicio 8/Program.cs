using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("+++ Notas para ver promocion de alumnos +++");
            Console.WriteLine("*******************************************");
            Console.WriteLine(" ");

            double nota1, nota2, nota3, promedio;
            Console.WriteLine(" Ingreso de Notas del Alumno ");
            Console.WriteLine("-----------------------------");
            Console.Write(" Ingresar Primera Nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write(" Ingresar Segunda Nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write(" Ingresar Tercera Nota: ");
            nota3 = double.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------");
                Console.WriteLine(" Alumno Promocionado " + promedio);
                Console.WriteLine("-------------------------");
            }
            Console.ReadKey();

        }
    }
}
