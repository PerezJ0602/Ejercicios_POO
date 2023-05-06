using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instanciar clase vehivulo
            Vehiculo veh = new Vehiculo(1,"Nissan","Aveo",5000,15000,2017);
            Console.WriteLine(veh.ToString());
            Console.ReadKey();



        }
    }
}
