using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFormatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DatTime dtHoje = Convert.ToDateTime("09/05/2023");
            DateTime dtHoje = DateTime.Now;
            lstxSaida.Items.Add(dtHoje.ToString());
            lstxSaida.Items.Add(dtHoje.ToString("t"));
            lstxSaida.Items.Add(dtHoje.ToString("dd/MM/yyyy")); //MM maiusculo para data e mm para minutos
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dtNiver = Convert.ToDateTime("20/05/1999 19:35:20");
            lstxSaida.Items.Add(dtNiver.ToShortDateString());
            lstxSaida.Items.Add(dtNiver.ToLongDateString());
            lstxSaida.Items.Add(dtNiver.ToShortTimeString());
            lstxSaida.Items.Add(dtNiver.ToLongTimeString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dtCasamento = Convert.ToDateTime("12/02/2022");

            lstxSaida.Items.Add(String.Format("a data do casmaneto é {0:d}" +
                "e a hora atual é {1:t}", dtCasamento, DateTime.Now));

            dtCasamento = dtCasamento.AddDays(365);
            lstxSaida.Items.Add(dtCasamento.ToString());

            dtCasamento = dtCasamento.AddYears(-35);
            lstxSaida.Items.Add(dtCasamento.ToString());

            lstxSaida.Items.Add("Hoje é: " +DateTime.Today.DayOfWeek);
            lstxSaida.Items.Add("Hoje é: " + DateTime.Today.ToString("dd"));
            lstxSaida.Items.Add("Dias do mês: " + DateTime.DaysInMonth(2024,2).ToString());
            lstxSaida.Items.Add(DateTime.Today.DayOfYear);
            if (DateTime.IsLeapYear(2023))
            {
                MessageBox.Show("É bissexto");
            }
            else
            {
                MessageBox.Show("n é bissexto");
            }

            DateTime dtVencimento = Convert.ToDateTime("24/12/2022");
            DateTime dtPagamento = DateTime.Today;

            Double diasAtraso = dtPagamento.Subtract(dtVencimento).TotalDays;

            MessageBox.Show("Dias de atraso: " + diasAtraso.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double vlrBoleto = 108.99;

            lstxSaida.Items.Clear();
            lstxSaida.Items.Add("Valor do boleto" + vlrBoleto.ToString("N2"));
            lstxSaida.Items.Add("Valor do boleto" + vlrBoleto.ToString("C2"));
            lstxSaida.Items.Add(String.Format("o valor do boleto é: {0:C2}", vlrBoleto));
        }
    }
}
