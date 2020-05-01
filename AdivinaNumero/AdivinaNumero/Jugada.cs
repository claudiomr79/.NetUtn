using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivinaNumero
{
    public class Jugada
    {
        #region ATRIBUTOS
        private bool _adivino;
        private int _intentos;
        private int _numero;
        #endregion
        #region PROPIEDADES
        public bool Adivino
        {
            get { return _adivino; }
            set { _adivino = value; }
            
        }

        public int Intentos
        {
            get { return _intentos; }
            set { _intentos = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        #endregion
        #region METODOS
        public Jugada(int maxNumero)
        {
            Intentos = 0;
            Adivino = false;
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public void Comparar (int numeroAcomparar) 
        {
            Intentos = Intentos + 1;
            if (Numero == numeroAcomparar)
            {
                Adivino = true; // acertó el numero 
            }

        }
        #endregion
    }
}