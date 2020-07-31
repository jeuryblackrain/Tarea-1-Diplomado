using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificaicon_IV_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> NUMEROS DEL 3 AL 20 CON SU CUBO <======== \n");

            for (int i = 3; i <= 23; i++)
            {
                Console.WriteLine(i + ")-Cubo-(" + Math.Pow(i,3));
            }
            Console.ReadKey();
        }
    }
}
