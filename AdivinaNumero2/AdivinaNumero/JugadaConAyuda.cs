using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivinaNumero
{
    public class JugadaConAyuda : Jugada 
    {
        public JugadaConAyuda(int maxNumero) :base (maxNumero)
        { 
            //constructor nuevo q llama a la clase padre
        }
        public override void Comparar(int numeroAcomparar) //nueva clase para ayudar al jugador
        {
            Intentos = Intentos + 1;
            int diferencia = Math.Abs(numeroAcomparar - Numero);
            if (diferencia <= 5)
                Console.WriteLine("Està muy cerca!!");
            if (diferencia >= 100 && numeroAcomparar > Numero )
                Console.WriteLine("Ud eligio un nro mucho mayor y està muy lejos!!!");
            if (Numero == numeroAcomparar)
            {
                Adivino = true; // acertó el numero 
            }

        }
    }
}