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
