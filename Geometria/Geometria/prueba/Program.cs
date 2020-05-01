using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo cir = new Circulo(3);
            Triangulo tri = new Triangulo(10, 10, 10);
            Cuadrado cuad = new Cuadrado(5); 
            Console.WriteLine("El perimetro del circulo es : " + cir.CalcularPerimetro() + " y la superficie es: " + cir.CalcularSuperficie());
            Console.WriteLine("El perimetro del triangulo es : " + tri.CalcularPerimetro() + " y la superficie es: " + tri.CalcularSuperficie());
            Console.WriteLine("El perimetro del cuadrado es : " + cuad.CalcularPerimetro() + " y la superficie es: " + cuad.CalcularSuperficie());
            Console.ReadKey();
        }
    }
}
