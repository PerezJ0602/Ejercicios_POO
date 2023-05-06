using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica10
{
    public class Directivo:Empleado
    {
        private string categoria;

        public Directivo()
        {
            
        }

        public Directivo(string categoria)
        {
            this.Categoria = categoria;
        }

        public string Categoria { get => categoria; set => categoria = value; }
    }
}
