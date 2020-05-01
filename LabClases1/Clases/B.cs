using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class B: A
    {
        public void M4()
        {
            Console.WriteLine("Metodo de hijo invocado");
        }

        public B() : base("Instancia de B")
        {

        }
    }
}
