using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo
    {
        private double  m_radio;

        public double Radio
        {
            set { m_radio = value; }
            get { return m_radio; }
        }
        public Circulo(double r)
        {
            Radio = r;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
