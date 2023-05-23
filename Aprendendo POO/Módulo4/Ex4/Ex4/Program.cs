using System;
using System.Globalization;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            double porc;

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(f1);

            Console.Write("\nDigite uma porcentagem para aumentar o salário: ");
            porc = double.Parse(Console.ReadLine());

            f1.AumentarSalario(porc);

            Console.WriteLine("Dados Atualizados: " + f1);


        }
    }
}