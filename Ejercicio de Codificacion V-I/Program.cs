using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_V_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> TABLA DEl 4 <======== \n");

            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine("4 * {0} = {1}", i, i * 4);
                i++;
            }
            Console.ReadKey();
        }
    }
}
