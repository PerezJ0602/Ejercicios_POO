using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Auto:Vehiculo
    {
        bool airbag;

        public Auto(string marca, string modelo,int km,decimal precio, int año, bool airbag) : base(marca,modelo,km,precio,año)
        {
            
            this.airbag = airbag;
        }

        public bool Airbag { get => airbag; set => airbag = value; }

        public override decimal CalcularPrecio()
        {
            if (Airbag)
            {
                return base.CalcularPrecio() + 200;
            }
            else
            {
                return base.CalcularPrecio();
            }
        }
    }
}
