﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica_2
{
    public class Vehiculo
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private decimal precio;
        private int año;
        

        //contructor de la clase de vehiculo
        public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int año)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Año = año;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Año { get => año; set => año = value; }

        public override string ToString()
        {
            return "Modelo: " + modelo + "\n" + "Marca:" + marca + "\n" + "Kilómetro" + km + "\n" + "Precio:" + precio + "\n" +
                    "Año" + año;
        }

    }
}
