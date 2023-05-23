using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];
        public double NotaF = 0;

        public void NotaFinal()
        {
            for (int i = 0; i < 3; i++)
            {
                NotaF += Notas[i];
            }
        }

        public void Situacao()
        {
            if(NotaF < 60)
            {
                Console.WriteLine($"Reprovado\nFaltaram {60 - NotaF} Pontos");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
