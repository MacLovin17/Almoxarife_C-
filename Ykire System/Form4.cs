using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form4 : Form
    {
        public List<Baixa> baixas { get; private set; } = new List<Baixa>();
        public Form4()
        {
            InitializeComponent();
            obterProdutos_est_said();
            date_est_said.Format = DateTimePickerFormat.Custom;
            date_est_said.CustomFormat = "dd/MM/yyyy";
        }
        private void obterProdutos_est_said()
        {
            var repository = new BaixaRepository();
            baixas = repository.Get();
            lv_est_said.Items.Clear();
            foreach (var item in baixas)
            {
                // Incluindo o campo 'nome' na exibição
                lv_est_said.Items.Add(new ListViewItem(new String[] {
                item.codigo.ToString(),
                item.qt.ToString(),  // Exibindo o nome
                item.cgo.ToString(),
                item.data
        }));
            }
        }
        private void btn_salva_est_said_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = txt_cod_est_said.Text; // Converte para int
                var qt = txt_qt_est_said.Text; // Converte para int
                var data = txt_data_est_said.Text;
                var cgo = Cbox_said.Text;

                var baixa = new Baixa(codigo, qt, cgo, data);
                baixas.Add(baixa);

                var repository_est_said = new BaixaRepository();
                repository_est_said.Add(baixa);
                lv_est_said.Items.Add(new ListViewItem(new string[] { codigo.ToString(), qt.ToString(), cgo.ToString(), data }));
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);

            }
            txt_cod_est_said.Text = "";
            txt_qt_est_said.Text = "";
            txt_data_est_said.Text = date_est_said.Text;


        }

        

        private void date_est_said_ValueChanged(object sender, EventArgs e)
        {
            txt_data_est_said.Text = date_est_said.Text;
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            txt_cod_est_said.Text = "";
            txt_qt_est_said.Text = "";
            txt_data_est_said.Text = date_est_said.Text;
            Cbox_said.Items.Add("777");
            Cbox_said.Items.Add("778");
            Cbox_said.Items.Add("779");
            Cbox_said.Items.Add("780");
            Cbox_said.Items.Add("781");
            Cbox_said.Items.Add("782");
            Cbox_said.Items.Add("888");
            Cbox_said.Items.Add("555");
            Cbox_said.Items.Add("892");
            Cbox_said.Items.Add("893");
        }

        private void txt_data_est_said_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
