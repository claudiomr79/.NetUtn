using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine("Ingrese la cantidad de filas para el triangulo..");
            int n =int.Parse (Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i*2 ; k++)
                {
                    
                        Console.Write("*");
                   
                }
                Console.WriteLine();
            }

            Console.ReadKey();  
        }
    }
}
