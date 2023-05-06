using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica8
{
    public class Pelicula
    {
        private string nombre;
        private int año;

        public Actor actor { get; set; }
        public Estudio estudio { get; set; }

        public Pelicula()
        {
            
        }

        public Pelicula(string nombre, int año)
        {
            this.Nombre = nombre;
            this.Año = año;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }

        public override string ToString()
        {
            return $"Película: {Nombre}, Año: {Año}, Actor: {actor.Nombre},Produce: {estudio.Nombre}";
        }
    }

}
