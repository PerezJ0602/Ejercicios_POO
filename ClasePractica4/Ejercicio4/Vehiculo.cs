using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Vehiculo
    {
        string marca;
        string modelo;
        int km;
        decimal precio;
        int año;
        //contructor de la clase de vehiculo
        public Vehiculo(string marca, string modelo, int km, decimal precio, int año)
        {
            
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Año = año;
        }

       
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Año { get => año; set => año = value; }
        //public override string ToString()
        //{
        //    return "Moldelo: " + modelo + "\n" + "Marca:" + marca + "\n" + "Kilometro" + km + "\n" + "precio:" + precio + "\n" +
        //            "año" + año;
        //}
        public virtual decimal CalcularPrecio()
        {
            return precio;
        }

    }
}
