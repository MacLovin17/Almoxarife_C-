using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form15 : Form
    {
        public List<Manutencao> manutencao { get; private set; } = new List<Manutencao>();
        public List<Frota> frota { get; private set; } = new List<Frota>();
        private bool ascendingOrder = true;

        public List<CEPI> epis { get; private set; } = new List<CEPI>();
        private EPIRepository _epiRepository;

        public List<Cars> cars { get; private set; } = new List<Cars>();
        private CarsRepository _carsRepository;
        public List<Fornecedor> forncs { get; private set; } = new List<Fornecedor>();
        private FornecedorRepository _fornecedorRepository;

        public Form15()
        {
            InitializeComponent();
            _carsRepository = new CarsRepository();
            _epiRepository = new EPIRepository();
            _fornecedorRepository = new FornecedorRepository();
            obterManutencao();
            data_manut.Format = DateTimePickerFormat.Custom;
            data_manut.CustomFormat = "dd/MM/yyyy";
        }

        private void obterManutencao()
        {
            lv_manutencao.Items.Clear();
            var repository = new ManutRepository();
            manutencao = repository.Get();
            AtualizarListView_Manutencao(manutencao);
        }

        private void AtualizarListView_Manutencao(List<Manutencao> manutencao)
        {
            lv_manutencao.Items.Clear();

            foreach (var item in manutencao)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    item.tag,
                    item.fornecedor,
                    item.cidade,
                    item.tipo,
                    item.servico,
                    item.valor.ToString("F2"),  // Formata como moeda
                    item.data
                });

                lv_manutencao.Items.Add(listViewItem);
            }
        }

        private void btn_pesquisa_epi_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void cad_veiculo_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void data_manut_ValueChanged(object sender, EventArgs e)
        {
        }

        private void data_manut_ValueChanged_1(object sender, EventArgs e)
        {
            txt_data_manut.Text = data_manut.Text;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            txt_data_manut.Text = data_manut.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16cs form16 = new Form16cs();
            form16.Show();
        }

        private void Txt_mat_manut_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_mat_manut.Text, out int matricula))
            {
                // Busca o nome do produto pelo código
                string nomeFuncionario = _epiRepository.ObterNomeProdutoPorCodigo_EPI(matricula);

                // Exibe o nome do produto no campo de texto
                txt_nome_manut.Text = nomeFuncionario ?? "Funcionário não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_manut_save.Enabled = nomeFuncionario != null;
            }
            else
            {
                txt_nome_manut.Text = string.Empty;
                btn_manut_save.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void Txt_cod_veiculo_manut_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_cod_veiculo_manut.Text, out int codigo))
            {
                // Busca o nome do produto pelo código
                string codigoCars = _carsRepository.ObterNomeProdutoPorCodigo_Cars(codigo);

                // Exibe o nome do produto no campo de texto
                txt_veiculo_manut.Text = codigoCars ?? "Veículo não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_manut_save.Enabled = codigoCars != null;
            }
            else
            {
                txt_veiculo_manut.Text = string.Empty;
                btn_manut_save.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void txt_cod_forn_manut_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_cod_forn_manut.Text, out int codigo))
            {
                // Busca o nome do produto pelo código
                string codigofornc = _fornecedorRepository.ObterNomeProdutoPorCodigo_Fornc(codigo);

                // Exibe o nome do produto no campo de texto
                txt_forn_manut.Text = codigofornc ?? "Fornecedor não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_manut_save.Enabled = codigofornc != null;
            }
            else
            {
                txt_forn_manut.Text = string.Empty;
                btn_manut_save.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }



        private void btn_manut_save_Click(object sender, EventArgs e)
        {
            try
            {

                // Obtendo os dados do formulário
                var cod_matricula = Txt_mat_manut.Text;
                var cod_veiculo = Txt_cod_veiculo_manut.Text;
                var tag = txt_veiculo_manut.Text;
                var cod_fornecedor = txt_cod_forn_manut.Text;
                var fornecedor = txt_forn_manut.Text;
                var cidade = Cbox_cidade_manut.Text;
                var tipo = Cbox_tipo_manut.Text;
                var servico = cbox_servico.Text;
                var valor = txt_custo_manut.Text;
                var data = txt_data_manut.Text;
                

                // Cria o objeto Manutencao
                var manut = new Manutencao(cod_matricula, cod_veiculo, tag, cod_fornecedor, fornecedor, cidade, tipo, servico, valor, data);

                // Adiciona a manutenção no repositório
                var repository_manut = new ManutRepository();
                repository_manut.Add(manut);

                // Atualiza a lista
                lv_manutencao.Items.Add(new ListViewItem(new string[] { cod_matricula, cod_veiculo, tag, cod_fornecedor, fornecedor, cidade, tipo, servico, valor, data }));

                MessageBox.Show("Manutenção registrada");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Limpa os campos
            Txt_mat_manut.Text = "";
            Txt_cod_veiculo_manut.Text = "";
            txt_cod_forn_manut.Text = "";
            txt_custo_manut.Text = "";
            txt_data_manut.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_forn_manut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}