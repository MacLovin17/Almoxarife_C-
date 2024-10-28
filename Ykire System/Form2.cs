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
        private bool ascendingOrder = true; // Controla a ordem da ordenação
        public Form2()
        {
            InitializeComponent();
            obterProdutos();
            lv_cad.ColumnClick += lv_cad_ColumnClick; // Adiciona o evento de clique na coluna
        }
        private void lv_cad_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    produtos = produtos.OrderBy(item => item.nome).ToList();
                else
                    produtos = produtos.OrderByDescending(item => item.nome).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView(produtos); // Atualiza a ListView com a lista ordenada
            }
            if (e.Column == 5)
            {

                if (ascendingOrder)
                    produtos = produtos.OrderBy(item => item.endereco).ToList();
                else
                    produtos = produtos.OrderByDescending(item => item.endereco).ToList();

                ascendingOrder = !ascendingOrder;
                AtualizarListView(produtos);
            }
        }
        private void obterProdutos()
        {
            var repository = new ProdutoRepository();
            produtos = repository.Get();
            AtualizarListView(produtos);
        }

        private void AtualizarListView(List<Produto> produtos)
        {
            lv_cad.Items.Clear();
            foreach (var item in produtos)
            {
                lv_cad.Items.Add(new ListViewItem(new String[] {
                    item.codigo.ToString(),
                    item.nome,
                    item.fornecedor,
                    item.cnpj,
                    item.obs,
                    item.endereco
                }));
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
                var endereco = txt_prateleira.Text;

                foreach (var item in produtos)
                {
                    if (item.nome == nome)
                        MessageBox.Show(nome + "já está cadastrado no sistema.");
                }

                var produto = new Produto(nome, fornecedor, cnpj, obs, endereco);
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
            txt_prateleira.Text = "";

            MessageBox.Show("Produto cadastrado");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txt_prateleira_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_cad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}