using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];

            Console.WriteLine("Ingrese 2 estudiantes: ");
            personas[0] = new Estudiante(Console.ReadLine());
            personas[1] = new Estudiante(Console.ReadLine());

            Console.WriteLine("Ingrese el profesor: ");
            personas[2] = new Profesor(Console.ReadLine());

            foreach (Persona persona in personas)
            {
                if (persona is Estudiante)
                {
                    ((Estudiante)persona).Estudiar();
                }
                else if (persona is Profesor)
                {
                    ((Profesor)persona).Explicar();
                }
            }


            Console.ReadKey();
        }
    }
}
