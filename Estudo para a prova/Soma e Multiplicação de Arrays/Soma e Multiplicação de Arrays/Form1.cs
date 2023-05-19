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

namespace Soma_e_Multiplicação_de_Arrays
{
    public partial class Form1 : Form
    {

        double[] array1 = new double[10];
        double[] array2 = new double[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
           string aux = "", aux2 = "";

            txtArray1.Clear();
            txtArray2.Clear();

            for (int i = 0; i < 10; i++)
            {
                double.TryParse(Interaction.InputBox("Digite 10 valores", "Entrada de Dados"), out array1[i]);

                if (array1[i] % 2 == 0)
                {
                    array2[i] = array1[i] * 5;
                }
                else
                {
                    array2[i] = array1[i] + 5;
                }

                aux = string.Concat(aux, ' ', array1[i]);
                aux2 = string.Concat(aux2, ' ', array2[i]);
            }

            txtArray1.Text = aux;
            txtArray2.Text = aux2; 

        }
    }
}
