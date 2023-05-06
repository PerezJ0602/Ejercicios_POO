using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se define los valores de los objetos
            Camion camion = new Camion(10,0005,"Hyunday","Transporte de carga");
            Camionero camionero = new Camionero("Juan",55555555,"Villa el Carmen","Managua",78,20000);
            Paquete paquete = new Paquete(01,"Alimentos","Julio","Barrio Villa libertad");
            Ciudad ciudad = new Ciudad(01,"Managua");


            // Asignacion de valores en los campos de las clases relacionadas
            camion.camionero = new Camionero();
            camion.camionero.Nombre = camionero.Nombre;
            
            camionero.camion = new Camion();
            camionero.camion.Matricula = camion.Matricula;

            camionero.paquete = new Paquete();
            camionero.paquete.Codigo = paquete.Codigo;

            paquete.camionero = new Camionero();
            paquete.camionero.Nombre = camionero.Nombre;

            paquete.ciudad = new Ciudad();
            paquete.ciudad.Nombre = ciudad.Nombre;

            ciudad.paquete = new Paquete();
            ciudad.paquete.Codigo = paquete.Codigo;


            Console.WriteLine(camion);
            Console.WriteLine();
            Console.WriteLine(camionero);
            Console.WriteLine();
            Console.WriteLine(paquete);
            Console.WriteLine();
            Console.WriteLine(ciudad);

            Console.ReadKey();
        }
    }
}
