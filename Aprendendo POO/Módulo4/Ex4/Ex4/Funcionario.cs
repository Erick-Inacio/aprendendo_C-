using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double aux = SalarioBruto - Imposto;
            return aux;
        }

        public void AumentarSalario(double porcentagem)
        {   
            SalarioBruto += (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return ($"{Nome}, R$ {SalarioLiquido().ToString("F2")}");
        }
    }
    
}
