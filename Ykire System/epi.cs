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
    public partial class epi : Form
    {
        public List<Funcinario> funcionarios { get; private set; } = new List<Funcinario>();
        public List<CEPI> epis { get; private set; } = new List<CEPI>();
        private EPIRepository _epiRepository;
        public epi()
        {
            InitializeComponent();
            obterEpis();
            _epiRepository = new EPIRepository();
            obterEpis_func();
            data_epi.Format = DateTimePickerFormat.Custom;
            data_epi.CustomFormat = "dd/MM/yyyy";
        }
        private void obterEpis()
        {
            var repository = new FuncRepository();
            funcionarios = repository.Get();
            lv_func.Items.Clear();
            foreach (var item in funcionarios)
            {
                lv_func.Items.Add(new ListViewItem(new String[] {
                    item.matricula.ToString(),
                    item.nome,
                    item.funcao
                }));

            }
        }
        private void obterEpis_func()
        {
            var repository = new EPIRepository();
            epis = repository.Get();
            lv_epi_func.Items.Clear();
            foreach (var item in epis)
            {
                lv_epi_func.Items.Add(new ListViewItem(new String[] {
                    item.matricula.ToString(),
                    item.nome,
                    item.epi,
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
            try
            {
                var matricula = txt_matricula.Text;
                var nome = txt_nome_func.Text;
                var setor = txt_setor.Text;
                var funcao = txt_funcao_func.Text;

                foreach (var item in funcionarios)
                {
                    if (item.nome == nome)
                        MessageBox.Show(nome + "já está cadastrado no sistema.");
                }

                var funcionario = new Funcinario(matricula, nome, setor, funcao);
                funcionarios.Add(funcionario);

                var repository_fun = new FuncRepository();
                repository_fun.Add(funcionario);

                lv_func.Items.Add(new ListViewItem(new String[] { matricula, nome, funcao }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txt_matricula.Text = "";
            txt_nome_func.Text = "";
            txt_setor.Text = "";
            txt_funcao_func.Text = "";

            MessageBox.Show("Produto cadastrado");
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
                var epi = Txt_epi_epi.Text;
                var qt = txt_qt_epi.Text;
                var data = txt_data_epi.Text;

                var cepi = new CEPI(matricula, epi, qt, data);
                epis.Add(cepi);

                var repository_epi = new EPIRepository();
                repository_epi.Add(cepi);

                lv_epi_func.Items.Add(new ListViewItem(new String[] { matricula, epi, qt, data }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Txt_mat_epi.Text = "";
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
    }
}
