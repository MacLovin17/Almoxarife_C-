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
            label6 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 61, 81);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 82);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(185, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 90);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(240, 105);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 2;
            label6.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(250, 166);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 3;
            label1.Text = "Senha";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(185, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 23);
            txtUsername.TabIndex = 29;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(185, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 23);
            txtPassword.TabIndex = 30;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 61, 81);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(240, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 34);
            btnLogin.TabIndex = 31;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(568, 309);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Dit Corp";
            
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label6;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}