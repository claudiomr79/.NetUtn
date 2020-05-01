using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoClave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ingreso";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();


            int intentos = 0;
            string clave = "spaguetti";
            string ingreso = "";
            do
            {
                if (intentos < 4)
                {
                    intentos += 1;
                    Console.WriteLine("introduzca clave...");
                    ingreso = Console.ReadLine();
                    if (clave == ingreso)
                        Console.WriteLine("CLAVE CORRECTA");

                }
                else
                {
                    Console.WriteLine("Demasiadas entradas incorrectas!!!");
                    break;
                }
            } while (clave != ingreso);
            Console.ReadKey();
        }
    }
}
