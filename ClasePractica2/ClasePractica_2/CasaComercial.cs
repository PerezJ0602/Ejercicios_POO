using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica_2
{
    public class CasaComercial
    {
        private string nombre;
        private string email;
        private int total;
        
        //Esto es composicion ya que la clase casa comercial posee una lista de objetos de tipo vehiculo
        private List<Vehiculo> vehiculos;
        public CasaComercial()
        {
            
        }
        public CasaComercial(string nombre, string email, int total, List<Vehiculo> vehiculos)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Total = total;
            this.Vehiculos = vehiculos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Total { get => total; set => total = value; }
        public List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }


        //se añade cada una de las clases solicitadas
        public void aniadirVehiculo(Vehiculo V)
        {
            try
            {
                //añadimos un nuevo objeto a la lista de vehiculo
                this.Vehiculos.Add(V);
                this.total = +1;
                Console.WriteLine("Se agredo el vehículo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo agregar el vehículo a: "+ ex.Message);
                Console.ReadLine();
            }

           
        }
        public void mostrarVehiculo()
        {
            foreach (var v in this.Vehiculos)
            {
                Console.WriteLine("......");
                Console.WriteLine(v.ToString()); 
            }
        }

        public void vaciarVehiculo()
        {
            Console.WriteLine("¿Está seguro que quiere eliminar el vehiculo? \n pulse "S" para aceptar y "N" para denegar.");
            string respose = Console.ReadLine();
            if (respose == "S" || respose == "s" )
            {
                vehiculos = new List<Vehiculo>();
                this.total = 0;
                Console.WriteLine("Se han eliminado los vehiculos");
            }
            else
            {
            }
            Console.ReadLine();
                Console.WriteLine("No se eliminó. \nHay{0} vehículos registrados",total);
        }


        public void eliminarVehiculo(Vehiculo v)
        {
            vehiculos.Remove(v);
            total -= 1;
            Console.WriteLine("Se ha eliminado un objeto");
            Console.ReadLine();
        }

    }



    

}
