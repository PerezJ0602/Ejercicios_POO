using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Computadora miCompu = new Computadora(500, 150, false);
            Manejo mane = new Manejo();
            //miCompu.Encender();
            mane.Añadirdatos(miCompu, 100);
            Manejo.EliminarDatos(miCompu, 0);

            miCompu.Apagar();
        }
    }
}
