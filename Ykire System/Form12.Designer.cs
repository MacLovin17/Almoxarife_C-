﻿namespace Ykire_System
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            groupBox1 = new GroupBox();
            label9 = new Label();
            txt_pesquisa_cars = new TextBox();
            btn_pesquisa = new Button();
            txt_renavam = new TextBox();
            label7 = new Label();
            txt_chassi = new TextBox();
            label8 = new Label();
            txt_placa = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_desc_frota = new TextBox();
            btnc_cad_veiculo = new Button();
            lv_cars = new ListView();
            codigo = new ColumnHeader("(nenhum)");
            tag = new ColumnHeader();
            descricao = new ColumnHeader();
            placa = new ColumnHeader();
            ano = new ColumnHeader();
            crlv = new ColumnHeader();
            chassi = new ColumnHeader();
            renavam = new ColumnHeader();
            txt_crlv = new TextBox();
            label4 = new Label();
            txt_matricula = new TextBox();
            txt_ano_frota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_tag = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_pesquisa_cars);
            groupBox1.Controls.Add(btn_pesquisa);
            groupBox1.Controls.Add(txt_renavam);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_chassi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_placa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_desc_frota);
            groupBox1.Controls.Add(btnc_cad_veiculo);
            groupBox1.Controls.Add(lv_cars);
            groupBox1.Controls.Add(txt_crlv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_matricula);
            groupBox1.Controls.Add(txt_ano_frota);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_tag);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(48, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1405, 800);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Veículos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(1088, 156);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 90;
            label9.Text = "Placa";
            // 
            // txt_pesquisa_cars
            // 
            txt_pesquisa_cars.Font = new Font("Segoe UI", 9F);
            txt_pesquisa_cars.Location = new Point(1138, 150);
            txt_pesquisa_cars.Name = "txt_pesquisa_cars";
            txt_pesquisa_cars.Size = new Size(196, 23);
            txt_pesquisa_cars.TabIndex = 88;
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
            btn_pesquisa.Location = new Point(1340, 140);
            btn_pesquisa.Name = "btn_pesquisa";
            btn_pesquisa.Size = new Size(39, 33);
            btn_pesquisa.TabIndex = 89;
            btn_pesquisa.UseVisualStyleBackColor = false;
            btn_pesquisa.Click += btn_pesquisa_Click_1;
            // 
            // txt_renavam
            // 
            txt_renavam.Font = new Font("Segoe UI", 9F);
            txt_renavam.Location = new Point(521, 132);
            txt_renavam.Name = "txt_renavam";
            txt_renavam.Size = new Size(192, 23);
            txt_renavam.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(523, 109);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 87;
            label7.Text = "Renavam";
            // 
            // txt_chassi
            // 
            txt_chassi.Font = new Font("Segoe UI", 9F);
            txt_chassi.Location = new Point(359, 132);
            txt_chassi.Name = "txt_chassi";
            txt_chassi.Size = new Size(142, 23);
            txt_chassi.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(361, 109);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 85;
            label8.Text = "Chassi";
            label8.Click += label8_Click;
            // 
            // txt_placa
            // 
            txt_placa.Font = new Font("Segoe UI", 9F);
            txt_placa.Location = new Point(305, 67);
            txt_placa.Name = "txt_placa";
            txt_placa.Size = new Size(115, 23);
            txt_placa.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(306, 44);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 81;
            label5.Text = "Placa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(461, 44);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 82;
            label6.Text = "Descrição";
            // 
            // txt_desc_frota
            // 
            txt_desc_frota.Font = new Font("Segoe UI", 9F);
            txt_desc_frota.Location = new Point(460, 67);
            txt_desc_frota.Name = "txt_desc_frota";
            txt_desc_frota.Size = new Size(253, 23);
            txt_desc_frota.TabIndex = 55;
            // 
            // btnc_cad_veiculo
            // 
            btnc_cad_veiculo.BackColor = Color.FromArgb(233, 240, 245);
            btnc_cad_veiculo.BackgroundImage = (Image)resources.GetObject("btnc_cad_veiculo.BackgroundImage");
            btnc_cad_veiculo.BackgroundImageLayout = ImageLayout.Zoom;
            btnc_cad_veiculo.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btnc_cad_veiculo.FlatStyle = FlatStyle.Flat;
            btnc_cad_veiculo.ForeColor = Color.FromArgb(186, 200, 208);
            btnc_cad_veiculo.Location = new Point(824, 67);
            btnc_cad_veiculo.Name = "btnc_cad_veiculo";
            btnc_cad_veiculo.Size = new Size(39, 34);
            btnc_cad_veiculo.TabIndex = 60;
            btnc_cad_veiculo.UseVisualStyleBackColor = false;
            btnc_cad_veiculo.Click += btnc_cad_veiculo_Click;
            // 
            // lv_cars
            // 
            lv_cars.Columns.AddRange(new ColumnHeader[] { codigo, tag, descricao, placa, ano, crlv, chassi, renavam });
            lv_cars.Font = new Font("Segoe UI", 10F);
            lv_cars.FullRowSelect = true;
            lv_cars.GridLines = true;
            lv_cars.Location = new Point(6, 179);
            lv_cars.Name = "lv_cars";
            lv_cars.Size = new Size(1373, 615);
            lv_cars.TabIndex = 58;
            lv_cars.UseCompatibleStateImageBehavior = false;
            lv_cars.View = View.Details;
            lv_cars.SelectedIndexChanged += lv_func_SelectedIndexChanged;
            // 
            // codigo
            // 
            codigo.Text = "Codigo";
            codigo.Width = 80;
            // 
            // tag
            // 
            tag.Text = "TAG";
            tag.TextAlign = HorizontalAlignment.Center;
            tag.Width = 120;
            // 
            // descricao
            // 
            descricao.Text = "Descrição";
            descricao.Width = 300;
            // 
            // placa
            // 
            placa.Text = "Placa";
            placa.TextAlign = HorizontalAlignment.Center;
            placa.Width = 180;
            // 
            // ano
            // 
            ano.Text = "Ano";
            ano.TextAlign = HorizontalAlignment.Center;
            ano.Width = 120;
            // 
            // crlv
            // 
            crlv.Text = "CRLV";
            crlv.TextAlign = HorizontalAlignment.Center;
            crlv.Width = 180;
            // 
            // chassi
            // 
            chassi.Text = "Chassi";
            chassi.TextAlign = HorizontalAlignment.Center;
            chassi.Width = 180;
            // 
            // renavam
            // 
            renavam.Text = "Renavam";
            renavam.TextAlign = HorizontalAlignment.Center;
            renavam.Width = 180;
            // 
            // txt_crlv
            // 
            txt_crlv.Font = new Font("Segoe UI", 9F);
            txt_crlv.Location = new Point(139, 132);
            txt_crlv.Name = "txt_crlv";
            txt_crlv.Size = new Size(203, 23);
            txt_crlv.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(140, 109);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 56;
            label4.Text = "CRLV";
            // 
            // txt_matricula
            // 
            txt_matricula.Font = new Font("Segoe UI", 9F);
            txt_matricula.Location = new Point(5, 67);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(107, 23);
            txt_matricula.TabIndex = 52;
            // 
            // txt_ano_frota
            // 
            txt_ano_frota.Font = new Font("Segoe UI", 9F);
            txt_ano_frota.Location = new Point(5, 132);
            txt_ano_frota.Name = "txt_ano_frota";
            txt_ano_frota.Size = new Size(107, 23);
            txt_ano_frota.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 43;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 109);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 54;
            label2.Text = "Ano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(140, 44);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 44;
            label3.Text = "TAG";
            // 
            // txt_tag
            // 
            txt_tag.Font = new Font("Segoe UI", 9F);
            txt_tag.Location = new Point(139, 67);
            txt_tag.Name = "txt_tag";
            txt_tag.Size = new Size(144, 23);
            txt_tag.TabIndex = 53;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1513, 964);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form12";
            Text = "Veículos";
            Load += Form12_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_cars;
        private ColumnHeader codigo;
        private ColumnHeader tag;
        private ColumnHeader placa;
        private TextBox txt_crlv;
        private Label label4;
        private TextBox txt_matricula;
        private TextBox txt_ano_frota;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_tag;
        private Button btnc_cad_veiculo;
        private TextBox txt_placa;
        private Label label5;
        private Label label6;
        private TextBox txt_desc_frota;
        private TextBox txt_renavam;
        private Label label7;
        private TextBox txt_chassi;
        private Label label8;
        private ColumnHeader descricao;
        private ColumnHeader ano;
        private ColumnHeader crlv;
        private ColumnHeader chassi;
        private ColumnHeader renavam;
        private Label label9;
        private TextBox txt_pesquisa_cars;
        private Button btn_pesquisa;
    }
}