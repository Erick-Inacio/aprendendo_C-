using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnQtdeNum_Click(object sender, EventArgs e)
        {
            int resposta = 0;
            for (int i = 0; i < rchtxtTexto.Text.Length; i++) 
            {
                if (char.IsNumber(rchtxtTexto.Text, i))
                {
                    resposta++;
                }
            }

            txtResposta.Text = resposta.ToString();
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            int i = 0, resposta = 0;
            
            if(!(rchtxtTexto.Text == string.Empty))
            {
                while (resposta == 0)
                {
                    if(char.IsWhiteSpace(rchtxtTexto.Text, i))
                    {
                        resposta = i;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                txtResposta.Text = (resposta + 1).ToString();
            }
            
        }

        private void btnQtdeLetras_Click(object sender, EventArgs e)
        {
            int resposta = 0;
            foreach (char c in rchtxtTexto.Text)
            {
                if(char.IsLetter(c))
                {
                    resposta++;
                }
            }

            txtResposta.Text = resposta.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchtxtTexto.Clear();
            txtResposta.Clear();
        }
    }
}
