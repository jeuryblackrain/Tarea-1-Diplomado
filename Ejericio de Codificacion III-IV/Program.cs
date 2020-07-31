using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_de_Codificacion_III_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> DIAS DE LA SEMANA <======== \n");

            int dia;

            Console.WriteLine("Escirbe un numero (1-7): ");
            dia = Convert.ToInt32(Console.ReadLine());


            switch (dia)
            {
                case 1:
                    Console.WriteLine(dia + "-Lunes");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine(dia + "-Martes");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(dia + "-Miercoles");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(dia + "-Jueves");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine(dia + "-Viernes");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine(dia + "-Sabado");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine(dia + "-Domingo");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine(dia + "-El Valor no esta en la lista");
                    break;
            }
        }
    }
}
