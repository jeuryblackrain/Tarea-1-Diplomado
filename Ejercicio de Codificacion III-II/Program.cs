using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_III_II
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

            
            if(resultado > 0 && resultado < 65)
            {
                Console.WriteLine($"Promedio del Alumno: {resultado} | Reprobado");
                Console.ReadKey();
            }
            if (resultado > 65 && resultado < 75)
            {
                Console.WriteLine($"Promedio del Alumno: {resultado} | Aprobado");
                Console.ReadKey();
            }
            if (resultado > 75 && resultado < 85)
            {
                Console.WriteLine($"Promedio del Alumno: {resultado} | Muy Bueno");
                Console.ReadKey();
            }
            if (resultado > 85 && resultado < 90)
            {
                Console.WriteLine($"Promedio del Alumno: {resultado} | Sobresaliente");
                Console.ReadKey();
            }
            if (resultado > 90 && resultado < 100)
            {
                Console.WriteLine($"Promedio del Alumno: {resultado} | Excelente");
                Console.ReadKey();
            }
        }
    }
}
