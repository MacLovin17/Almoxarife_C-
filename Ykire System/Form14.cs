using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;


namespace Ykire_System
{
    public partial class Form14 : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        public List<Combustivel> gasolina { get; private set; } = new List<Combustivel>();
        public Form14()
        {
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.DefaultPageSettings.Landscape = true;
            InitializeComponent();
            obterCombustivel();
            data_final.Format = DateTimePickerFormat.Custom;
            data_final.CustomFormat = "dd/MM/yyyy";
            data_inicio.Format = DateTimePickerFormat.Custom;
            data_inicio.CustomFormat = "dd/MM/yyyy";
        }
        private void obterCombustivel()
        {
            lv_rel_comb.Items.Clear();
            var repository = new CombustivelRepository();
            gasolina = repository.Get(); // Obter todos os combustíveis
            AtualizarListView_Combustivel(gasolina);
        }
        private void AtualizarListView_Combustivel(List<Combustivel> gasolina)
        {
            lv_rel_comb.Items.Clear();

            foreach (var item in gasolina)
            {
                lv_rel_comb.Items.Add(new ListViewItem(new string[] {
                    item.cod_veiculo.ToString(),
                    item.tag,
                    item.combustivel,
                    item.litragem_total.ToString("N2"),
                    item.custo_total.ToString("N2"),
                    item.km_total.ToString("N2"),
                    item.combust_km.ToString("N2"),
                    item.km_por_dia.ToString("N2")
                }));
            }
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            txt_data_inicio_frota.Text = data_inicio.Text;
            txt_data_final_frota.Text = data_final.Text;

        }

        private void btn_pesquisa_gasolina_Click(object sender, EventArgs e)
        {
            try
            {
                // Pegando as datas de início e fim inseridas pelo usuário
                DateTime dataInicio = DateTime.Parse(txt_data_inicio_frota.Text);
                DateTime dataFim = DateTime.Parse(txt_data_final_frota.Text);

                // Verificando se o campo do código do veículo está vazio
                int? codVeiculo = null;
                if (!string.IsNullOrWhiteSpace(txt_cod_veic.Text)) // Se o campo não estiver vazio
                {
                    // Tenta converter para inteiro
                    if (int.TryParse(txt_cod_veic.Text, out int parsedCodVeiculo))
                    {
                        codVeiculo = parsedCodVeiculo;
                    }
                    else
                    {
                        // Exibe mensagem de erro se o valor não for numérico
                        MessageBox.Show("O código do veículo deve ser um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Criando a instância do repositório para obter os dados
                var repository_combustivel = new CombustivelRepository();

                // Busca os dados com ou sem o filtro do código do veículo
                gasolina = repository_combustivel.GetResumo(dataInicio, dataFim, codVeiculo);

                // Atualizando a ListView com os dados obtidos
                AtualizarListView_Combustivel(gasolina);
            }
            catch (Exception ex)
            {
                // Tratar erros (como formato de data inválido)
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }



        }

        private void lv_rel_comb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_inicio_ValueChanged(object sender, EventArgs e)
        {
            txt_data_inicio_frota.Text = data_inicio.Text;
        }

        private void data_final_ValueChanged(object sender, EventArgs e)
        {
            txt_data_final_frota.Text = data_final.Text;

        }

        private void btn_print_frota_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;  // Conecta o documento ao preview
            preview.ShowDialog();
        }
        private int itemIndex = 0; // Controla o índice do item atual entre páginas

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fontes e configurações iniciais
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font subtitleFont = new Font("Arial", 10);
            Font contentFont = new Font("Arial", 8);
            int yPosition = e.MarginBounds.Top;
            int xPosition = e.MarginBounds.Left;
            int rowHeight = 20;

            // Obtém as datas das TextBox
            string dataInicial = txt_data_inicio_frota.Text;
            string dataFinal = txt_data_final_frota.Text;

            // Cabeçalho do relatório
            e.Graphics.DrawString("Controle de Abastecimento", titleFont, Brushes.Black, xPosition, yPosition);
            yPosition += 30; // Move abaixo do título
            e.Graphics.DrawString($"Período: {dataInicial} à {dataFinal}", subtitleFont, Brushes.Black, xPosition, yPosition);
            yPosition += 30; // Move para a próxima linha

            // Cabeçalho das colunas
            xPosition = e.MarginBounds.Left; // Reinicializa a posição horizontal
            for (int i = 0; i < lv_rel_comb.Columns.Count; i++)
            {
                e.Graphics.DrawString(lv_rel_comb.Columns[i].Text, contentFont, Brushes.Black, xPosition, yPosition);

                // Ajuste horizontal baseado na largura de cada coluna
                if (i == 0) // Código
                    xPosition += 120;
                else if (i == 1) // Descrição
                    xPosition += 150;
                else
                    xPosition += 130;
            }

            yPosition += rowHeight; // Avança para a próxima linha

            // Impressão dos dados da ListView
            while (itemIndex < lv_rel_comb.Items.Count)
            {
                xPosition = e.MarginBounds.Left; // Reinicia a posição horizontal para cada linha
                ListViewItem item = lv_rel_comb.Items[itemIndex];

                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    e.Graphics.DrawString(item.SubItems[i].Text, contentFont, Brushes.Black, xPosition, yPosition);

                    // Ajuste horizontal baseado na largura de cada coluna
                    if (i == 0)
                        xPosition += 120;
                    else if (i == 1)
                        xPosition += 150;
                    else
                        xPosition += 130;
                }

                yPosition += rowHeight; // Avança para a próxima linha

                // Verifica se a página está cheia
                if (yPosition + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // Indica que há mais páginas a serem impressas
                    itemIndex++; // Incrementa o índice do item atual
                    return; // Sai para processar a próxima página
                }

                itemIndex++; // Avança para o próximo item
            }

            // Adiciona o rodapé com a data de emissão
            yPosition += 40; // Ajusta para o rodapé
            e.Graphics.DrawString($"Relatório emitido em: {DateTime.Now:dd/MM/yyyy}", subtitleFont, Brushes.Black, e.MarginBounds.Left, yPosition);

            // Finaliza o relatório
            e.HasMorePages = false; // Indica que não há mais páginas
            itemIndex = 0; // Reseta o índice para permitir nova impressão corretamente
        }

    }
}
