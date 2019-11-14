using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboInf4
{
    public partial class FormFirst : Form
    {
        int licznik = 0;
        public FormFirst()
        {
            InitializeComponent();
        }

        private void buttonChangeLabel_Click(object sender, EventArgs e)
        {
            licznik++;
            labelNumberCounter.Text = "Liczba klik: " + licznik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSecond forma = new FormSecond();
            forma.Show();
        }
    }
}
