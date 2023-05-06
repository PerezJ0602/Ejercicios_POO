using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ClasePractica8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se define los valores de los objetos
            Pelicula pelicula = new Pelicula("Avatar: The way of water", 2022);
           
            Actor actor = new Actor("Zoe", "Zaldaña");
          
            Estudio estudio = new Estudio("20th century fox", "Los Angeles");
          
           // Asignacion de valores en los campos de las clases relacionadas
            actor.pelicula = new Pelicula();
            actor.pelicula.Nombre = pelicula.Nombre;

            pelicula.actor = new Actor();
            pelicula.actor.Nombre = "Ryūnosuke Kamiki";

            pelicula.estudio = new Estudio();
            pelicula.estudio.Nombre = "Tōhō";

            estudio.pelicula = new Pelicula();
            estudio.pelicula.Nombre = "Your name";



            Console.WriteLine(pelicula);
            Console.WriteLine();
            Console.WriteLine(actor);
            Console.WriteLine();
            Console.WriteLine(estudio);

            Console.ReadKey();
        }
    }
}
