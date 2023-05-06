using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica10
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona()
        {
            
        }
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }


        public void Mostrar()
        {
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Edad: "+ edad);
        }
    }
}
