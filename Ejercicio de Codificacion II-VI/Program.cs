using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> CALCULADORA DE CUOTAS SIMPLES <======== \n");

            double M, I,T, C=0;

            Console.WriteLine("Ingrese el Monto: ");
            M = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el Interes: ");
            I = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el Tiempo: ");
            T = Convert.ToDouble(Console.ReadLine());

            I = I / 100;
            C = ((M * I) / T) + (M / T);

            Console.WriteLine("===========> CUOTAS SIMPLES <======== \n");

            Console.WriteLine($"Cuotas Simples...............: ${C}");
            Console.ReadKey();




        }
    }
}
