using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica6
{
    public class Figura
    {
        //Agregando dependencia de la clase Ubicación
        public Ubicacion ubicacion;

        public Figura(Ubicacion ubicacion)
        {
            this.ubicacion = ubicacion;
        }


        public virtual double CalcularArea()
        {
            return 0;
        }
        public virtual double Perimetro()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Figura ubicada en " + ubicacion.ToString();
        }
    }
}
