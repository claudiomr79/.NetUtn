using System;

namespace Clases
{
    public class A
    {
        
        public String NombreInstancia
        {
            get; set;
        }

        public A() {
             NombreInstancia = "Instancia sin nombre";
        }

        public A (String nom)
        {
            NombreInstancia = nom;
        }

        public void MostrarNombre()
        {
            System.Console.WriteLine(NombreInstancia);
        }

        public void M1()
        {
            System.Console.WriteLine("Fue invocado el metodo 1");
        }
        public void M2()
        {
            System.Console.WriteLine("Fue invocado el metodo 2");
        }
        public void M3()
        {
            System.Console.WriteLine("Fue invocado el metodo 3");
        }
    }

}
