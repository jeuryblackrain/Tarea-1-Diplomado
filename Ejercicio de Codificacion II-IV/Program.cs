using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Codificacion_II_IV
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double SB, SN, DD = 0.10, HT , TH;

            Console.WriteLine("===========> SUELDO BRUTO DE UN EMPLEADO <======== \n");

        
            Console.WriteLine("Ingrese su Tarifa por Hora: ");
            TH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa sus Horas de Trabajo: ");
            HT = Convert.ToDouble(Console.ReadLine());


            SB = TH * HT;
            SN =  SB - (SB * DD);

            Console.WriteLine("===========> NOMINA DEL EMPLEADO <======== \n");
            Console.WriteLine($"SUELDO BRUTO................:${SB}");
            Console.WriteLine($"% DE DESCUENTO..........:${DD}");
            Console.WriteLine($"SUELDO NETO.............:${SN}");
            Console.WriteLine($"HORAS DE TRABAJO........:${HT}");
            Console.WriteLine($"TARIFA POR HORA.........:${TH}");
            Console.ReadKey();
        }
    }
}
