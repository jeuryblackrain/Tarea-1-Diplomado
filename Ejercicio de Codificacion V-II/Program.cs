using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_V_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "";

            do
            {
                Console.Clear();
                Console.WriteLine("===========> MENU DE OPCIONES <======== \n");
                Console.WriteLine("TABLA DE MULTIPLICAR [T]");
                Console.WriteLine("PROMEDIO [P]");
                Console.WriteLine("------------------------");
                Console.WriteLine("SALIR [S]");
                Console.WriteLine("------------------------");
                Console.WriteLine("ELIJA UNA OPCION : ");
                p = Console.ReadLine();


                switch(p)
                {
                    
                    case "t":
                    case "T":
                        Console.Clear();
                        Console.WriteLine("===========> TABLA DEl MULTIPLICAR <======== \n");
                        int i = 1;
                        int numero;

                        Console.WriteLine("Tabla del :");
                        numero = Convert.ToInt32(Console.ReadLine());

                        while (i <= 10)
                        {
                            Console.WriteLine("{0} * {1} = {2}",numero, i, i*numero);
                            i++;
                        }
                        Console.ReadKey();

                        break;

                    case "p":
                    case "P":

                        Console.Clear();
                        Console.WriteLine("===========> PROMEDIO DE NOTAS <======== \n");
                        double notaEnero, notaFebrero, notaAbril, notaMarzo, resultado = 0;

                        Console.WriteLine("Ingresa Nota de Enero: ");
                        notaEnero = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa Nota de Febrero: ");
                        notaFebrero = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa Nota de  Marzo: ");
                        notaMarzo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa Nota de  Abril: ");
                        notaAbril = Convert.ToDouble(Console.ReadLine());

                        resultado = (notaEnero + notaFebrero + notaMarzo + notaAbril) / 4;

                        Console.WriteLine("El Pormedio de notas del Alumno es: {0}", resultado);
                        Console.ReadKey();

                        break;

                    default:
                        Console.WriteLine("Adios.....");
                        break;

                }

            } while (p != "s" & p != "S");
        }
    }
}
