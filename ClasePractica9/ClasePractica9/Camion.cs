using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica9
{
    public class Camion
    {
        private int potencia;
        private int matricula;
        private string modelo;
        private string tipo;

        public Camionero camionero { get; set; }

        public Camion()
        {
           
        }
        public Camion(int potencia, int matricula, string modelo, string tipo)
        {
            this.Potencia = potencia;
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Tipo = tipo;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return $"Camión: Potencia: {Potencia}, Matrícula: {Matricula}, Modelo: {Modelo}, Tipo: {Tipo}, Camionero: {camionero.Nombre}";
        }
    }
}
