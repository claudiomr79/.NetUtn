using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        
            static void Main()
            {
                
                // 1. Fuente de datos
                string [] provincias = new string[23] { "BsAs", "Catamarca", "Chaco", "Chubut",
                    "Cordoba", "Corrientes", "Entre Rios", "Formosa","Jujuy", "La Pampa", "La Rioja", 
                    "Mendoza", "Misiones", "Neuquen", "Rio Negro", "Salta" , "San Juan", 
                    "San Luis", "Santa fe", "Santa Cruz", "Sgo del Estero", "Tierra del fuego", 
                    "Tucuman" };

                // 2. Creacion del query
                
                var provQuery =
                    from prov in provincias
                        where (prov.ToUpper().StartsWith("T")) || (prov.ToUpper().StartsWith("S"))
                        orderby prov
                        select prov;

                // 3. Ejecucion del query
                foreach (string prov in provQuery)
                {
                    Console.WriteLine("{0}", prov);
                   
                }
                Console.ReadKey();
            }
        

    }
}
