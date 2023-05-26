using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    internal class Funcionario
    {
        private double _salarioLiquido;
        private double _inss;
        private double _irpf;
        private double _salFamilia;

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public int NumFilhos { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }

        public double SalarioLiquido
        {
            get { return _salarioLiquido; }
        }
        public double Inss
        {
            get { return _inss; }
        }
        public double Irpf
        {
            get { return _irpf; }
        }
        public double SalFamilia
        {
            get { return _salFamilia; }
        }

        public Funcionario(string Nome, double SalarioBruto, int NumFilhos,
            string Genero, string EstadoCivil)
        {
            this.Nome = Nome;
            this.SalarioBruto = SalarioBruto;
            this.NumFilhos = NumFilhos;
            this.Genero = Genero;
            this.EstadoCivil = EstadoCivil;
        }

        public string CalcInss()
        {
            if (SalarioBruto <= 800.47)
            {
                _inss = SalarioBruto * 0.0765;

                return "7.65%";
            }
            else if (SalarioBruto <= 1050)
            {
                _inss = SalarioBruto * 0.0865;

                return "8.65%";
            }
            else if(SalarioBruto <= 1400.77)
            {
                _inss = SalarioBruto * 0.09;

                return "9.00%";
            }
            else if(SalarioBruto <= 2801.56)
            {
                _inss = SalarioBruto * 0.11;

                return "11.00%";
            }
            else
            {
                _inss = 308.17;
                return "0";
            }
        }
        public string CalcIrpf()
        {
            if(SalarioBruto  <= 1257.12)
            {
                _irpf = 0;

                return "0%";
            }
            else if(SalarioBruto <= 2512.08)
            {
                _irpf = SalarioBruto * 0.15;

                return "15.00%";
            }
            else
            {
                _irpf = SalarioBruto * 0.275;

                return "27.5%";
            }
        }
        public double CalcFamilia()
        {
            if (SalarioBruto <= 435.52)
            {
                _salFamilia = 22.33 * NumFilhos;
            }
            else if(SalarioBruto <= 654.61)
            {
                _salFamilia = 15.74 * NumFilhos;
            }

            return SalFamilia;
        }
        public double CalSalLiquido()
        {
            _salarioLiquido = SalarioBruto - Inss - Irpf + SalFamilia;

            return SalarioLiquido;
        }

        public override string ToString()
        {
            if (Genero == "Masculino")
            {
                return ($"Os descontos do salário do Sr. {Nome} que é {EstadoCivil} e que tem {NumFilhos} filhos são:");
            }
            else
            {
                return ($"Os descontos do salário da Sra. {Nome} que é {EstadoCivil} e que tem {NumFilhos} filhos são:");
            }
        }
    }
}