using System;
using System.Windows.Forms;

namespace Ykire_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Exibir o LoginForm como uma caixa de diálogo modal
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK) // Exibir LoginForm e esperar até que seja fechado
                {
                    Application.Run(new Form1()); // Iniciar Form1 após o LoginForm
                }
                else
                {
                    Application.Exit(); // Se o login falhar, fecha a aplicação
                }
            }
        }
    }
}
