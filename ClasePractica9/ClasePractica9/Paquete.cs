using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica9
{
    public class Paquete
    {
        private int codigo;
        private string descripcion;
        private string destinatario;
        private string direccion;
        public Ciudad ciudad { get; set; }
        public Camionero camionero { get; set; }
        public Paquete()
        {
           
        }

        public Paquete(int codigo, string descripcion, string destinatario, string direccion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public override string ToString()
        {
            return $"Paquete: Código: {Codigo}, Descripción: {Descripcion}, Destinatario: {Destinatario}, Dirección: {Direccion}, Ciudad: {ciudad.Nombre}, Camionero: {camionero.Nombre} ";
        }

    }
}
