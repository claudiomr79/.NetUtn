using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego jugar = new Juego();
            jugar.ComenzarJuego();
            Console.ReadKey();
        }
    }
}
