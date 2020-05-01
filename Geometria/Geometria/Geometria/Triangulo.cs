using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private double _LadoB;
        private double _LadoA;
        private double _LadoC;

        public double LadoB
        {
            get { return _LadoB; }
            set { _LadoB = value; }
        }
        public double LadoA
        {
            get { return _LadoA; }
            set { _LadoA = value; }
        }

        public double LadoC
        {
            get { return _LadoC; }
            set { _LadoC = value; }
        }

        public double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public double CalcularSuperficie()
        {
            /*segun formula de heron
            superficie de un triangulo es
            (p*(p-a)*(p-b)*(p-c))^1/2
            con p = semiperimetro*/

            double p;
            p = CalcularPerimetro() / 2;
            return Math.Pow(p * (p - LadoA) * (p - LadoB) * (p - LadoC), 0.5);

        }

        public Triangulo(double a, double b, double c)
        {
            LadoA = a;
            LadoB = b;
            LadoC = c;
        }


    }
}