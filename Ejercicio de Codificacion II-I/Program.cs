using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II_I
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            Console.WriteLine("===========> BIENVENIDO A MI PROGRAMA <======== \n");
            Console.WriteLine("CUAL ES TU NOMBRE: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Gusto en Conocerte: {0}",nombre);
            Console.ReadKey();
        }
    }
}
