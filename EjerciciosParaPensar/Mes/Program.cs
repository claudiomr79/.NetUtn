using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes
{
    class Program
    {
        enum Meses
        {
            ENERO = 1,
            FEBRERO,
            MARZO,
            ABRIL,
            MAYO,
            JUNIO,
            JULIO,
            AGOSTO,
            SEPTIEMBRE,
            OCTUBRE,
            NOVIEMBRE,
            DICIEMBRE
        };


        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes.....ej..enero, febrero,etc...");
            string entrada = Console.ReadLine();
            //entrada.ToUpper();
            int i = 1;//para el primer mes
            foreach (string str in Enum.GetNames(typeof(Meses)))
            {

                    if (str == entrada.ToUpper())
                     Console.WriteLine("MES < {0} > < {1} >", str, i);
                i++;
            }
            Console.ReadKey();
        }
        
        
    }
}
