using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class epi : Form
    {
        private PrintDocument printDocument = new PrintDocument();


        public List<CEPI> epis { get; private set; } = new List<CEPI>();
        private EPIRepository _epiRepository;

        public epi()
        {
            InitializeComponent();

            _epiRepository = new EPIRepository();
            obterEpis_func();
            data_epi.Format = DateTimePickerFormat.Custom;
            data_epi.CustomFormat = "dd/MM/yyyy";
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.DefaultPageSettings.Landscape = true;

        }

        private void obterEpis_func(string pesquisa_epi = null)
        {
            var repository = new EPIRepository();
            epis = _epiRepository.Get(pesquisa_epi);
            AtualizarListView_EPI(epis);
        }

        private void AtualizarListView_EPI(List<CEPI> epis)
        {
            lv_epi_func.Items.Clear();

            foreach (var item in epis)
            {
                lv_epi_func.Items.Add(new ListViewItem(new String[] {
                item.matricula.ToString(),
                item.nome,
                item.epi,
                item.ca,
                item.qt.ToString(),
                item.data
                }));
            }
        }

        private void epi_Load(object sender, EventArgs e)
        {

            txt_data_epi.Text = data_epi.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cad_epi_Click(object sender, EventArgs e)
        {

        }

        private void data_epi_ValueChanged(object sender, EventArgs e)
        {
            txt_data_epi.Text = data_epi.Text;
        }

        private void btn_epi_save_Click(object sender, EventArgs e)
        {
            try
            {
                var matricula = Txt_mat_epi.Text;
                var codigo = Txt_epi_epi.Text;
                var epi = txt_epi_cod.Text;
                var ca = txt_CA.Text;
                var qt = txt_qt_epi.Text;
                var data = txt_data_epi.Text;

                var cepi = new CEPI(matricula, codigo, epi, ca, qt, data);
                epis.Add(cepi);

                var repository_epi = new EPIRepository();
                repository_epi.Add(cepi);

                lv_epi_func.Items.Add(new ListViewItem(new String[] { matricula, epi, ca, qt, data }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Txt_epi_epi.Text = "";
            Txt_mat_epi.Text = "";
            txt_CA.Text = "";
            Txt_epi_epi.Text = "";
            txt_qt_epi.Text = "";


            MessageBox.Show("EPI cadastrado");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_mat_epi_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(Txt_mat_epi.Text, out int matricula))
            {
                // Busca o nome do produto pelo código
                string nomeFuncionario = _epiRepository.ObterNomeProdutoPorCodigo_EPI(matricula);

                // Exibe o nome do produto no campo de texto
                txt_nome_epi.Text = nomeFuncionario ?? "Funcionário não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_epi_save.Enabled = nomeFuncionario != null;
            }
            else
            {
                txt_nome_epi.Text = string.Empty;
                btn_epi_save.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisa_epi_Click(object sender, EventArgs e)
        {
            string textoPesquisa_1 = txt_nome_epi.Text.Trim();
            obterEpis_func(textoPesquisa_1);
        }

        private void Txt_epi_epi_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_epi_epi.Text, out int codigo))
            {
                // Busca o nome do produto pelo código
                string nomeEPI = _epiRepository.ObterNomeEPIPorCodigo_EPI(codigo);

                // Exibe o nome do produto no campo de texto
                txt_epi_cod.Text = nomeEPI ?? "Funcionário não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_epi_save.Enabled = nomeEPI != null;
            }
            else
            {
                txt_nome_epi.Text = string.Empty;
                btn_epi_save.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void lv_func_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_epi_func_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int itemIndex = 0; // Controla o índice do item atual entre páginas

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fonte para o título e variáveis de formatação
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font font = new Font("Arial", 10);
            int yPosition = e.MarginBounds.Top;
            int xPosition = e.MarginBounds.Left;
            int rowHeight = 20;

            e.Graphics.DrawString("Relação EPI x Funcionário", titleFont, Brushes.Black, xPosition, yPosition);
            yPosition += 40; // Ajusta a posição vertical para o próximo conteúdo, abaixo do título

            // Cabeçalho da ListView (imprime uma vez por página)
            xPosition = e.MarginBounds.Left; // Reinicializa xPosition para cada nova linha
            for (int i = 0; i < lv_epi_func.Columns.Count; i++)
            {
                e.Graphics.DrawString(lv_epi_func.Columns[i].Text, font, Brushes.Black, xPosition, yPosition);

                // Ajusta xPosition com base na largura de cada coluna
                if (i == 0) // Código
                    xPosition += 80; // 80 pixels para a coluna Código
                else if (i == 1) // Descrição
                    xPosition += 250; // 500 pixels para a coluna Descrição
                else if (i == 2) // Descrição
                    xPosition += 250; // 500 pixels para a coluna Descrição
                else
                    xPosition += 100; // Ajuste padrão para outras colunas
            }

            yPosition += rowHeight; // Move para a próxima linha

            // Controla o espaçamento vertical, garantindo que cabe na página
            while (itemIndex < lv_epi_func.Items.Count)
            {
                xPosition = e.MarginBounds.Left; // Reinicializa xPosition para cada nova linha
                ListViewItem item = lv_epi_func.Items[itemIndex];

                // Imprime o conteúdo da ListView por coluna
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    e.Graphics.DrawString(item.SubItems[i].Text, font, Brushes.Black, xPosition, yPosition);

                    // Ajusta xPosition com base na largura de cada coluna
                    if (i == 0) // Código
                        xPosition += 80; // 80 pixels para a coluna Código
                    else if (i == 1) // Descrição
                        xPosition += 250; // 500 pixels para a coluna Descrição
                    else if (i == 2) // Descrição
                        xPosition += 250; // 500 pixels para a coluna Descrição
                    else
                        xPosition += 100; // Ajuste padrão para outras colunas
                }

                yPosition += rowHeight; // Move para a próxima linha

                // Verifica se a página está cheia
                if (yPosition + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // Informa que há mais páginas
                    itemIndex++; // Incrementa o índice do item
                    return; // Sai do método para imprimir a próxima página
                }

                itemIndex++; // Avança para o próximo item
            }

            yPosition += 40; // Ajusta a posição vertical para o próximo conteúdo, abaixo do título
            // Se todos os itens foram impressos, reseta o índice e encerra
            e.HasMorePages = false;
            itemIndex = 0; // Reseta o índice para permitir nova impressão corretamente
            yPosition = 770;
            xPosition = e.MarginBounds.Left;
            e.Graphics.DrawString("\nAssinatura : ____________________________________________________________", titleFont, Brushes.Black, xPosition, yPosition);

        }

        private void btn_print_epi_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;  // Conecta o documento ao preview
            preview.ShowDialog();
        }

        private void cad_funcionario_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
