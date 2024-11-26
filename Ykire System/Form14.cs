using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ykire_System.Infra;

namespace Ykire_System
{
    public partial class Form14 : Form
    {
        public List<Combustivel> gasolina { get; private set; } = new List<Combustivel>();
        public Form14()
        {
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
                    item.combust_km.ToString("N2")
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

                // Criando a instância do repositório para obter os dados
                var repository_combustivel = new CombustivelRepository();
                gasolina = repository_combustivel.GetResumo(dataInicio, dataFim); // Passando as datas para obter os dados

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
    }
}
