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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtHoje = monthCalendar1.SelectionStart;
            MessageBox.Show(dtHoje.ToString("dd/MM/yy"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dtHoje = dateTimePicker1.Value;
            MessageBox.Show(dtHoje.ToString("d"));
        }
    }
}
