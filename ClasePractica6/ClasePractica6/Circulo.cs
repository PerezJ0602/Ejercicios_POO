using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica6
{
    public class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio, Ubicacion ubicacion) : base(ubicacion)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * this.radio * this.radio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * this.radio;
        }

        public override string ToString()
        {
            return "Círculo de radio " + radio + ", " + base.ToString();
        }
    }
}
