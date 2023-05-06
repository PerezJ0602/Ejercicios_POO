using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica8
{
    public class Estudio
    {
        private string nombre;
        private string direccion;

        public Pelicula pelicula { get; set; }

        public Estudio()
        {
           
        }
        public Estudio(string nombre, string dirrecion)
        {
            this.Nombre = nombre;
            this.Direccion = dirrecion;
        }

       
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

      

        public override string ToString()
        {
            return $"Estudio: {Nombre}, Dirección: {Direccion}, Película: {pelicula.Nombre}";
        }
    }
}
