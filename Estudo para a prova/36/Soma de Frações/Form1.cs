using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_de_Frações
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            int n;

            txtResposta.Clear();

            if(int.TryParse(txtNum.Text, out n))
            {
                
                if( n > 0 && n < 50)
                {
                    
                    for (int i = 0; i < n; i++)
                    {
                        //MessageBox.Show("OK");
                        double num = i;
                        resultado += ((num + 1) / (num + 2));
                    }

                    txtResposta.Text = resultado.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Apenas números entre 0 e 50");
                }
            }    
            else
            {
                MessageBox.Show("Digite apenas números");
            }
            
        }
    }
}
