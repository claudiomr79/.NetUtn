using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int> { 5, 7, 9, 0, 50, 25, 3, 80, 100 };

            var numQuery = from num in numeros
                           where (num > 20)
                           orderby num
                           select num;

            foreach (var numero in numQuery)
            {
                Console.WriteLine($"{numero} ");
            }

        }
    }
}
