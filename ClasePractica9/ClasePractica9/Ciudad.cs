using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica9
{
    public class Ciudad
    {
        private int codigo;
        private string nombre;

        public Paquete paquete { get; set; }

        public Ciudad()
        {
           
        }

        public Ciudad(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"Ciudad: Código: {Codigo}, Nombre: {Nombre}, Paquete: {paquete.Codigo}";
        }

    }
}
