using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            String[] arreglo;
            arreglo = new String[cantIteraciones];
            Console.WriteLine("Ingrese 5 datos:");
            for (int i = 0; i < cantIteraciones; i++)
            {
                arreglo[i] = Console.ReadLine();
            }
            Console.WriteLine("Al reves...");
            for (int i = 4; i >= 0; i--)
            {
                
                Console.WriteLine(arreglo[i]);
            
            }
            Console.ReadKey();
        }
    }
}
