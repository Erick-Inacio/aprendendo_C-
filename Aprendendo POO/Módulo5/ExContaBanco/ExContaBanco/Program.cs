using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace ExContaBanco
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaBanco correntista = new ContaBanco();
            
            correntista.NumeroConta();

            Console.Write("Entre com o titular da conta: ");
            correntista.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            string depInic = Console.ReadLine();

            if(depInic.ToLower() == "s")
            {
                Console.Write("\nEntre um valor para depósito: ");
                correntista.Deposito(Console.ReadLine());
            }

            Console.WriteLine("\nDados da Conta: \n" + correntista); //OBJ 
            Console.Write("Entre com um valor para depósito: ");
            correntista.Deposito(Console.ReadLine());

            Console.WriteLine("\nDados da Conta atualizado: \n" + correntista);

            Console.Write("Entre com um valor para saque: ");
            correntista.Saque(Console.ReadLine());
            Console.WriteLine("\nDados da Conta atualizado: \n" + correntista);
        }
    }
}