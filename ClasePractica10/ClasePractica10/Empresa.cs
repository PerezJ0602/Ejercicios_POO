using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica10
{
    public class Empresa
    {
        private string nombre;
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        
        public Empresa()
        {
            
        }

        public Empresa(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
       

    }
}
