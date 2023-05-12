using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesComponentesN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            listBox1.Items.Add("1º Semestre");
            listBox1.Items.Add("2º Semestre");
            listBox1.Items.Add("3º Semestre");
            listBox1.Items.Add("4º Semestre");
            listBox1.Items.Add("5º Semestre");
            listBox1.Items.Add("6º Semestre");
            listBox1.Items.Add("7º Semestre");
            listBox1.Items.Add("8º Semestre");

            listBox1.SelectedIndex = 0; // deixa primeiro pre-selecionado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="") // if (textBox1.text==String.Empty)
                MessageBox.Show("nome vazio","texto da barra de titulo",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);

            //if (checkBox1.Checked)
            //    MessageBox.Show("Turno Manhã");
            //else
            //    MessageBox.Show("Turno Noite");

            if (checkBox1.CheckState==CheckState.Checked)
                MessageBox.Show("Turno Manhã");
            else if (checkBox1.CheckState==CheckState.Indeterminate)
                MessageBox.Show("Turno indefinido");
            else
                MessageBox.Show("Turno Noite");

            if (comboBox1.SelectedIndex==-1)
                MessageBox.Show("Selecionar o curso!");
            else
                MessageBox.Show("Curso: " + comboBox1.SelectedItem);

            DateTime dtTeste;
            
            if (DateTime.TryParse(maskedTextBox1.Text,out dtTeste))
                MessageBox.Show("Data:"+dtTeste.ToString("dd/MM/yyyy"));
            else
                MessageBox.Show("Data inválida");

            if (radioButton1.Checked)
                MessageBox.Show("veio transferido");
            else
                MessageBox.Show("não veio transferido");

            //for (var x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            //    MessageBox.Show(checkedListBox1.CheckedItems[x].ToString());

            string stringona="";
            for (var x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                stringona = stringona + "\n" + checkedListBox1.CheckedItems[x].ToString();

            MessageBox.Show(stringona);


        }
    }
}
