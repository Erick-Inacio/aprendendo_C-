using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatriz
{
    public partial class frmEx5e6 : Form
    {
        public frmEx5e6()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] medias = new double[20];



            for (int i = 0; i < notas.GetLength(0); i++)
            {
                double media = 0;

                notas[i, 0] = i;

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = double.Parse(Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}: ",
                        $"Entrada Aluno {i + 1}"));

                    media += notas[i, j];
                }

                medias[i] = media/3;

            }

            for (int i = 0; i < medias.GetLength(0); i++)
            {
                lstbxSaida.Items.Add($"Aluno {i + 1}: média: {medias[i].ToString("N1")}");
            }
        }

        private void btnListaAluno_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[8];
            int[] tamanhos = new int[8];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite seu nome completo:", "ENTRADA");
                tamanhos[i] = nomes[i].Replace(" ", "").Length;
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                lstbxSaida.Items.Add($"O nome: {nomes[i]} tem {tamanhos[i]} caracteres");
            }

            
        }
    }
}
