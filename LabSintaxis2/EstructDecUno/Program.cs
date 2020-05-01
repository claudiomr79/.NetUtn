using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructDecUno
{
    class Program 
    {
        static void Main(string[] args)
        {
            string inputTexto;
            Console.WriteLine("Ingrese un texto");
            inputTexto = Console.ReadLine();
            if (String.IsNullOrEmpty(inputTexto))
            {
                Console.WriteLine("No se ha ingresado ningun texto");
            }
            else
            {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("MENU:");
                Console.WriteLine("");
                Console.WriteLine("1 - MAYUSCULA " +
                                  " 2- MINUSCULA " +
                                  " 3- TAMAÑO ");
                Console.WriteLine("");
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.NumPad1 || opcion.Key == ConsoleKey.NumPad2 || opcion.Key == ConsoleKey.NumPad3)
                {
                    if (opcion.Key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine("en mayusculas ", inputTexto.ToUpper());
                        Console.ReadKey();
                    }
                    if (opcion.Key == ConsoleKey.NumPad2)
                    { 
                        Console.WriteLine(inputTexto.ToLower());
                        Console.ReadKey();
                    }
                    if (opcion.Key == ConsoleKey.NumPad3)
                    {
                        Console.WriteLine(inputTexto.Length);
                        Console.ReadKey();
                        
                    }
                       

                }  
            }

            Console.ReadKey();
        }
    }
}
