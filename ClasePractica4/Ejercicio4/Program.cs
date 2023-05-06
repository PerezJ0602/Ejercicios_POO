using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tìpo de vehiculo es ");
            string tipoVehiculo = Console.ReadLine().ToLower();

            // Pedir datos del vehículo
            Console.WriteLine("Ingrese la marca del vehículo:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del vehículo:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el kilometraje: ");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del vehículo:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());

            // Crear objeto de la clase Auto o Moto según corresponda
            if (tipoVehiculo == "auto")
            {
                // Verificar si tiene airbag
                Console.WriteLine("¿El vehículo tiene airbag? (s/n):");
                string respuesta = Console.ReadLine();

                bool tieneAirbag = respuesta.ToLower() == "s";
                Auto auto = new Auto(marca, modelo,km, precio,año, tieneAirbag);
                Console.WriteLine("El precio del {0} es: {1}",tipoVehiculo,auto.CalcularPrecio());
            }
            else if (tipoVehiculo == "moto")
            {
                Console.WriteLine("¿El vehículo tiene Sidecar? (s/n):");
                string respuesta = Console.ReadLine();

                bool tieneSidecar = respuesta.ToLower() == "s";
                Moto moto = new Moto(marca, modelo, km, precio, año, tieneSidecar);
                Console.WriteLine("El precio de la {0} es: {1}",tipoVehiculo,moto.CalcularPrecio());
            }
            Console.ReadKey();
        }
    }
}
