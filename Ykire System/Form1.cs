using Ykire_System.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ykire_System
{
    public partial class Form1 : Form
    {
        public List<Total> totais { get; private set; } = new List<Total>();
        private bool ascending = true; // Variável para controlar a ordem de ordenação

        public Form1()
        {
            InitializeComponent();
            obterProdutos_tot();
           
        }

        private void obterProdutos_tot()
        {
            var repository = new TotalRepository();
            totais = repository.Get();
            lv_est_tot.Items.Clear();
            foreach (var item in totais)
            {
                // Incluindo o campo 'nome' na exibição
                lv_est_tot.Items.Add(new ListViewItem(new String[] {
                    item.codigo.ToString(),
                    item.produto,  // Exibindo o nome
                    item.total_entradas.ToString(),
                    item.total_saidas.ToString(),
                    item.total_estoque.ToString()
                }));
            }
        }


        private void btn_cad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
