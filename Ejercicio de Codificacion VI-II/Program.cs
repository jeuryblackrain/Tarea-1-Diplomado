using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_VI_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> SUMA UN VECTOR <======== \n");

            int[] vector = new int[5];
            

            //Llena el Vector con los 5 valores
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Espacio del Vector {0}", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            //Lee Los valores en el vector
            int suma = 0;
            Console.WriteLine("===========> VECTOR <======== \n");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Vector {0} -[{1}]", x, vector[x]);
                suma += vector[x];
           }
            Console.WriteLine("\nLa Suma de Los Vectores Es: {0}",suma);


            Console.ReadKey();
        }
    }
}
