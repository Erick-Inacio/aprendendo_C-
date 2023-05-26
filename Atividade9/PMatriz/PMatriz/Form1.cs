using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace PMatriz
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";

            for (var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número: ", "Entrada de Dados");

                if (!int.TryParse(auxiliar, out Vetor[i]))
                {
                    MessageBox.Show("Número Inválido");
                    i--;
                }
            }

            Array.Reverse(Vetor);
            foreach (var i in Vetor)
            {
                auxiliar += "\n" + i.ToString();
            }

            MessageBox.Show(auxiliar);
        }

        private void btnArmazen_Click(object sender, EventArgs e)
        {
            double[] qtde = new double[10];
            double[] preco = new double[10];
            string aux = "";
            double faturamento = 0;

            for(var i = 0;i < 10;i++)
            {
                aux = Interaction.InputBox("Digite a quantidade: " + (i + 1),
                    "Entrada de Dados");

                if(!double.TryParse(aux, out qtde[i]))
                {
                    MessageBox.Show("Quantidade Inválida!");
                    i--;
                }
                else
                {
                    while (preco[i] <= 0)
                    {
                        aux = Interaction.InputBox("Digite o preço: " + (i + 1).ToString(),
                            "Entrada de Dados");

                        if (!double.TryParse(aux, out preco[i]))
                        {
                            MessageBox.Show("Preço Inválido");
                        }
                        else
                        {
                            faturamento += qtde[i] * preco[i];
                        }
                    }
                }
            }
            MessageBox.Show("Faturamento: " + faturamento.ToString("N2"));
        }

        private void btnListaAluno_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Ana");
            arrayList.Add("André");
            arrayList.Add("Débora");
            arrayList.Add("Fátima");
            arrayList.Add("João");
            arrayList.Add("Janete");
            arrayList.Add("Otávio");
            arrayList.Add("Marcelo");
            arrayList.Add("Pedro");
            arrayList.Add("Thais");

            for(int i = arrayList.Count - 1; i >= 0; i--)
            {
                if (string.Compare(arrayList[i].ToString(), "Otávio") == 0)
                {
                    MessageBox.Show("Nome a ser removido: " + arrayList[i].ToString());
                    arrayList.RemoveAt(i);
                    break;
                }
            }

            string mensagem = string.Join("\n", arrayList.ToArray());
            MessageBox.Show("Nomes:\n" + mensagem);
        }

        private void btnEx5e6_Click(object sender, EventArgs e)
        {
            var frmEx5e6 = Application.OpenForms.OfType<frmEx5e6>().FirstOrDefault();
            if(frmEx5e6 != null)
            {
                frmEx5e6.BringToFront();
            }
            else
            {
                frmEx5e6 = new frmEx5e6();
                frmEx5e6.Show();
            }

        }
    }
}
