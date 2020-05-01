using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persona
{
    public class Persona
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;
        private string _Dni;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
           
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        public int GetAge()
        {
            return Edad;
        }

        public string GetFullName()
        {
            return (Nombre + " " + Apellido);
        }

        public Persona (string nom, string ap, int edad, string dni)
        {
            Nombre = nom;
            Apellido = ap;
            Edad = edad;
            Dni = dni;
            Console.WriteLine("Objeto creado!!");
        }

         ~Persona()
        {
            Console.WriteLine("Ojeto destruido");
        }
    }
}