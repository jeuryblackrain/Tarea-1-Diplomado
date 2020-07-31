using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0, valor2 = 0, resultado = 0;

            Console.WriteLine("===========> PROGRAMA SUMA DOS NUMEROS <======== \n");
            Console.WriteLine("Ingresa el Primer Valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el Segundo Valor: ");
            valor2 = double.Parse(Console.ReadLine());

            resultado = valor1 + valor2;

            Console.WriteLine("El resultado es: {0}",resultado);
            Console.Read();
        }
    }
}
