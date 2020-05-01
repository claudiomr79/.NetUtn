using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    public class Ciudad
    {
        public string nombre { get; set; }
        public string codigoPostal { get; set; }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ciudades = new ArrayList();
            ciudades.Add(
                new Ciudad
                {
                    nombre = "Rosario",
                    codigoPostal = "2000"
                });
            ciudades.Add(
                new Ciudad
                {
                    nombre = "Ramallo",
                    codigoPostal = "2915"
                });
            ciudades.Add(
                new Ciudad
                {
                    nombre = "San Nicolas",
                    codigoPostal = "2900"
                });
            ciudades.Add(
                new Ciudad
                {
                    nombre = "Cap Federal",
                    codigoPostal = "1000"
                });
            string entrada;
            Console.WriteLine("Escriba  una expresión de busqueda de tres caracteres");
            do
            {
                entrada = Console.ReadLine();
                if (entrada.Length != 3)
                    Console.WriteLine("->Deben ser tres caracteres para la busqueda.");
            } while (entrada.Length != 3);
            //busqueda

            var query = from Ciudad c in ciudades
                        where c.nombre.ToUpper().Contains(entrada.ToUpper())
                        select c;

            foreach (Ciudad c in query)
                Console.WriteLine(c.nombre + ": " + c.codigoPostal);

            Console.ReadKey();
        }
    }
}  

