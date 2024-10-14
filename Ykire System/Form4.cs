using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using Ykire_System.Infra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Ykire_System
{
    
    public partial class Form4 : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        public List<Baixa> baixas { get; private set; } = new List<Baixa>();
        private BaixaRepository _baixaRepository;
        private bool ascendingOrder = true; // Controla a ordem da ordenação
        public Form4()
        {
            InitializeComponent();

            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.DefaultPageSettings.Landscape = true;

            _baixaRepository = new BaixaRepository();
            btn_salva_est_said.Enabled = false; // Inicialmente desabilitado
            obterProdutos_est_said();
            date_est_said.Format = DateTimePickerFormat.Custom;
            date_est_said.CustomFormat = "dd/MM/yyyy";
            data_final.Format = DateTimePickerFormat.Custom;
            data_final.CustomFormat = "dd/MM/yyyy";
            data_inicio.Format = DateTimePickerFormat.Custom;
            data_inicio.CustomFormat = "dd/MM/yyyy";
        }

        private void obterProdutos_est_said()
        {
            baixas = _baixaRepository.Get();

            lv_est_said.Items.Clear();
            foreach (var item in baixas)
            {
                lv_est_said.Items.Add(new ListViewItem(new String[]
                {
                    item.codigo.ToString(),
                    item.nome,
                    item.qt.ToString(),
                    item.cgo.ToString(),
                    item.data
                }));
            }
        }
        private void AtualizarListViewPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            // Obtém as baixas do repositório, filtrando e ordenando pela data
            baixas = _baixaRepository.Get()
                .Where(item => DateTime.TryParse(item.data, out DateTime dataBaixa)
                    && dataBaixa >= dataInicio
                    && dataBaixa <= dataFim)
                .OrderBy(item => DateTime.Parse(item.data)) // Ordena pela data
                .ToList();

            // Limpa os itens da ListView
            lv_est_said.Items.Clear();

            // Adiciona os itens filtrados e ordenados à ListView
            foreach (var item in baixas)
            {
                lv_est_said.Items.Add(new ListViewItem(new String[]
                {
            item.codigo.ToString(),
            item.nome,
            item.qt.ToString(),
            item.cgo.ToString(),
            item.data
                }));
            }
        }


        private void btn_salva_est_said_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = txt_cod_est_said.Text;
                var qt = txt_qt_est_said.Text;
                var data = txt_data_est_said.Text;
                var cgo = Cbox_said.Text;

                if (cgo == "892") // use "892" como string, se Cbox_said é string
                {
                    qt = (int.Parse(qt) * -1).ToString(); // Certifique-se que o tipo seja consistente
                }
                var baixa = new Baixa(codigo, qt, cgo, data);
                baixas.Add(baixa);

                var repository_est_said = new BaixaRepository();
                repository_est_said.Add(baixa);
                lv_est_said.Items.Add(new ListViewItem(new string[] { codigo, qt, cgo, data }));

                MessageBox.Show("Baixa cadastrada");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            txt_cod_est_said.Text = "";
            txt_qt_est_said.Text = "";
            txt_data_est_said.Text = date_est_said.Text;
            txt_data_inicio.Text = data_inicio.Text;
            txt_data_final.Text = data_final.Text;
        }

        private void date_est_said_ValueChanged(object sender, EventArgs e)
        {
            txt_data_est_said.Text = date_est_said.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txt_cod_est_said.Text = "";
            txt_qt_est_said.Text = "";
            txt_data_est_said.Text = date_est_said.Text;
            Cbox_said.Items.Add("777"); // Baixa Peça
            Cbox_said.Items.Add("778"); // Baixa Ferramenta/uso
            Cbox_said.Items.Add("779"); // Baixa Produto de Limpeza
            Cbox_said.Items.Add("780"); // Baixa Consumo
            Cbox_said.Items.Add("781"); // Baixa Elétrica
            Cbox_said.Items.Add("782"); // Baixa Mecânica
            Cbox_said.Items.Add("888"); // EPI
            Cbox_said.Items.Add("892"); // Invent Entrada
            Cbox_said.Items.Add("893"); // Invent Baixa
        }

        private void txt_cod_est_said_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_cod_est_said.Text, out int codigo))
            {
                // Busca o nome do produto pelo código
                string nomeProduto = _baixaRepository.ObterNomeProdutoPorCodigo(codigo);

                // Exibe o nome do produto no campo de texto
                txt_cod_prod.Text = nomeProduto ?? "Produto não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_salva_est_said.Enabled = nomeProduto != null;
            }
            else
            {
                txt_cod_prod.Text = string.Empty;
                btn_salva_est_said.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void Cbox_said_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (Cbox_said.Text)
            {
                case "777":
                    txt_cgo_desc.Text = "Baixa Peça";
                    break;
                case "778":
                    txt_cgo_desc.Text = "Baixa Ferramenta/uso";
                    break;
                case "779":
                    txt_cgo_desc.Text = "Baixa Produto de Limpeza";
                    break;
                case "780":
                    txt_cgo_desc.Text = "Baixa Consumo";
                    break;
                case "781":
                    txt_cgo_desc.Text = "Baixa Elétrica";
                    break;
                case "782":
                    txt_cgo_desc.Text = "Baixa Mecânica";
                    break;
                case "888":
                    txt_cgo_desc.Text = "EPI";
                    break;
                case "892":
                    txt_cgo_desc.Text = "Invent Entrada";
                    break;
                case "893":
                    txt_cgo_desc.Text = "Invent Baixa";
                    break;
                default:
                    txt_cgo_desc.Text = string.Empty;
                    break;
            }
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            Cbox_said.Items.Add("777"); // Baixa Peça
            Cbox_said.Items.Add("778"); // Baixa Ferramenta/uso
            Cbox_said.Items.Add("779"); // Baixa Produto de Limpeza
            Cbox_said.Items.Add("780"); // Baixa Consumo
            Cbox_said.Items.Add("781"); // Baixa Elétrica
            Cbox_said.Items.Add("782"); // Baixa Mecânica
            Cbox_said.Items.Add("888"); // EPI
            Cbox_said.Items.Add("892"); // Invent Entrada
            Cbox_said.Items.Add("893"); // Invent Baixa
            txt_cod_est_said.Text = "";
            txt_qt_est_said.Text = "";
            txt_data_est_said.Text = date_est_said.Text;
            txt_data_inicio.Text = data_inicio.Text;
            txt_data_final.Text = data_final.Text;
            obterProdutos_est_said();
        }

        private void FiltrarPorData()
        {
            if (DateTime.TryParse(txt_data_inicio.Text, out DateTime dataInicio) &&
                DateTime.TryParse(txt_data_final.Text, out DateTime dataFim))
            {
                AtualizarListViewPorPeriodo(dataInicio, dataFim);
            }
        }

        private void txt_cgo_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cod_est_said_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(txt_cod_est_said.Text, out int codigo))
            {
                // Busca o nome do produto pelo código
                string nomeProduto = _baixaRepository.ObterNomeProdutoPorCodigo(codigo);

                // Exibe o nome do produto no campo de texto
                txt_cod_prod.Text = nomeProduto ?? "Produto não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_salva_est_said.Enabled = nomeProduto != null;
            }
            else
            {
                txt_cod_prod.Text = string.Empty;
                btn_salva_est_said.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void txt_qt_est_said_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cod_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_est_said_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lv_est_said_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    baixas = baixas.OrderBy(item => item.nome).ToList();
                else
                    baixas = baixas.OrderByDescending(item => item.nome).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                obterProdutos_est_said(); // Atualiza a ListView com a lista ordenada
            }
        }

        private void date_est_said_ValueChanged_1(object sender, EventArgs e)
        {
            txt_data_est_said.Text = date_est_said.Text;
        }

        private void txt_data_est_said_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_inicio_ValueChanged(object sender, EventArgs e)
        {
            txt_data_inicio.Text = data_inicio.Text;
        }

        private void data_final_ValueChanged(object sender, EventArgs e)
        {
            txt_data_final.Text = data_final.Text;
        }

        private void data_inicio_ValueChanged_1(object sender, EventArgs e)
        {
            txt_data_inicio.Text = data_inicio.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FiltrarPorData();
        }

        private void txt_data_inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_final_ValueChanged_1(object sender, EventArgs e)
        {
            txt_data_final.Text = data_final.Text;
        }

        private void data_inicio_ValueChanged_2(object sender, EventArgs e)
        {
            txt_data_inicio.Text = data_inicio.Text;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;  // Conecta o documento ao preview
            preview.ShowDialog();
        }
        private int itemIndex = 0; // Controla o índice do item atual entre páginas

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fonte e variáveis de formatação
            Font font = new Font("Arial", 10);
            int yPosition = e.MarginBounds.Top;
            int xPosition = e.MarginBounds.Left;
            int rowHeight = 20;

            // Cabeçalho da ListView (imprime uma vez por página)
            xPosition = e.MarginBounds.Left; // Reinicializa xPosition para cada nova linha
            for (int i = 0; i < lv_est_said.Columns.Count; i++)
            {
                e.Graphics.DrawString(lv_est_said.Columns[i].Text, font, Brushes.Black, xPosition, yPosition);

                // Ajusta xPosition com base na largura de cada coluna
                if (i == 0) // Código
                    xPosition += 80; // 80 pixels para a coluna Código
                else if (i == 1) // Descrição
                    xPosition += 500; // 300 pixels para a coluna Descrição
                else
                    xPosition += 100; // Ajuste padrão para outras colunas
            }

            yPosition += rowHeight; // Move para a próxima linha

            // Controla o espaçamento vertical, garantindo que cabe na página
            while (itemIndex < lv_est_said.Items.Count)
            {
                xPosition = e.MarginBounds.Left; // Reinicializa xPosition para cada nova linha
                ListViewItem item = lv_est_said.Items[itemIndex];

                // Imprime o conteúdo da ListView por coluna
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    e.Graphics.DrawString(item.SubItems[i].Text, font, Brushes.Black, xPosition, yPosition);

                    // Ajusta xPosition com base na largura de cada coluna
                    if (i == 0) // Código
                        xPosition += 80; // 80 pixels para a coluna Código
                    else if (i == 1) // Descrição
                        xPosition += 500; // 300 pixels para a coluna Descrição
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

            // Se todos os itens foram impressos, reseta o índice e encerra
            e.HasMorePages = false;
            itemIndex = 0; // Reseta o índice para permitir nova impressão corretamente
        }


    }
}   