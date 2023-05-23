using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace _38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnValoresDias_Click(object sender, EventArgs e)
        {
            double TotalGeral = 0;
            string aux = "";
            double[,] valores = new double[2, 2];
            double[] TotalPorDia = new double[2];

            ArrayList arrayList = new ArrayList();

            for (var i = 0; i < 2; i++)
            {
                for(var j = 0; j < 2; j++)
                {
                    aux = Interaction.InputBox("Digite o valor do item " + (j + 1).ToString() + ":",
                        "Digite os valores do dia " + (1 + i).ToString());
                    if (Double.TryParse(aux, out valores[i, j]))
                    {
                        TotalPorDia[i] += valores[i, j];
                    }
                    else
                    {
                        j--;
                    }
                }

                arrayList.Add(TotalPorDia[i].ToString());

                TotalGeral += TotalPorDia[i];
            }


            lsbxSaida.Items.AddRange(arrayList.ToArray());
            lsbxSaida.Items.Add("\n\n");
            lsbxSaida.Items.Add ("Total Geral: " + TotalGeral.ToString());
            
        }
    }
}
