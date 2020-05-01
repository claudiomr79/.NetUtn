using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq4
{
    /*Dada una List<Empleado> donde Empleado tiene las propiedades Id (int), 
     * Nombre (string), Sueldo (decimal). Crear un programa que acepte dar 
     * de alta Empleados en esta lista y luego muestre por Consola esta misma 
     * Lista ordenada por la propiedad Sueldo, tanto de manera ascendente como 
     * descendente.*/
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public double Sueldo { get; set; }

        public Empleado ( int id, string nombre, double sueldo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Sueldo = sueldo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int entradaId, continua;
            string entradaNombre, entradaNumerica;
            double entradaSueldo;
            var Empleados = new List<Empleado>();
            do
            {
                Console.Write("ID:");
                entradaId = Convert.ToInt16(Console.ReadLine());
                Console.Write("Nombre:");
                entradaNombre = Console.ReadLine();
                Console.Write("Sueldo:");//debe ingresar con coma los decimales
                entradaNumerica = Console.ReadLine();
                entradaSueldo = double.Parse(entradaNumerica);
                Empleado emp = new Empleado(entradaId, entradaNombre, entradaSueldo);
                Empleados.Add(emp);
                Console.WriteLine("Continua 1=si 2= no");
                continua = Convert.ToInt16(Console.ReadLine());
            } while (continua == 1);

            //ordena ascendente
            var ascendente = from Empleado e in Empleados
                             orderby e.Sueldo
                             select e;
            //muestra 
            Console.Clear();
            foreach (Empleado e in ascendente)
                Console.WriteLine($"{ e.Id}      { e.Nombre,10}     ${ e.Sueldo,10:F2} ");

            //--------------------------------------
            //ordena descendente
            var descendente = from Empleado emp in Empleados
                              orderby emp.Sueldo descending
                              select emp;
            //muestra 
            Console.WriteLine("--------------------------------");
            foreach (Empleado e in descendente)
                Console.WriteLine($"{ e.Id}      { e.Nombre,10}     ${ e.Sueldo,10:F2} ");

            Console.ReadKey();
        }
    }
}
