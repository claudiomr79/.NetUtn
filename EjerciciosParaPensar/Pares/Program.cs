using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numeros pares entre el 1 y el 100...");
            for (int i= 1; i<=100 ; i++ )
            {
                if (i % 2 == 0)
                    Console.Write(i + ",");
            }Console.ReadKey();

        }
    }
}
