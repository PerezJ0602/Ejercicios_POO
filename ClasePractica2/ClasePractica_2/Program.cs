using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De el nombre de la casa comercial: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("De el email de la casa comercial: ");
            string email = Console.ReadLine();
            
            //Desfinir objeto de casa comercial
            CasaComercial cc = new CasaComercial("Casa Pella","Contacto@casapellas.com",0, new List<Vehiculo>());
            Console.WriteLine("De la informacion del primer vehiculo a agregar: ");

            CasaComercial cc2 = new CasaComercial("Casa Q", "Q.com", 0, new List<Vehiculo>());
            cc2.aniadirVehiculo(new Vehiculo(2, "z", "suzuki", 9000, 1000, 2020));

            //Informacion del nuevo vehiculo a agreegar
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Año: ");
            int anio = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            //Procedemos a agreegar el vehiculo usando el metodo de la clase casa aomercial
            cc.aniadirVehiculo(new Vehiculo(1,modelo,marca,km,precio,anio));
            cc.mostrarVehiculo();
            cc.vaciarVehiculo();
            cc.eliminarVehiculo(new Vehiculo(1, modelo, marca, km, precio, anio));
     


            Console.ReadKey();


        }
    }
}
