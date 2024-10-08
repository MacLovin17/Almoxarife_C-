using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form2 : Form
    {
        public List<Produto> produtos { get; private set; } = new List<Produto>();
        public Form2()
        {
            InitializeComponent();
            obterProdutos();
        }

        private void obterProdutos()
        {
            var repository = new ProdutoRepository();
            produtos = repository.Get();
            lv_cad.Items.Clear();
            foreach (var item in produtos)
            {
                lv_cad.Items.Add(new ListViewItem(new String[] { item.codigo.ToString(), item.nome, item.fornecedor, item.cnpj, item.obs }));

            }
        }

        private void btn_salva_cad_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_prod.Text;
                var fornecedor = txt_fornec.Text;
                var cnpj = txt_cnpj.Text;
                var obs = txt_obs.Text;

                foreach (var item in produtos)
                {
                    if (item.nome == nome)
                        MessageBox.Show(nome + "já está cadastrado no sistema.");
                }

                var produto = new Produto( nome, fornecedor, cnpj, obs);
                produtos.Add(produto);

                var repository_cad = new ProdutoRepository();
                repository_cad.Add(produto);

                lv_cad.Items.Add(new ListViewItem(new String[] { nome, fornecedor, cnpj, obs }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txt_cnpj.Text = "";
            txt_fornec.Text = "";
            txt_obs.Text = "";
            txt_prod.Text = "";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}