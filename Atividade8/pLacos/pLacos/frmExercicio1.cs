using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pLacos
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                {
                    count++;
                }
            }

            txtResposta.Text = count.ToString();
        }

        private void btnNumR_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0;
            string aux = rchtxtFrase.Text;

            do
            {
                char c = char.ToLower(aux[i++]);

                if (c == 'r')
                {
                    count++; ;
                }
            } while (i < rchtxtFrase.Text.Length);

            txtResposta.Text = count.ToString();
        }

        private void btnParChar_Click(object sender, EventArgs e)
        {
            string aux = rchtxtFrase.Text;
            int i = 0, count = 0, len = aux.Length;

            do
            {
                char c1 = aux[i], c2 = aux[i + 1];

                if(c1 == c2)
                {
                    count++;
                }
                i++;

            } while ((i+1) < len);

            txtResposta.Text = "tem " + count.ToString() + " pares de letras.";
        }
    }
}
