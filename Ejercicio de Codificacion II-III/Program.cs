using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II_III
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            double precio = 0, cantidad = 0, total = 0, totalITBIS = 0, ITBI =0;
            double ITBIS = 0.18;

            Console.WriteLine("===========> CALCULAR EL ITBIS <======== \n");

            Console.WriteLine("Nombre del Producto: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Precio: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            cantidad = Convert.ToDouble(Console.ReadLine());

            total = precio * cantidad;
            ITBI = total * ITBIS;
            totalITBIS = ITBI + total;

            Console.WriteLine("===========> FACTURA <======== \n");
            Console.WriteLine($"Producto.............:{nombre}");
            Console.WriteLine($"Precio..............:${precio}");
            Console.WriteLine($"Sub-Total...........:${total}");
            Console.WriteLine($"Total a Pagar.......:${totalITBIS}");
            Console.ReadKey();

        }
    }
}
