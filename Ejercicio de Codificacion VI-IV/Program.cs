using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_VI_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> LLENANDO UN VECTOR <======== \n");

            int[,] vectorA = new int[2,2];
            int[,] vectorB = new int[2,2];
            int[,] vectorC = new int[2,2];


            Console.WriteLine("\n==========> Vector A <========== \n");
            for (int i = 0; i < 2; i++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.Write("Posicion del vector A({0} {1}): ",i, y, vectorA[i,y]);
                    vectorA[i,y] = Convert.ToInt32(Console.ReadLine());                 
                }
            }
            Console.WriteLine("\n==========> Vector B <========== \n");
            for (int z = 0; z < 2; z++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("Posicion del vector A({0} {1}): ", z, c, vectorA[z, c]);
                    vectorB[z, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Suma los Vectores A y B
            for (int o = 0; o < 2; o++)
            {
                for (int c = 0; c < 2; c++)
                {
                    vectorC[o,c] = vectorA[o,c] + vectorB[o,c];
                }
            }


            Console.Clear();
            //Lee Los valores en el vector
            Console.Write("===========> VECTOR A <========");
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("");
                for (int p = 0; p < 2; p++)
                {
                    Console.Write("|" + vectorA[x,p] + "| ");            
                }
            }

            Console.Write("\n===========> VECTOR B <========");
            for (int q = 0; q < 2; q++)
            {
                Console.WriteLine("");
                for (int p = 0; p < 2; p++)
                {
                    Console.Write("  {0}  ", vectorB[q, p]);
                }
            }

            Console.Write("\n===========> VECTOR C <========");
            for (int r = 0; r < 2; r++)
            {
                Console.WriteLine("");
                for (int p = 0; p < 2; p++)
                {
                    Console.Write("  {0}  ", vectorC[r, p]);
                }
            }
            Console.ReadKey();
        }
    }
}
