using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pers1 = new Persona("raquel", "nuñez", 33, "5132455");
            Console.WriteLine(pers1.GetAge());
            Console.WriteLine(pers1.GetFullName());
         
            Console.ReadKey();
        }
    }
}
