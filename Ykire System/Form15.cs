using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ykire_System
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btn_pesquisa_epi_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void cad_veiculo_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void data_manut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void data_manut_ValueChanged_1(object sender, EventArgs e)
        {
            txt_data_manut.Text = data_manut.Text;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            txt_data_manut.Text = data_manut.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16cs form16 = new Form16cs();
            form16.Show();
        }
    }
}
