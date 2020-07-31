using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_IV_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> TABLA DE MULTIPLICACION <======== \n");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("\nTabla del {0}\n", i);
                for (int x = 1; x <= 10; x++) { 
                    Console.WriteLine("{0} * {1} = {2}", i,x, i*x);
                    }
            }
            Console.ReadKey();
        }
    }
}
