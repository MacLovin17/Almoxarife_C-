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
    public partial class Form10 : Form
    {
        public List<CEPI> epis { get; private set; } = new List<CEPI>();
        private EPIRepository _epiRepository;
        public Form10()
        {
            InitializeComponent();
            _epiRepository = new EPIRepository();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

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
    }
}
