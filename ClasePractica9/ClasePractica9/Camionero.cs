using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica9
{
    public class Camionero
    {
        private string nombre;
        private int telefono;
        private string direccion;
        private string poblacion;
        private int rfc;
        private decimal salario;

        public Camion camion { get; set;}
        public Paquete paquete { get; set; }


        public Camionero()
        {
            
        }
        public Camionero(string nombre, int telefono, string direccion, string poblacion, int rfc, decimal salario)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Poblacion = poblacion;
            this.Rfc = rfc;
            this.Salario = salario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public int Rfc { get => rfc; set => rfc = value; }
        public decimal Salario { get => salario; set => salario = value; }


        public override string ToString()
        {
            return $"Camionero: Nombre: {Nombre}, Teléfono: {Telefono}, Dirección: {Direccion},Población: {Poblacion},RFC: {Rfc}, Salario {Salario}" +
                $"Camión: {camion.Matricula}, Paquete: {paquete.Codigo}";
        }

    }
}
