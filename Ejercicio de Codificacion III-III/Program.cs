using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_III_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========> CONDICION DE UNA PERSONA POR SU EDAD <======== \n");

            int edad;
            Console.WriteLine("Ingresa la Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad == 0 || edad == 1)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Bebe");
                Console.ReadKey();
            }
            if (edad >= 2 && edad <= 12)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Niño");
                Console.ReadKey();
            }
            if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Adolecente");
                Console.ReadKey();
            }
            if (edad >= 18 && edad <= 30)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Joven");
                Console.ReadKey();
            }
            if (edad >= 31 && edad <= 64)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Adulto");
                Console.ReadKey();
            }
            if (edad >= 65 && edad <= 120)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Anciano");
                Console.ReadKey();
            }
            if (edad < 0 || edad > 120)
            {
                Console.WriteLine($"Condicion de la Persona: {edad} | Error");
                Console.ReadKey();
            }

        }
    }
}
