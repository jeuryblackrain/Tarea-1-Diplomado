using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_VI_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> LLENANDO UN VECTOR CON NOMBRES <======== \n");

            string[] vector = new string[5];

            //Llena el Vector con los 5 valores
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Espacio del Vector {0}", i);
                vector[i] = Console.ReadLine();
            }

            Console.Clear();
            //Lee Los valores en el vector
            Console.WriteLine("===========> VECTOR BUCLE I <======== \n");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Vector {0} -[{1}]", x, vector[x]);
            }

            Console.WriteLine("\n===========> VECTOR BUCLE II <======== \n");
            int y = 0; 
            while(y < 5)
            {
                Console.WriteLine("Vector {0} -[{1}]", y, vector[y]);
                y++;
            }

            Console.ReadKey();
        }
    }
}
