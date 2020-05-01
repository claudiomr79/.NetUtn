using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("cuantas sucesiones de fibonacci?");
            int cant = int.Parse (Console.ReadLine());
;           int[] arreglo = new int [cant];
            arreglo[0] = 0;
            arreglo[1] = 1;
            for (int i =2 ; i<cant; i++)
            {
                arreglo[i] = arreglo[i-1] + arreglo[i-2];
            }
            for (int i = 0; i < cant; i++)
            {
                Console.Write(arreglo[i] + ",");  
            }
            Console.ReadKey();
        }
    }
}
