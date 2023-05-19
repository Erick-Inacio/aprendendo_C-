using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pLacos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string aux = txtEntrada.Text, aux2;

            if(aux.Length <= 50)
            {
                fNormalizaString(ref aux);
                aux2 = fRevertString(aux);

                if(string.Compare(aux, aux2) == 0)
                {
                    txtResposta.Text = "É palíndromo";
                }
                else
                {
                    txtResposta.Text = "Não é palíndromo";
                }
            }
            else
            {
                MessageBox.Show("Digite até 50 caracteres incluíndo espaçoes em branco");
            }
        }

        private string fRevertString(string aux)
        {
            int len = aux.Length;
            char[] aux2 = new char[50];

            for(int i = 0; i < len; i++)
            {
                aux2[len - 1 - i] = (aux[i]);
            } 

            return new string(aux2);
        }
        
        private void fNormalizaString(ref string aux)
        {
            string aux2 = "", c;

            for (int i = 0; i < aux.Length; i++)
            {
                if (!char.IsWhiteSpace(aux[i]))
                {
                    c = string.Copy(char.ToLower(aux[i]).ToString());

                    c = fRemoveAcento(c);

                    aux2 = string.Concat(aux2, c);
                }
            }
            aux = string.Copy(aux2);
        }
        
        private string fRemoveAcento(string c)
        {
            string ch = c.ToString().Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            foreach (char item in ch)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(item) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(item);
                }
            }
            return sb[0].ToString();
        }
    }
}
 