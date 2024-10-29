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
    public partial class Form7 : Form
    {
        public List<Funcinario> funcionarios { get; private set; } = new List<Funcinario>();
        private bool ascendingOrder = true;
        public Form7()
        {
            InitializeComponent();
            obterEpis();
            lv_func.ColumnClick += lv_func_ColumnClick;
        }

        private void Func_Load(object sender, EventArgs e)
        {

        }
        private void obterEpis()
        {
            lv_func.Items.Clear();
            var repository = new FuncRepository();
            funcionarios = repository.Get();
            AtualizarListView_FUNC(funcionarios);
        }
        private void AtualizarListView_FUNC(List<Funcinario> funcionarios)
        {
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
        private void lv_func_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Verifica se o usuário clicou na segunda coluna (índice 1)
            if (e.Column == 1)
            {
                // Alterna entre crescente e decrescente
                if (ascendingOrder)
                    funcionarios = funcionarios.OrderBy(item => item.nome).ToList();
                else
                    funcionarios = funcionarios.OrderByDescending(item => item.nome).ToList();

                ascendingOrder = !ascendingOrder; // Alterna a ordem para o próximo clique
                AtualizarListView_FUNC(funcionarios);
            }

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

            MessageBox.Show("Funcionário cadastrado");
        }
    }
}
