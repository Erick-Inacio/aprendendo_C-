using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBanco
{
    internal class ContaBanco
    {
        private string _numConta;
        private string _titular;
        private double _saldo;

        public string NumConta
        {
            get { return _numConta; }
        }

        public string Titular
        {
            get { return _titular; }

            set
            {
                if (value.Length >= 3 && value != null)
                {
                    _titular = value;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
           
        }

        public void Deposito(string deposito)
        {
            if(double.TryParse(deposito, out double valor) && valor > 0)
            {
                if(_saldo > 0)
                {
                    _saldo += valor;
                }
                else
                {
                    _saldo = valor;
                }
                
            }
        }

        public void Saque(string valor)
        {
            if (double.TryParse(valor, out double saque) && saque > 0)
            {
                _saldo -= saque + 5;
            }
                
        }

        public void NumeroConta()
        {
            if(string.IsNullOrEmpty(NumConta) == true)
            {
                do
                {
                    Console.Write("\nEntre com o número da conta: ");
                    string aux = Console.ReadLine();

                    if (aux.Length == 4 && aux != null)
                    {
                        _numConta = aux.ToString();
                        break;
                    }
                    else
                    {
                        Console.Write("Número de conta inválido, por favor,tente novamente!\n");
                    }
                } while (true);
            }
            else
            {
                Console.Write("O número da conta não pode ser alterado!");
            }
        }
            
        public override string ToString()
        {
            return ($"Conta {_numConta}, Titular: {Titular}, Saldo R${Saldo.ToString("N2")}\n");
        }
    }
}
