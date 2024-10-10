using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form4 : Form
    {
        public List<Baixa> baixas { get; private set; } = new List<Baixa>();
        private BaixaRepository _baixaRepository;

        public Form4()
        {
            InitializeComponent();
            _baixaRepository = new BaixaRepository();
            btn_salva_est_said.Enabled = false; // Inicialmente desabilitado
            obterProdutos_est_said();
            date_est_said.Format = DateTimePickerFormat.Custom;
            date_est_said.CustomFormat = "dd/MM/yyyy";
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
            txt_cod_est_said.Text = "";
            txt_qt_est_said.Text = "";
            txt_data_est_said.Text = date_est_said.Text;
        }
    }


}   