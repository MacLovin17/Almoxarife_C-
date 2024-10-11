using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form1 : Form
    {
        public List<Total> totais { get; private set; } = new List<Total>();
        private bool ascendingOrder = true; // Controla a ordem da ordenação

        public Form1()
        {
            InitializeComponent();
            obterProdutos_tot();
            lv_est_tot.ColumnClick += Lv_est_tot_ColumnClick; // Adiciona o evento de clique na coluna
        }

        private void obterProdutos_tot(string pesquisa = null)
        {
            var repository = new TotalRepository();
            totais = repository.Get(pesquisa);
            AtualizarListView(totais);
        }

        private void AtualizarListView(List<Total> produtos)
        {
            lv_est_tot.Items.Clear();
            foreach (var item in produtos)
            {
                lv_est_tot.Items.Add(new ListViewItem(new string[]
                {
                    item.codigo.ToString(),
                    item.produto,
                    item.total_estoque.ToString()
                }));
            }
        }

        private void Lv_est_tot_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    totais = totais.OrderBy(item => item.produto).ToList();
                else
                    totais = totais.OrderByDescending(item => item.produto).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView(totais); // Atualiza a ListView com a lista ordenada
            }
        }



        private void btn_cad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_estoq_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obterProdutos_tot();
        }

        private void btn_pesquisa_Click_1(object sender, EventArgs e)
        {
            string textoPesquisa = txt_pesquisa.Text.Trim();
            obterProdutos_tot(textoPesquisa);
        }

        private void lv_est_tot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btn_ger_Click(object sender, EventArgs e)
        {
           
        }
    }
}
