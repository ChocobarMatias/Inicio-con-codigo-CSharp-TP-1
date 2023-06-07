using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("+++++ Test de Capacitacion +++++");
            Console.WriteLine("********************************");
            Console.WriteLine(" ");

            int totalpregunta, contesto, porcentaje;
            Console.Write(" Ingrese el Total de preguntas del Test de Capacitacion : ");
            totalpregunta = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write(" Ingrese el Total de preguntas conestadas correctamente :");
            contesto = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            porcentaje = (contesto * 100) / totalpregunta;

            if (porcentaje >= 90)
            {
                Console.WriteLine(" Nivel Maximo : " + porcentaje + "%");
            }
            else
            {
                if (porcentaje >= 70 & porcentaje < 90)
                {
                    Console.WriteLine(" Nivel Medio : " + porcentaje + "%");
                }
                else
                {
                    if (porcentaje >= 50 & porcentaje < 70)
                    {
                        Console.WriteLine(" Nivel Regular : " + porcentaje + "%");
                    }
                    else

                    {
                        Console.WriteLine(" Fuera del Nivel : " + porcentaje + "%");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
