using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II_II
{
    class Program
    {
        static void Main(string[] args)
        {

            double notaEnero, notaFebrero, notaAbril, notaMarzo, resultado = 0;

            Console.WriteLine("===========> PROMEDIO DE NOTAS <======== \n");

            Console.WriteLine("Ingresa Nota de Enero: ");
            notaEnero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa Nota de Febrero: ");
            notaFebrero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa Nota de  Marzo: ");
            notaMarzo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa Nota de  Abril: ");
            notaAbril = Convert.ToDouble(Console.ReadLine());

            resultado = (notaEnero + notaFebrero + notaMarzo + notaAbril) / 4;

            Console.WriteLine("El Pormedio de notas del Alumno es: {0}", resultado);
            Console.ReadKey();
        }
    }
}
