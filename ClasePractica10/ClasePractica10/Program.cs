using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica10
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Crear una empresa
            Empresa miEmpresa = new Empresa();
            miEmpresa.Nombre = "Lafise";

            // Crear un empleado
            Empleado miEmpleado = new Empleado();
            miEmpleado.Nombre = "Steven";
            miEmpleado.Edad = 45;
            miEmpleado.SueldoBruto = 5000;

            // Agregar el empleado a la lista de empleados de la empresa
            miEmpresa.Empleados.Add(miEmpleado);

            // Crear un cliente
            Cliente miCliente = new Cliente();
            miCliente.Nombre = "Gaudy";
            miCliente.Edad = 22;
            miCliente.Telefeno = 22808300;

            // Agregar el cliente a la lista de clientes de la empresa
            miEmpresa.Clientes.Add(miCliente);

            // Mostrar información del empleado
            Console.WriteLine("Información del empleado:");
            miEmpleado.Mostrar();
            Console.WriteLine("\n");
            // Mostrar información del cliente
            Console.WriteLine("Información del cliente:");
            miCliente.Mostrar();
            Console.ReadKey();
        }
    }
}
