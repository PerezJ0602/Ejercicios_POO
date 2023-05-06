using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica7
{
    public class Profesor: Persona
    {
        public Profesor(string nombre) : base(nombre)
        {
            
        }

        public void Explicar()
        {
            Console.WriteLine("{0} Está explicando", Nombre);
        }
    }
}
