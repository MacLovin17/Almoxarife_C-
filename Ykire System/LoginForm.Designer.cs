namespace Ykire_System
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel3 = new Panel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            label6 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 61, 81);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 82);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(185, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 90);
            panel3.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 23);
            txtUsername.TabIndex = 29;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 23);
            txtPassword.TabIndex = 30;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(71, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 3;
            label1.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 61, 81);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(61, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 34);
            btnLogin.TabIndex = 31;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(61, 15);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 2;
            label6.Text = "Usuário";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(164, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 190);
            panel2.TabIndex = 32;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(566, 362);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Dit Corp";
            Load += LoginForm_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Button btnLogin;
        private Label label6;
        private Panel panel2;
    }
}