﻿namespace Ykire_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel2 = new Panel();
            btn_salva_cad = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_prod = new TextBox();
            txt_fornec = new TextBox();
            txt_cnpj = new TextBox();
            txt_obs = new TextBox();
            lv_cad = new ListView();
            codigo = new ColumnHeader();
            produto = new ColumnHeader();
            fornecedor = new ColumnHeader();
            cnpj = new ColumnHeader();
            obs = new ColumnHeader();
            endereco = new ColumnHeader();
            panel3 = new Panel();
            label6 = new Label();
            txt_prateleira = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Controls.Add(btn_salva_cad);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 821);
            panel2.TabIndex = 4;
            // 
            // btn_salva_cad
            // 
            btn_salva_cad.BackColor = Color.FromArgb(31, 44, 50);
            btn_salva_cad.BackgroundImage = Properties.Resources.pngwing_com;
            btn_salva_cad.BackgroundImageLayout = ImageLayout.Zoom;
            btn_salva_cad.FlatAppearance.BorderColor = Color.FromArgb(31, 44, 50);
            btn_salva_cad.FlatStyle = FlatStyle.Flat;
            btn_salva_cad.ForeColor = Color.FromArgb(186, 200, 208);
            btn_salva_cad.Location = new Point(31, 25);
            btn_salva_cad.Name = "btn_salva_cad";
            btn_salva_cad.Size = new Size(39, 33);
            btn_salva_cad.TabIndex = 16;
            btn_salva_cad.UseVisualStyleBackColor = false;
            btn_salva_cad.Click += btn_salva_cad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(140, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 6;
            label1.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(140, 95);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 7;
            label3.Text = "Fornecedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(140, 152);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 8;
            label4.Text = "CNPJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(140, 209);
            label5.Name = "label5";
            label5.Size = new Size(34, 19);
            label5.TabIndex = 9;
            label5.Text = "Obs";
            // 
            // txt_prod
            // 
            txt_prod.Location = new Point(140, 60);
            txt_prod.Name = "txt_prod";
            txt_prod.Size = new Size(403, 23);
            txt_prod.TabIndex = 11;
            // 
            // txt_fornec
            // 
            txt_fornec.Location = new Point(140, 117);
            txt_fornec.Name = "txt_fornec";
            txt_fornec.Size = new Size(403, 23);
            txt_fornec.TabIndex = 12;
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(140, 174);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(403, 23);
            txt_cnpj.TabIndex = 13;
            // 
            // txt_obs
            // 
            txt_obs.Location = new Point(140, 231);
            txt_obs.Name = "txt_obs";
            txt_obs.Size = new Size(403, 23);
            txt_obs.TabIndex = 14;
            // 
            // lv_cad
            // 
            lv_cad.Columns.AddRange(new ColumnHeader[] { codigo, produto, fornecedor, cnpj, obs, endereco });
            lv_cad.FullRowSelect = true;
            lv_cad.GridLines = true;
            lv_cad.Location = new Point(26, 50);
            lv_cad.Name = "lv_cad";
            lv_cad.Size = new Size(984, 733);
            lv_cad.TabIndex = 0;
            lv_cad.UseCompatibleStateImageBehavior = false;
            lv_cad.View = View.Details;
            lv_cad.SelectedIndexChanged += lv_cad_SelectedIndexChanged;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // produto
            // 
            produto.Text = "Descrição";
            produto.Width = 300;
            // 
            // fornecedor
            // 
            fornecedor.Text = "Fornecedor";
            fornecedor.Width = 200;
            // 
            // cnpj
            // 
            cnpj.Text = "CNPJ";
            cnpj.TextAlign = HorizontalAlignment.Center;
            cnpj.Width = 180;
            // 
            // obs
            // 
            obs.Text = "OBS";
            obs.TextAlign = HorizontalAlignment.Center;
            obs.Width = 100;
            // 
            // endereco
            // 
            endereco.Text = "Prateleira";
            endereco.TextAlign = HorizontalAlignment.Center;
            endereco.Width = 120;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lv_cad);
            panel3.Location = new Point(586, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(1040, 795);
            panel3.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(26, 9);
            label6.Name = "label6";
            label6.Size = new Size(245, 32);
            label6.TabIndex = 1;
            label6.Text = "Produtos Cadastrados";
            // 
            // txt_prateleira
            // 
            txt_prateleira.Location = new Point(140, 288);
            txt_prateleira.Name = "txt_prateleira";
            txt_prateleira.Size = new Size(403, 23);
            txt_prateleira.TabIndex = 15;
            txt_prateleira.TextChanged += txt_prateleira_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(140, 266);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 16;
            label2.Text = "Prateleira";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1858, 821);
            Controls.Add(txt_prateleira);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(txt_obs);
            Controls.Add(txt_cnpj);
            Controls.Add(txt_fornec);
            Controls.Add(txt_prod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Cadastro";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btn_salva_cad;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_prod;
        private TextBox txt_fornec;
        private TextBox txt_cnpj;
        private TextBox txt_obs;
        private ListView lv_cad;
        private ColumnHeader codigo;
        private ColumnHeader produto;
        private ColumnHeader fornecedor;
        private ColumnHeader obs;
        private Panel panel3;
        private Label label6;
        private ColumnHeader cnpj;
        private TextBox txt_prateleira;
        private Label label2;
        private ColumnHeader endereco;
    }
}