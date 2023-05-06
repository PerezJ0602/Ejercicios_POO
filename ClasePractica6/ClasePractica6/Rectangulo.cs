using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica6
{
    public class Rectangulo : Figura
    {
        private double lado1;
        private double lado2;

        public Rectangulo(double lado1, double lado2, Ubicacion ubicacion) : base(ubicacion)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public override double CalcularArea()
        {
            return this.Lado1 * this.Lado2;
        }

        public override double Perimetro()
        {
            return this.Lado1 + this.Lado2;
        }
        public override string ToString()
        {
            return "Rectángulo de lados " + Lado1 + " y " + Lado2 + ", " + base.ToString();
        }
    }
}
