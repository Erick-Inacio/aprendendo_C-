using System;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo val = new Retangulo();

            Console.Write("Entre com a largura: ");
            val.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com a altura: ");
            val.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = val.Area();

            Console.Write("\nArea: " + area.ToString("F2", CultureInfo.InvariantCulture));

            double perimetro = val.Perimetro();

            Console.Write("\nPerimetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = val.Diagonal();

            Console.Write("\nDiagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}