using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Diplomado
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jeury";
            string apellido = "Suarez ";
            string apodo = "El Flaco";
            string fechanacimiento = "13 de Abril del 1995";
            string teléfono = "809-584-3333";
            string móvil = "829-654-9999";
            string país = "Republica Dominicana"; 
            string cuidad = "San Francisco de Macoris";
            string dirección = "C/ Olegario Tenares";
            string lugardetrabajo = "Claro Dominicana";
            string sueldo = "$20,000.00";


           Console.WriteLine("===========> INFORMACION PERSONAL <======== \n");
           Console.WriteLine($"Nombre: {nombre}");
           Console.WriteLine($"Apellido: {apellido}");
           Console.WriteLine($"Apodo: {apodo}");
           Console.WriteLine($"Fecha de Nacimiento: {fechanacimiento}");
           Console.WriteLine($"Telefono: {teléfono}");
           Console.WriteLine($"Movil: {móvil}");
           Console.WriteLine($"Pais: {país}");
           Console.WriteLine($"Ciudad: {cuidad}");
           Console.WriteLine($"Direccion: {dirección}");
           Console.WriteLine($"Lugar de Trabajo: {lugardetrabajo}");
           Console.WriteLine($"Sueldo: {sueldo}");

            Console.Read();
        }
    }
}
