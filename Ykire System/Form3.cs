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
    public partial class Form3 : Form
    {
        public List<Estoque> estoques { get; private set; } = new List<Estoque>();
        public Form3()
        {
            InitializeComponent();
            obterProdutos_est();
            date_est.Format = DateTimePickerFormat.Custom;
            date_est.CustomFormat = "dd/MM/yyyy";

        }

        private void obterProdutos_est()
        {
            var repository = new EstoqueRepository();
            estoques = repository.Get();
            lv_est.Items.Clear();
            foreach (var item in estoques)
            {
                // Incluindo o campo 'nome' na exibição
                lv_est.Items.Add(new ListViewItem(new String[] {
            item.codigo.ToString(),
            item.nome,  // Exibindo o nome
            item.qt.ToString(),
            item.obs
        }));
            }
        }

        private void btn_salva_est_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = txt_cod_est.Text; // Converte para int
                var qt = txt_qt_est.Text; // Converte para int
                var obs = txt_data_est.Text;

                var estoque = new Estoque(codigo, qt, obs);
                estoques.Add(estoque);

                var repository_est = new EstoqueRepository();
                repository_est.Add(estoque);
                lv_est.Items.Add(new ListViewItem(new string[] { codigo.ToString(), qt.ToString(), obs }));
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);

            }
            txt_cod_est.Text = "";
            txt_qt_est.Text = "";
            txt_data_est.Text = date_est.Text;


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_cod_est.Text = "";
            txt_qt_est.Text = "";
            txt_data_est.Text = date_est.Text;
        }

        private void date_est_ValueChanged(object sender, EventArgs e)
        {
            txt_data_est.Text = date_est.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_data_est_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
