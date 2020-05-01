using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimosGemelos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, p, q, encontrado;
            p = 1;
            encontrado = 0;
            Console.WriteLine("Ingrese cantidad de parejas deseadas:");
            n = int.Parse(Console.ReadLine());
            while (encontrado < n)
            {
                q = p + 2;
                if (esPrimo(p) != 1 && esPrimo(q) != 1)
                {
                    Console.WriteLine("({0},{1})", p, q);
                    encontrado++;
                }
                p++;
            }
            Console.ReadKey();
        }
        //------------------------------------------------------
        static int esPrimo(int n)
        {
            int primo;
            int i;
            primo = 0;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                   primo = 1;   
            }
            return primo;
          
        }
    }
}
