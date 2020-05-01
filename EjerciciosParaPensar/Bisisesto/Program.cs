using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisisesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año para verificar si es <Bisiesto>");
            string ingreso = Console.ReadLine();
            int anio = Convert.ToInt32(ingreso);
            bool resultado = EsBisiesto(anio);
            if (resultado) {
                Console.WriteLine("El año " + anio + " ES bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + anio + " NO es bisiesto");
            }
            Console.ReadKey();

        }

        private static bool EsBisiesto(int anio)
        {
            bool ban = false;
            if (anio % 100 == 0)  
            {
               if (anio % 400 == 0)
                {
                    ban = true;
                }
                    
            }else if (anio % 4 == 0)
            {
                ban = true;
            }
            return ban;
        }
    }  
}



