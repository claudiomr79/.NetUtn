using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NroRomano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de 1 a 3999");
            entrada = int.Parse (Console.ReadLine());
            
            string NumRoman = "";

            while (entrada > 0)
            {
                NumRoman += Letra();
            }
            Console.WriteLine($"Equivalente en numeros romanos es: {NumRoman}");
            Console.ReadKey();
        }

        static int entrada;

        static string Letra()
        {
            Dictionary<int, string> RomanNumeral = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM" },
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC" },
                {50, "L"},
                {40, "XL" },
                {10, "X"},
                {9, "IX"},
                {5, "V" },
                {4, "IV"},
                {1, "I"}
            };

            foreach (KeyValuePair<int, string> number in RomanNumeral)
            {
                if (entrada >= number.Key)
                {
                    entrada -= number.Key;
                    return number.Value;
                }
            }

            return "Error";
        }
    }
}
