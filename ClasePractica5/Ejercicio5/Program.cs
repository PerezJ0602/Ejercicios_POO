using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el id del album ");
            int ids = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del album ");
            string nombe = Console.ReadLine();
            Album alb = new Album(0,"","",new List<Foto>());
            Console.WriteLine("Id de la foto: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño de la foto en megas mb: ");
            decimal tamaño = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Fecha de la foto: ");
            string fecha = Console.ReadLine();
            Console.WriteLine("Ingrese un comentario: ");
            string comentario = Console.ReadLine();

            //metodo de añadir vehiculo
            alb.añadirFoto(new Foto(1, tamaño, fecha, comentario));
            alb.mostrarFoto();
            alb.tamañoAlbum();
            alb.vaciarFoto();
            alb.eliminarFoto(new Foto(1,tamaño,fecha,comentario));
        }
    }
}
