using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivinaNumero
{
    public class Juego
    {
        #region ATRIBUTOS
        private int _record; 
        #endregion
        #region PROPIEDADES
        public int Record
        {
            get { return _record; }
            set { _record = value; }

        } 
        #endregion
        #region METODOS
        public Juego()
        {
            Record = Int16.MaxValue; // seteo el record en el maximo valor
        }

        public void ComenzarJuego()
        {
            int numeroMaximo, numeroElegido;
            bool acierto = false , continua = false ;
            numeroMaximo = PreguntarMaximo();
            do
            {
                Console.Clear();
                Jugada jugada = new Jugada(numeroMaximo);//instancia de jugada para que sortee un numero 
                do
                {
                    do
                    {
                        numeroElegido = PreguntarNumero();
                        if (numeroElegido > numeroMaximo)
                            Console.WriteLine("ingrese un valor menor al maximo ingresado anteriormente : " + numeroMaximo);
                    } while (numeroElegido > numeroMaximo);
                    
                    jugada.Comparar(numeroElegido);
                    acierto = jugada.Adivino;
                    if (acierto == true) //veo si se acertó el nro
                    {
                        Console.WriteLine("Acertaste el numero!!!");
                        CompararRecord(jugada.Intentos);
                    }

                } while (acierto == false);
                Console.WriteLine("EL record actual es: " + Record + " intentos");
                continua = Continuar();
            } while (continua == true);
        }

        private void CompararRecord(int recordNuevo)
        {
            
            if (recordNuevo <= Record) 
                 Record = recordNuevo ;
            
        }

        private bool Continuar()
        {
            ConsoleKeyInfo op;
            //pregunta si quiere seguir jugando
            Console.WriteLine("Desea seguir Jugando s/n: ");
            op = Console.ReadKey();
            if (op.Key == ConsoleKey.S )//chequeo que pulse s
                return true;
            else
                return false;
            
        }

        private int PreguntarMaximo()
        {
            int max; // numero max a adivinar
            Console.Write ("Ingrese el numero máximo a adivinar: ");
            string entrada = Console.ReadLine();
            max = Convert.ToInt16(entrada);//convierto a entero
            return max; // devuelvo numero maximo
        }

        private int PreguntarNumero()
        {
                      
            int nro;
            string entrada;
            Console.Write("Ingrese su numero mayor que cero por favor: ");
            do
            {
                entrada = Console.ReadLine();
                nro = Convert.ToInt16(entrada); //convierto el string en entero
            } while (nro < 0 ); //chequeo que sea mayor a cero
            return nro ;

        }
        #endregion
    }
}