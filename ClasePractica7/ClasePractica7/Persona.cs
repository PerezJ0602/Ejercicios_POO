﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica7
{
    public class Persona
    {
        private string nombre;

        public Persona()
        {
            
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return "Nombre"+"\n"+nombre;
        }
    }
}
