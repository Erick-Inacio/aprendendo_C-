using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class ConversorDeMoeda
    {
        public static double CovertValor(double cotac, double qtdeDol)
        {
            return (cotac * qtdeDol) * 1.06; ;
            
        }
    }
}
