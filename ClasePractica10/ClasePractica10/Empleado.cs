using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica10
{
    public class Empleado: Persona
    {
        
        private double sueldoBruto;

        public Empleado()
        {
           
        }
        public Empleado(string nombre,double sueldoBruto)
        {
            this.Nombre = nombre;
            this.SueldoBruto = sueldoBruto;
        }

        public double SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }



        public double CalcularSalarioNeto()
        {
            double salarioNeto = 0.0;

            // Cálculo del salario neto
            double imp = SueldoBruto * 0.18; // Implementacion del Iva
            salarioNeto = SueldoBruto - imp;

            return salarioNeto;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Salario Bruto: "+ sueldoBruto);
            Console.WriteLine("Salario neto: "+ CalcularSalarioNeto());
        }

    }
}
