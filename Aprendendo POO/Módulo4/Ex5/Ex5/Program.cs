using System;
using System.Globalization;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota {1 + i}: ");
                aluno.Notas[i] = double.Parse(Console.ReadLine());
            }

            aluno.NotaFinal();
            aluno.Situacao();
        }
    }
}