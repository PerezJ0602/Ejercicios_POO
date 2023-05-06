using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Manejo
    {
        public void Añadirdatos(Computadora compu,int datos)
        {
            if (compu.Encendido)
            {
                int espacioRestante = compu.Capacidad - compu.Espaciorestante;
                if (espacioRestante >= datos)
                {
                    compu.Espaciorestante += datos;
                    Console.WriteLine("Se agrego la cantidad de {0} datos ", datos);
                }
                else
                {
                    compu.Espaciorestante = compu.Capacidad;
                    Console.WriteLine("No se puede agregar mas datos ");
                   
                }
            }
            else
            {
                Console.WriteLine("La computadora está apagada. Enciéndala para agregar información.");
            }

        }
        public static void EliminarDatos(Computadora compu,int datos)
        {
            if (compu.Encendido)
            {
                compu.Espaciorestante = datos - datos;
                if (compu.Espaciorestante <= 0)
                {
                    compu.Espaciorestante = 0;
                }
                Console.WriteLine("Se ha borrado la cantidad de {0} datos ",datos);
            }
            else
            {
                Console.WriteLine("La computadora está apagada. Enciéndala para eliminar información.");
            }
        }
        
    }
}
