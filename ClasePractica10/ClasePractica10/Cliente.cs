using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica10
{
    public class Cliente: Persona
    {
        private int telefeno;

        public Cliente()
        {
            
        }

        public Cliente(string nombre,int telefeno)
        {
            this.Nombre = nombre;
            this.Telefeno = telefeno;
        }

        public int Telefeno { get => telefeno; set => telefeno = value; }


        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Teléfono: "+ Telefeno);
        }

    }
}
