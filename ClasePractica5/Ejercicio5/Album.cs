using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
   
    class Album
    {
        private List<Foto> Fotos;
        int id;
        string nombre;
        string fechacreacion;

        public Album(int id, string nombre, string fechacreacion, List<Foto> Fotos)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechacreacion = fechacreacion;
            this.Fotos1 = Fotos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fechacreacion { get => fechacreacion; set => fechacreacion = value; }
        public List<Foto> Fotos1 { get => Fotos; set => Fotos = value; }

        public void añadirFoto(Foto f)
        {
            try
            {
                //añadir fotos a la lista
                this.Fotos1.Add(f);
                this.id += 1;
                Console.WriteLine("Se agrego la foto ");
            }
            catch(Exception ex)
            {
                Console.WriteLine("No se pudo agregar la foto ",ex.Message);
                Console.ReadLine();
            }
        }
        public void mostrarFoto()
        {
            foreach (var f in this.Fotos1)
            {
                Console.WriteLine("\nMostrando lista ");
                Console.WriteLine(f.ToString());
            }
        }
        public void vaciarFoto()
        {
            Console.WriteLine("\n¿Esta seguro que quiere eliminar todas las fotos? Escriba Si o No");
            string respuesta = Console.ReadLine();
            if (respuesta == "Si" || respuesta == "si")
            {
                Fotos = new List<Foto>();
                this.id = 0;
                Console.WriteLine("\nSe han eliminados todas las fotos ");
            }
            else
            {
                Console.WriteLine("No se ha borrado la foto y hay una cantidad de {0} fotos ",id);
            }
            Console.ReadLine();
        }
        public void eliminarFoto(Foto f)
        {
            Console.WriteLine("\n¿Esta seguro que quiere eliminar la fotos? Escriba Si o No");
            string respuesta = Console.ReadLine();
            if (respuesta == "Si" || respuesta == "si")
            {
                Fotos.Remove(f);
                id -= 1;
                Console.WriteLine("\nSe ha eliminado una foto");
            }
            else
            {
                Console.WriteLine("No se ha borrado la foto");
            }
            Console.ReadLine();
        }
        public void tamañoAlbum()
        {
           
            decimal suma=0;
            decimal total=0;
            foreach (var f in this.Fotos)
            {
                suma += f.Tamaño;
                
            }
            total = suma / 1024;
            Console.WriteLine("El tamaño del album es {0:0.00} GB", total);
            Console.ReadLine();

        }
        
    }
}

