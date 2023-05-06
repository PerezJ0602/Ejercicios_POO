using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Moto:Vehiculo
    {
        bool sidecar;

        public Moto(string marca, string modelo, int km,decimal precio ,int año,bool sidecar):base(marca,modelo,km,precio,año)
        {
            this.sidecar = sidecar;
        }

        public bool Sidecar { get => sidecar; set => sidecar = value; }
        public override decimal CalcularPrecio()
        {
            if (Sidecar)
            {
                return base.CalcularPrecio() + 50;
            }
            else
            {
                return base.CalcularPrecio();
            }
        }
    }
}
