using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ykire_System
{
    public partial class Form10 : Form
    {
        public List<Frota> frota { get; private set; } = new List<Frota>();
        private bool ascendingOrder = true;
        public List<CEPI> epis { get; private set; } = new List<CEPI>();
        private EPIRepository _epiRepository;
        public List<Cars> cars { get; private set; } = new List<Cars>();
        private CarsRepository _carsRepository;
        public Form10()
        {
            InitializeComponent();
            txt_data_frota.Text = data_frota.Text;
            _carsRepository = new CarsRepository();
            _epiRepository = new EPIRepository();
            obterFrota();
            lv_gasolina.ColumnClick += lv_gasolina_ColumnClick;
            data_frota.Format = DateTimePickerFormat.Custom;
            data_frota.CustomFormat = "dd/MM/yyyy";
        }
        private void obterFrota()
        {
            lv_gasolina.Items.Clear();
            var repository = new FrotaRepository();
            frota = repository.Get();
            AtualizarListView_Frota(frota);
        }
        private void AtualizarListView_Frota(List<Frota> frota)
        {
            lv_gasolina.Items.Clear();

            foreach (var item in frota)
            {
                lv_gasolina.Items.Add(new ListViewItem(new string[] {
                    item.cod_veiculo.ToString(),
                    item.tag,
                    item.combustivel,
                    item.litragem.ToString(),
                    item.data,
                    item.cidade,
                }));
            }
        }
        private void lv_gasolina_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 4)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    frota = frota.OrderBy(item => item.data).ToList();
                else
                    frota = frota.OrderByDescending(item => item.data).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView_Frota(frota);
            }
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    frota = frota.OrderBy(item => item.tag).ToList();
                else
                    frota = frota.OrderByDescending(item => item.tag).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView_Frota(frota);
            }

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            txt_data_frota.Text = data_frota.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cad_veiculo_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void Txt_mat_frota_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_mat_frota.Text, out int matricula))
            {
                // Busca o nome do produto pelo código
                string nomeFuncionario = _epiRepository.ObterNomeProdutoPorCodigo_EPI(matricula);

                // Exibe o nome do produto no campo de texto
                txt_nome_epi.Text = nomeFuncionario ?? "Funcionário não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_frota.Enabled = nomeFuncionario != null;
            }
            else
            {
                txt_nome_epi.Text = string.Empty;
                btn_frota.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void Txt_cod_veiculo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_cod_veiculo.Text, out int codigo))
            {
                // Busca o nome do produto pelo código
                string codigoCars = _carsRepository.ObterNomeProdutoPorCodigo_Cars(codigo);

                // Exibe o nome do produto no campo de texto
                txt_veiculo_gas.Text = codigoCars ?? "Veículo não encontrado";

                // Habilita ou desabilita o botão baseado na existência do produto
                btn_frota.Enabled = codigoCars != null;
            }
            else
            {
                txt_nome_epi.Text = string.Empty;
                btn_frota.Enabled = false; // Desabilita o botão se o código não for válido
            }
        }

        private void btn_pesquisa_epi_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void btn_frota_Click(object sender, EventArgs e)
        {
            try
            {
                var matricula = Txt_mat_frota.Text;
                var nome = txt_nome_epi.Text;
                var cod_veiculo = Txt_cod_veiculo.Text;
                var tag = txt_veiculo_gas.Text;
                var combustivel = Cbox_combustivel.Text;
                var litragem = txt_Lt.Text;
                var custo = txt_custo.Text;
                var cidade = Cbox_cidade.Text;
                var km = txt_km.Text;
                var data = txt_data_frota.Text;


                var frotar = new Frota(matricula, nome, cod_veiculo, tag, combustivel, cidade, litragem, custo, km, data);
                frota.Add(frotar);
                var repository_frota = new FrotaRepository();
                repository_frota.Add(frotar);
                lv_gasolina.Items.Add(new ListViewItem(new string[] { matricula, nome, cod_veiculo, tag, combustivel, cidade, litragem, custo, km, data }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Txt_mat_frota.Text = "";
            txt_nome_epi.Text = "";
            Txt_cod_veiculo.Text = "";
            txt_veiculo_gas.Text = "";
            Cbox_combustivel.Text = "";
            txt_Lt.Text = "";
            txt_custo.Text = "";
            Cbox_cidade.Text = "";
            txt_km.Text = "";
            txt_data_frota.Text = data_frota.Text;

            MessageBox.Show("Registro cadastrado");
        }

        private void data_frota_ValueChanged(object sender, EventArgs e)
        {
            txt_data_frota.Text = data_frota.Text;
        }

        private void btn_rel_frota_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }
    }
}
