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
            panel8 = new Panel();
            panel7 = new Panel();
            btn_epi = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            btn_baixa = new Button();
            btn_estoq = new Button();
            btn_ger = new Button();
            btn_cad = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_print_est = new Button();
            txt_pesquisa = new TextBox();
            label6 = new Label();
            lv_est_tot = new ListView();
            codigo = new ColumnHeader();
            estoque_atual = new ColumnHeader();
            obs = new ColumnHeader();
            btn_pesquisa = new Button();
            button2 = new Button();
            produto = new ColumnHeader();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // produto
            // 
            produto.Text = "Descrição";
            produto.Width = 350;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(btn_epi);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_baixa);
            panel2.Controls.Add(btn_estoq);
            panel2.Controls.Add(btn_ger);
            panel2.Controls.Add(btn_cad);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(123, 961);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Enabled = false;
            panel8.Location = new Point(14, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(33, 25);
            panel8.TabIndex = 33;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Enabled = false;
            panel7.Location = new Point(14, 193);
            panel7.Name = "panel7";
            panel7.Size = new Size(33, 25);
            panel7.TabIndex = 31;
            // 
            // btn_epi
            // 
            btn_epi.BackColor = Color.FromArgb(31, 44, 50);
            btn_epi.FlatStyle = FlatStyle.Flat;
            btn_epi.ForeColor = Color.FromArgb(186, 200, 208);
            btn_epi.Location = new Point(12, 149);
            btn_epi.Name = "btn_epi";
            btn_epi.Size = new Size(96, 34);
            btn_epi.TabIndex = 32;
            btn_epi.Text = "EPI         ";
            btn_epi.TextAlign = ContentAlignment.MiddleRight;
            btn_epi.UseVisualStyleBackColor = false;
            btn_epi.Click += btn_epi_Click;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Enabled = false;
            panel6.Location = new Point(14, 113);
            panel6.Name = "panel6";
            panel6.Size = new Size(33, 25);
            panel6.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Enabled = false;
            panel5.Location = new Point(14, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(33, 25);
            panel5.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources._4514864_middle__1_3;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Enabled = false;
            panel4.Location = new Point(14, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(33, 25);
            panel4.TabIndex = 28;
            panel4.Paint += panel4_Paint;
            // 
            // btn_baixa
            // 
            btn_baixa.BackColor = Color.FromArgb(31, 44, 50);
            btn_baixa.FlatStyle = FlatStyle.Flat;
            btn_baixa.ForeColor = Color.FromArgb(186, 200, 208);
            btn_baixa.Location = new Point(12, 109);
            btn_baixa.Name = "btn_baixa";
            btn_baixa.Size = new Size(96, 34);
            btn_baixa.TabIndex = 5;
            btn_baixa.Text = "Baixa     ";
            btn_baixa.TextAlign = ContentAlignment.MiddleRight;
            btn_baixa.UseVisualStyleBackColor = false;
            btn_baixa.Click += button1_Click;
            // 
            // btn_estoq
            // 
            btn_estoq.BackColor = Color.FromArgb(31, 44, 50);
            btn_estoq.FlatStyle = FlatStyle.Flat;
            btn_estoq.ForeColor = Color.FromArgb(186, 200, 208);
            btn_estoq.ImageAlign = ContentAlignment.MiddleLeft;
            btn_estoq.Location = new Point(12, 69);
            btn_estoq.Name = "btn_estoq";
            btn_estoq.Size = new Size(96, 34);
            btn_estoq.TabIndex = 4;
            btn_estoq.Text = "Entrada  ";
            btn_estoq.TextAlign = ContentAlignment.MiddleRight;
            btn_estoq.UseVisualStyleBackColor = false;
            btn_estoq.Click += btn_estoq_Click;
            // 
            // btn_ger
            // 
            btn_ger.BackColor = Color.FromArgb(31, 44, 50);
            btn_ger.FlatStyle = FlatStyle.Flat;
            btn_ger.ForeColor = Color.FromArgb(186, 200, 208);
            btn_ger.Location = new Point(12, 189);
            btn_ger.Name = "btn_ger";
            btn_ger.Size = new Size(96, 34);
            btn_ger.TabIndex = 3;
            btn_ger.Text = "Frota      ";
            btn_ger.TextAlign = ContentAlignment.MiddleRight;
            btn_ger.UseVisualStyleBackColor = false;
            btn_ger.Click += btn_ger_Click;
            // 
            // btn_cad
            // 
            btn_cad.BackColor = Color.FromArgb(31, 44, 50);
            btn_cad.FlatStyle = FlatStyle.Flat;
            btn_cad.ForeColor = Color.FromArgb(186, 200, 208);
            btn_cad.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cad.Location = new Point(12, 29);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(96, 34);
            btn_cad.TabIndex = 2;
            btn_cad.Text = "Cadastro";
            btn_cad.TextAlign = ContentAlignment.MiddleRight;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_print_est);
            groupBox1.Controls.Add(txt_pesquisa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lv_est_tot);
            groupBox1.Controls.Add(btn_pesquisa);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(158, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 891);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estoque Total";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_print_est
            // 
            btn_print_est.BackColor = Color.FromArgb(233, 240, 245);
            btn_print_est.BackgroundImage = Properties.Resources.printer;
            btn_print_est.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print_est.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_print_est.FlatStyle = FlatStyle.Flat;
            btn_print_est.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print_est.Location = new Point(625, 32);
            btn_print_est.Name = "btn_print_est";
            btn_print_est.Size = new Size(39, 33);
            btn_print_est.TabIndex = 28;
            btn_print_est.UseVisualStyleBackColor = false;
            btn_print_est.Click += btn_print_est_Click;
            // 
            // txt_pesquisa
            // 
            txt_pesquisa.Font = new Font("Segoe UI", 9F);
            txt_pesquisa.Location = new Point(91, 42);
            txt_pesquisa.Name = "txt_pesquisa";
            txt_pesquisa.Size = new Size(196, 23);
            txt_pesquisa.TabIndex = 29;
            txt_pesquisa.TextChanged += txt_pesquisa_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(26, 45);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 1;
            label6.Text = "Produto :";
            // 
            // lv_est_tot
            // 
            lv_est_tot.Columns.AddRange(new ColumnHeader[] { codigo, produto, estoque_atual, obs });
            lv_est_tot.Font = new Font("Segoe UI", 9F);
            lv_est_tot.ForeColor = SystemColors.InfoText;
            lv_est_tot.FullRowSelect = true;
            lv_est_tot.GridLines = true;
            lv_est_tot.Location = new Point(26, 72);
            lv_est_tot.Name = "lv_est_tot";
            lv_est_tot.Size = new Size(638, 803);
            lv_est_tot.TabIndex = 0;
            lv_est_tot.UseCompatibleStateImageBehavior = false;
            lv_est_tot.View = View.Details;
            lv_est_tot.SelectedIndexChanged += lv_est_tot_SelectedIndexChanged;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // estoque_atual
            // 
            estoque_atual.Text = "Estoque ";
            estoque_atual.TextAlign = HorizontalAlignment.Center;
            estoque_atual.Width = 80;
            // 
            // obs
            // 
            obs.Text = "OBS";
            obs.Width = 120;
            // 
            // btn_pesquisa
            // 
            btn_pesquisa.BackColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa.BackgroundImage = (Image)resources.GetObject("btn_pesquisa.BackgroundImage");
            btn_pesquisa.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisa.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa.FlatStyle = FlatStyle.Flat;
            btn_pesquisa.Font = new Font("Segoe UI", 12F);
            btn_pesquisa.ForeColor = Color.FromArgb(31, 44, 50);
            btn_pesquisa.Location = new Point(293, 32);
            btn_pesquisa.Name = "btn_pesquisa";
            btn_pesquisa.Size = new Size(39, 33);
            btn_pesquisa.TabIndex = 27;
            btn_pesquisa.UseVisualStyleBackColor = false;
            btn_pesquisa.Click += btn_pesquisa_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(233, 240, 245);
            button2.BackgroundImage = Properties.Resources.atualizar;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.FromArgb(31, 44, 50);
            button2.Location = new Point(569, 32);
            button2.Name = "button2";
            button2.Size = new Size(39, 33);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1367, 1043);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btn_estoq;
        private Button btn_ger;
        private Button btn_cad;
        private Panel panel3;
        private Panel panel1;
        private Button btn_baixa;
        private GroupBox groupBox1;
        private Label label6;
        private ListView lv_est_tot;
        private ColumnHeader codigo;
        private ColumnHeader estoque_atual;
        private Button btn_pesquisa;
        private Button button2;
        private TextBox txt_pesquisa;
        private ColumnHeader obs;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button btn_print_est;
        private Panel panel8;
        private Button btn_epi;
    }
}
