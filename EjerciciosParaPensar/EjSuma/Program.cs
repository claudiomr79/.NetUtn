using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;

            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("El resultado de la suma de "+ num1 +" y "+ num2 +" es: "+suma);
            Console.ReadKey();
        }
    }
}
