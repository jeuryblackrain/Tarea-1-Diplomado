using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> CONVERSOR DE CENTIMETRO A PULGADAS <======== \n");

            double centimetros, pulgadas;

            Console.WriteLine("Centimetros: ");
            centimetros = Convert.ToDouble(Console.ReadLine());

            pulgadas = centimetros / 2.54;

            Console.WriteLine("El valor en Pulgadas es de.: {0}", pulgadas);
            Console.ReadKey();
        }
    }
}
