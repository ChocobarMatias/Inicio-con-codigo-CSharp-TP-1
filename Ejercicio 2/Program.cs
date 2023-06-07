using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("-------- Calculo de Sueldo de un Operario --------");
            Console.WriteLine("**************************************************");
            Console.WriteLine(" ");
            int valorhora, horatrabajada, Sueldo;

            Console.Write(" Ingresar el Valor Hora: $");
            valorhora = int.Parse(Console.ReadLine());
            Console.Write(" Ingresar Total de Horas Trabajadas: ");
            horatrabajada = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Sueldo = valorhora * horatrabajada;

            Console.WriteLine("******************************");
            Console.Write(" Sueldo del operario: $");
            Console.WriteLine(Sueldo);
            Console.WriteLine("******************************");

            Console.ReadKey();

        }
    }
}
