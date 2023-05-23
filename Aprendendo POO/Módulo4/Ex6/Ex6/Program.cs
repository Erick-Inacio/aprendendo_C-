using System;
using System.Globalization;
using System.Security.AccessControl;

namespace Ex6
{
    class Programa
    {
        static void Main(string[] args)
        {
            double cotac, qtdeDol;

            Console.Write("Qual a cotação do Dólar? ");
            cotac = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            qtdeDol = double.Parse(Console.ReadLine());

            Console.Write($"\nValor a ser pago em reais = " +
                $"{ConversorDeMoeda.CovertValor(cotac, qtdeDol).ToString()}");

        }
    }

}