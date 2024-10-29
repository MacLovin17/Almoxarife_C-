using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        public List<Total> totais { get; private set; } = new List<Total>();
        private bool ascendingOrder = true; // Controla a ordem da ordena��o

        public Form1()
        {
            InitializeComponent();

            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.DefaultPageSettings.Landscape = true;

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
                    item.total_estoque.ToString(),
                    item.obs


                }));
            }
        }

        private void Lv_est_tot_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usu�rio clicou na segunda coluna (�ndice 1)
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    totais = totais.OrderBy(item => item.produto).ToList();
                else
                    totais = totais.OrderByDescending(item => item.produto).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o pr�ximo clique
                AtualizarListView(totais);
            }
            if (e.Column == 2)
            {
                // Classifica `total_estoque` como inteiro explicitamente para garantir a ordena��o correta
                if (ascendingOrder)
                    totais = totais.OrderBy(item => Convert.ToInt32(item.total_estoque)).ToList();
                else
                    totais = totais.OrderByDescending(item => Convert.ToInt32(item.total_estoque)).ToList();

                ascendingOrder = !ascendingOrder;
                AtualizarListView(totais);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lv_est_tot.Items.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private int itemIndex = 0; // Controla o �ndice do item atual entre p�ginas

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fonte para o t�tulo e vari�veis de formata��o
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font font = new Font("Arial", 10);
            int yPosition = e.MarginBounds.Top;
            int xPosition = e.MarginBounds.Left;
            int rowHeight = 20;

            // T�tulo "Movimenta��o de Estoque"
            e.Graphics.DrawString("Relat�rio de Estoque", titleFont, Brushes.Black, xPosition, yPosition);
            yPosition += 40; // Ajusta a posi��o vertical para o pr�ximo conte�do, abaixo do t�tulo

            // Cabe�alho da ListView (imprime uma vez por p�gina)
            xPosition = e.MarginBounds.Left; // Reinicializa xPosition para cada nova linha
            for (int i = 0; i < lv_est_tot.Columns.Count; i++)
            {
                e.Graphics.DrawString(lv_est_tot.Columns[i].Text, font, Brushes.Black, xPosition, yPosition);

                // Ajusta xPosition com base na largura de cada coluna
                if (i == 0) // C�digo
                    xPosition += 80; // 80 pixels para a coluna C�digo
                else if (i == 1) // Descri��o
                    xPosition += 500; // 500 pixels para a coluna Descri��o
                else
                    xPosition += 100; // Ajuste padr�o para outras colunas
            }

            yPosition += rowHeight; // Move para a pr�xima linha

            // Controla o espa�amento vertical, garantindo que cabe na p�gina
            while (itemIndex < lv_est_tot.Items.Count)
            {
                xPosition = e.MarginBounds.Left; // Reinicializa xPosition para cada nova linha
                ListViewItem item = lv_est_tot.Items[itemIndex];

                // Imprime o conte�do da ListView por coluna
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    e.Graphics.DrawString(item.SubItems[i].Text, font, Brushes.Black, xPosition, yPosition);

                    // Ajusta xPosition com base na largura de cada coluna
                    if (i == 0) // C�digo
                        xPosition += 80; // 80 pixels para a coluna C�digo
                    else if (i == 1) // Descri��o
                        xPosition += 500; // 500 pixels para a coluna Descri��o
                    else
                        xPosition += 100; // Ajuste padr�o para outras colunas
                }

                yPosition += rowHeight; // Move para a pr�xima linha

                // Verifica se a p�gina est� cheia
                if (yPosition + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // Informa que h� mais p�ginas
                    itemIndex++; // Incrementa o �ndice do item
                    return; // Sai do m�todo para imprimir a pr�xima p�gina
                }

                itemIndex++; // Avan�a para o pr�ximo item
            }

            // Se todos os itens foram impressos, reseta o �ndice e encerra
            e.HasMorePages = false;
            itemIndex = 0; // Reseta o �ndice para permitir nova impress�o corretamente
        }

        private void btn_print_est_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;  // Conecta o documento ao preview
            preview.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_epi_Click(object sender, EventArgs e)
        {
            epi epi = new epi();
            epi.Show();
        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
