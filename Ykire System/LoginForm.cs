using System;
using System.Windows.Forms;

namespace Ykire_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load); // Inscreva-se para o evento Load aqui
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Inicializações quando o formulário carregar
            txtUsername.Focus(); // Foca no campo de username ao carregar
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "adm")
            {
                username = "ADM";
            }
            if (username == "eriky")
            {
                username = "ERIKY";
            }
            // Validação simples para o exemplo
            if ((username == "ADM" && password == "1234") || (username == "ERIKY" && password == "37566"))
            {
                // Se o login for bem-sucedido, definir o resultado e fechar o formulário
                this.DialogResult = DialogResult.OK; // Define o resultado do diálogo
                this.Close(); // Fecha o LoginForm
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
