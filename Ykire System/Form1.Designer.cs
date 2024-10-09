namespace Ykire_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader produto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            button1 = new Button();
            btn_estoq = new Button();
            btn_ger = new Button();
            btn_cad = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            txt_pesquisa = new TextBox();
            btn_pesquisa = new Button();
            button2 = new Button();
            label6 = new Label();
            lv_est_tot = new ListView();
            codigo = new ColumnHeader();
            total_entradas = new ColumnHeader();
            total_saidas = new ColumnHeader();
            estoque_atual = new ColumnHeader();
            produto = new ColumnHeader();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // produto
            // 
            produto.Text = "Descrição";
            produto.Width = 300;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_estoq);
            panel2.Controls.Add(btn_ger);
            panel2.Controls.Add(btn_cad);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(123, 483);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 44, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(186, 200, 208);
            button1.Location = new Point(9, 109);
            button1.Name = "button1";
            button1.Size = new Size(104, 34);
            button1.TabIndex = 5;
            button1.Text = "Baixa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_estoq
            // 
            btn_estoq.BackColor = Color.FromArgb(31, 44, 50);
            btn_estoq.FlatStyle = FlatStyle.Flat;
            btn_estoq.ForeColor = Color.FromArgb(186, 200, 208);
            btn_estoq.Location = new Point(9, 69);
            btn_estoq.Name = "btn_estoq";
            btn_estoq.Size = new Size(104, 34);
            btn_estoq.TabIndex = 4;
            btn_estoq.Text = "Entrada";
            btn_estoq.UseVisualStyleBackColor = false;
            btn_estoq.Click += btn_estoq_Click;
            // 
            // btn_ger
            // 
            btn_ger.BackColor = Color.FromArgb(31, 44, 50);
            btn_ger.FlatStyle = FlatStyle.Flat;
            btn_ger.ForeColor = Color.FromArgb(186, 200, 208);
            btn_ger.Location = new Point(9, 149);
            btn_ger.Name = "btn_ger";
            btn_ger.Size = new Size(104, 34);
            btn_ger.TabIndex = 3;
            btn_ger.Text = "Gerencial";
            btn_ger.UseVisualStyleBackColor = false;
            // 
            // btn_cad
            // 
            btn_cad.BackColor = Color.FromArgb(31, 44, 50);
            btn_cad.FlatStyle = FlatStyle.Flat;
            btn_cad.ForeColor = Color.FromArgb(186, 200, 208);
            btn_cad.Location = new Point(9, 29);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(104, 34);
            btn_cad.TabIndex = 2;
            btn_cad.Text = "Cadastro";
            btn_cad.UseVisualStyleBackColor = false;
            btn_cad.Click += btn_cad_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(-30, -10);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 90);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 61, 81);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1367, 82);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txt_pesquisa);
            panel4.Controls.Add(btn_pesquisa);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lv_est_tot);
            panel4.Location = new Point(261, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(1002, 872);
            panel4.TabIndex = 26;
            // 
            // txt_pesquisa
            // 
            txt_pesquisa.Location = new Point(539, 21);
            txt_pesquisa.Name = "txt_pesquisa";
            txt_pesquisa.Size = new Size(196, 23);
            txt_pesquisa.TabIndex = 28;
            // 
            // btn_pesquisa
            // 
            btn_pesquisa.BackColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa.FlatStyle = FlatStyle.Flat;
            btn_pesquisa.ForeColor = Color.FromArgb(31, 44, 50);
            btn_pesquisa.Location = new Point(758, 10);
            btn_pesquisa.Name = "btn_pesquisa";
            btn_pesquisa.Size = new Size(104, 34);
            btn_pesquisa.TabIndex = 27;
            btn_pesquisa.Text = "Pesquisar";
            btn_pesquisa.UseVisualStyleBackColor = false;
            btn_pesquisa.Click += btn_pesquisa_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(233, 240, 245);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(31, 44, 50);
            button2.Location = new Point(868, 10);
            button2.Name = "button2";
            button2.Size = new Size(104, 34);
            button2.TabIndex = 3;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(45, 2);
            label6.Name = "label6";
            label6.Size = new Size(157, 32);
            label6.TabIndex = 1;
            label6.Text = "Estoque Total";
            // 
            // lv_est_tot
            // 
            lv_est_tot.Columns.AddRange(new ColumnHeader[] { codigo, produto, total_entradas, total_saidas, estoque_atual });
            lv_est_tot.Location = new Point(45, 50);
            lv_est_tot.Name = "lv_est_tot";
            lv_est_tot.Size = new Size(928, 803);
            lv_est_tot.TabIndex = 0;
            lv_est_tot.UseCompatibleStateImageBehavior = false;
            lv_est_tot.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // total_entradas
            // 
            total_entradas.Text = "Entradas";
            total_entradas.TextAlign = HorizontalAlignment.Center;
            total_entradas.Width = 100;
            // 
            // total_saidas
            // 
            total_saidas.Text = "Saídas";
            total_saidas.TextAlign = HorizontalAlignment.Center;
            total_saidas.Width = 80;
            // 
            // estoque_atual
            // 
            estoque_atual.Text = "Estoque";
            estoque_atual.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1367, 565);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Dit Corp";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btn_estoq;
        private Button btn_ger;
        private Button btn_cad;
        private Panel panel3;
        private Panel panel1;
        private Button button1;
        private Panel panel4;
        private Label label6;
        private ListView lv_est_tot;
        private ColumnHeader codigo;
        private ColumnHeader total_entradas;
        private ColumnHeader total_saidas;
        private ColumnHeader estoque_atual;
        private Button button2;
        private TextBox txt_pesquisa;
        private Button btn_pesquisa;
    }
}
