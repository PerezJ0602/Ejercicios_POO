using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Computadora
    {
        int capacidad;
        int espaciorestante;
        bool encendido;

        public Computadora(int capacidad, int espaciorestante, bool encendido)
        {
            this.capacidad = capacidad;
            this.espaciorestante = espaciorestante;
            this.encendido = encendido;
        }

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Espaciorestante { get => espaciorestante; set => espaciorestante = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        public void Encender()
        {
            encendido = true;
            Console.WriteLine("Bienvendio ");
        }
        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("Hasta pronto");
        }
        public override string ToString()
        {
            return "Tamaño de disco: " + capacidad + "Tamaño restante: " + espaciorestante;
        }
    }
}
