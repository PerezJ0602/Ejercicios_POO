using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Foto
    {
        int idfoto;
        decimal tamaño;
        string fecha;
        string comentario;

        public Foto(int idf, decimal tamaño, string fecha, string comentario)
        {
            this.idfoto = idf;
            this.tamaño = tamaño;
            this.fecha = fecha;
            this.comentario = comentario;
        }

        public int IdFOTO { get => idfoto; set => idfoto = value; }
        public decimal Tamaño { get => tamaño; set => tamaño = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Comentario { get => comentario; set => comentario = value; }

        public override string ToString()
        {
            return "Id: " + idfoto +"\n"+ "Tamaño: " + tamaño +"\n"+ "Fecha: " + fecha +"\n"+ "Comentario: " + comentario;
        }
    }
}
