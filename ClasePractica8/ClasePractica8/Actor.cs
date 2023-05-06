using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica8
{
   public class Actor
    {
        private string nombre;
        private string apellido;
        
        public Pelicula pelicula { get; set; }

        public Actor()
        {
            
        }
        public Actor(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"Actor: {Nombre}, Apellido: {Apellido}, Película: {pelicula.Nombre}";
        }
    }
}
