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
    public partial class Form16cs : Form
    {
        public List<Fornecedor> forncs { get; private set; } = new List<Fornecedor>();
        private bool ascendingOrder = true; // Controla a ordem da ordenação
        public Form16cs()
        {
            InitializeComponent();
            lv_fornecedor.ColumnClick += lv_fornecedor_ColumnClick; // Adiciona o evento de clique na coluna
            obterFornecedor();
        }
        private void obterFornecedor(string pesquisa = null)
        {

            var repository = new FornecedorRepository();
            forncs = repository.Get(pesquisa);
            AtualizarListView(forncs);
        }

        private void AtualizarListView(List<Fornecedor> forncs)
        {
            lv_fornecedor.Items.Clear();
            foreach (var item in forncs)
            {
                lv_fornecedor.Items.Add(new ListViewItem(new string[]
                {
                    item.codigo.ToString(),
                    item.nome,
                    item.ramo
                }));
            }
        }
        private void lv_fornecedor_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    forncs = forncs.OrderBy(item => item.nome).ToList();
                else
                    forncs = forncs.OrderByDescending(item => item.nome).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView(forncs);
            }
        }
        private void Form16cs_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisa_forn_Click(object sender, EventArgs e)
        {
            string textoPesquisa = txt_nome_forn.Text.Trim();
            obterFornecedor(textoPesquisa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome_forn.Text;
                var cnpj = txt_cnpj.Text;
                var ramo = txt_ramo.Text;

               

                var forn = new Fornecedor(nome, cnpj, ramo);
                forncs.Add(forn);

                var repository_fornecedor= new FornecedorRepository();
                repository_fornecedor.Add(forn);

                lv_fornecedor.Items.Add(new ListViewItem(new String[] { nome, cnpj, ramo }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txt_nome_forn.Text = "";
            txt_cnpj.Text = "";
            txt_ramo.Text = "";

            MessageBox.Show("Fornecedor cadastrado");
        }
    }
}
