using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_de_Codificaicon_III_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double SB, SN, DD, HT, TH;

            Console.WriteLine("===========> SUELDO BRUTO DE UN EMPLEADO <======== \n");


            Console.WriteLine("Ingrese su Tarifa por Hora: ");
            TH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa sus Horas de Trabajo: ");
            HT = Convert.ToDouble(Console.ReadLine());

            SB = TH * HT;
            if(SB > 5000)
            {
                DD = 0.10;
            }
            else
            {
                DD = 0.05;
            }
            SN = SB - (SB * DD);

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
