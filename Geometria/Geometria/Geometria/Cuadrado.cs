using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado: Rectangulo
    {
        private double _Lado;
        public double Lado
        {
            get { return _Lado; }
            set { _Lado = value; }
        }
        public override double CalcularPerimetro()
        {
            return Lado*4;
        }
        public override double CalcularSuperficie()
        {
            return Lado*Lado;
        }
        public Cuadrado (double l)
        {
            Lado = l;
        }
    }
}