using System;
namespace ClasePractica6
{

    class Program
    {
        static void Main(string[] args)
        {
            Ubicacion ubicacion1 = new Ubicacion(0,0);
            
            Ubicacion ubicacion2 = new Ubicacion(5, 5);

            Figura figura1 = new Rectangulo(3, 4, ubicacion1);
            Figura figura2 = new Circulo(2, ubicacion2);

            Console.WriteLine(figura1.ToString() + ", Área: " + figura1.CalcularArea() + ", Perímetro: " + figura1.Perimetro());
            Console.WriteLine(figura2.ToString() + ", Área: " + figura2.CalcularArea() + ", Perímetro: " + figura2.Perimetro());
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
