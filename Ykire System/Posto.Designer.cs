﻿namespace Ykire_System
{
    partial class Posto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posto));
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btn_rel_frota = new Button();
            txt_custo = new TextBox();
            label2 = new Label();
            Cbox_cidade = new ComboBox();
            city = new Label();
            txt_km = new TextBox();
            label1 = new Label();
            Cbox_combustivel = new ComboBox();
            cad_veiculo = new Button();
            txt_Lt = new TextBox();
            label6 = new Label();
            txt_veiculo_gas = new TextBox();
            btn_print_frota = new Button();
            btn_pesquisa_epi = new Button();
            btn_frota = new Button();
            label9 = new Label();
            txt_nome_epi = new TextBox();
            Txt_cod_veiculo = new TextBox();
            label8 = new Label();
            Txt_mat_frota = new TextBox();
            label7 = new Label();
            data_frota = new DateTimePicker();
            label5 = new Label();
            txt_data_frota = new TextBox();
            lv_gasolina = new ListView();
            codigo = new ColumnHeader("(nenhum)");
            tag = new ColumnHeader();
            combustivel = new ColumnHeader();
            litro = new ColumnHeader();
            data = new ColumnHeader();
            cidade = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 716);
            panel2.TabIndex = 63;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_rel_frota);
            groupBox2.Controls.Add(txt_custo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Cbox_cidade);
            groupBox2.Controls.Add(city);
            groupBox2.Controls.Add(txt_km);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Cbox_combustivel);
            groupBox2.Controls.Add(cad_veiculo);
            groupBox2.Controls.Add(txt_Lt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_veiculo_gas);
            groupBox2.Controls.Add(btn_print_frota);
            groupBox2.Controls.Add(btn_pesquisa_epi);
            groupBox2.Controls.Add(btn_frota);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_nome_epi);
            groupBox2.Controls.Add(Txt_cod_veiculo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(Txt_mat_frota);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(data_frota);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_data_frota);
            groupBox2.Controls.Add(lv_gasolina);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(139, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(973, 679);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consumíveis";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btn_rel_frota
            // 
            btn_rel_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_rel_frota.BackgroundImage = (Image)resources.GetObject("btn_rel_frota.BackgroundImage");
            btn_rel_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_rel_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_rel_frota.FlatStyle = FlatStyle.Flat;
            btn_rel_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_rel_frota.Location = new Point(885, 28);
            btn_rel_frota.Name = "btn_rel_frota";
            btn_rel_frota.Size = new Size(39, 33);
            btn_rel_frota.TabIndex = 79;
            btn_rel_frota.UseVisualStyleBackColor = false;
            // 
            // txt_custo
            // 
            txt_custo.Font = new Font("Segoe UI", 9F);
            txt_custo.Location = new Point(511, 151);
            txt_custo.Name = "txt_custo";
            txt_custo.Size = new Size(94, 23);
            txt_custo.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(451, 158);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 85;
            label2.Text = "Custo :";
            // 
            // Cbox_cidade
            // 
            Cbox_cidade.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_cidade.Font = new Font("Segoe UI", 9F);
            Cbox_cidade.FormattingEnabled = true;
            Cbox_cidade.ImeMode = ImeMode.NoControl;
            Cbox_cidade.Items.AddRange(new object[] { "Paracatu-MG", "Brumadinho-MG", "Conceição Mato Dentro-MG" });
            Cbox_cidade.Location = new Point(115, 200);
            Cbox_cidade.Name = "Cbox_cidade";
            Cbox_cidade.Size = new Size(121, 23);
            Cbox_cidade.TabIndex = 75;
            Cbox_cidade.UseWaitCursor = true;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Font = new Font("Microsoft Sans Serif", 11.25F);
            city.ForeColor = SystemColors.ActiveCaptionText;
            city.Location = new Point(47, 210);
            city.Name = "city";
            city.Size = new Size(62, 18);
            city.TabIndex = 83;
            city.Text = "Cidade :";
            // 
            // txt_km
            // 
            txt_km.Font = new Font("Segoe UI", 9F);
            txt_km.Location = new Point(343, 200);
            txt_km.Name = "txt_km";
            txt_km.Size = new Size(94, 23);
            txt_km.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(303, 210);
            label1.Name = "label1";
            label1.Size = new Size(39, 18);
            label1.TabIndex = 81;
            label1.Text = "KM :";
            // 
            // Cbox_combustivel
            // 
            Cbox_combustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_combustivel.Font = new Font("Segoe UI", 9F);
            Cbox_combustivel.FormattingEnabled = true;
            Cbox_combustivel.ImeMode = ImeMode.NoControl;
            Cbox_combustivel.Items.AddRange(new object[] { "Aditivo", "Óleo" });
            Cbox_combustivel.Location = new Point(115, 151);
            Cbox_combustivel.Name = "Cbox_combustivel";
            Cbox_combustivel.Size = new Size(121, 23);
            Cbox_combustivel.TabIndex = 72;
            Cbox_combustivel.UseWaitCursor = true;
            // 
            // cad_veiculo
            // 
            cad_veiculo.BackColor = Color.FromArgb(233, 240, 245);
            cad_veiculo.BackgroundImage = (Image)resources.GetObject("cad_veiculo.BackgroundImage");
            cad_veiculo.BackgroundImageLayout = ImageLayout.Zoom;
            cad_veiculo.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            cad_veiculo.FlatStyle = FlatStyle.Flat;
            cad_veiculo.ForeColor = Color.FromArgb(186, 200, 208);
            cad_veiculo.Location = new Point(433, 98);
            cad_veiculo.Name = "cad_veiculo";
            cad_veiculo.Size = new Size(39, 34);
            cad_veiculo.TabIndex = 71;
            cad_veiculo.UseVisualStyleBackColor = false;
            // 
            // txt_Lt
            // 
            txt_Lt.Font = new Font("Segoe UI", 9F);
            txt_Lt.Location = new Point(343, 151);
            txt_Lt.Name = "txt_Lt";
            txt_Lt.Size = new Size(94, 23);
            txt_Lt.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(264, 158);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 77;
            label6.Text = "Litragem :";
            // 
            // txt_veiculo_gas
            // 
            txt_veiculo_gas.Enabled = false;
            txt_veiculo_gas.Font = new Font("Segoe UI", 9F);
            txt_veiculo_gas.Location = new Point(236, 102);
            txt_veiculo_gas.Name = "txt_veiculo_gas";
            txt_veiculo_gas.Size = new Size(191, 23);
            txt_veiculo_gas.TabIndex = 76;
            // 
            // btn_print_frota
            // 
            btn_print_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.BackgroundImage = Properties.Resources.printer;
            btn_print_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.FlatStyle = FlatStyle.Flat;
            btn_print_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print_frota.Location = new Point(826, 28);
            btn_print_frota.Name = "btn_print_frota";
            btn_print_frota.Size = new Size(39, 33);
            btn_print_frota.TabIndex = 78;
            btn_print_frota.UseVisualStyleBackColor = false;
            // 
            // btn_pesquisa_epi
            // 
            btn_pesquisa_epi.BackColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa_epi.BackgroundImage = (Image)resources.GetObject("btn_pesquisa_epi.BackgroundImage");
            btn_pesquisa_epi.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisa_epi.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa_epi.FlatStyle = FlatStyle.Flat;
            btn_pesquisa_epi.Font = new Font("Segoe UI", 12F);
            btn_pesquisa_epi.ForeColor = Color.FromArgb(31, 44, 50);
            btn_pesquisa_epi.Location = new Point(433, 48);
            btn_pesquisa_epi.Name = "btn_pesquisa_epi";
            btn_pesquisa_epi.Size = new Size(39, 33);
            btn_pesquisa_epi.TabIndex = 69;
            btn_pesquisa_epi.UseVisualStyleBackColor = false;
            // 
            // btn_frota
            // 
            btn_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_frota.BackgroundImage = (Image)resources.GetObject("btn_frota.BackgroundImage");
            btn_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_frota.FlatStyle = FlatStyle.Flat;
            btn_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_frota.Location = new Point(771, 28);
            btn_frota.Name = "btn_frota";
            btn_frota.Size = new Size(39, 33);
            btn_frota.TabIndex = 77;
            btn_frota.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(33, 158);
            label9.Name = "label9";
            label9.Size = new Size(69, 18);
            label9.TabIndex = 73;
            label9.Text = "Produto :";
            // 
            // txt_nome_epi
            // 
            txt_nome_epi.Enabled = false;
            txt_nome_epi.Font = new Font("Segoe UI", 9F);
            txt_nome_epi.Location = new Point(236, 54);
            txt_nome_epi.Name = "txt_nome_epi";
            txt_nome_epi.Size = new Size(191, 23);
            txt_nome_epi.TabIndex = 72;
            // 
            // Txt_cod_veiculo
            // 
            Txt_cod_veiculo.Font = new Font("Segoe UI", 9F);
            Txt_cod_veiculo.Location = new Point(115, 102);
            Txt_cod_veiculo.Name = "Txt_cod_veiculo";
            Txt_cod_veiculo.Size = new Size(115, 23);
            Txt_cod_veiculo.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(10, 113);
            label8.Name = "label8";
            label8.Size = new Size(96, 18);
            label8.TabIndex = 69;
            label8.Text = "Cod Veículo :";
            // 
            // Txt_mat_frota
            // 
            Txt_mat_frota.Font = new Font("Segoe UI", 9F);
            Txt_mat_frota.Location = new Point(115, 54);
            Txt_mat_frota.Name = "Txt_mat_frota";
            Txt_mat_frota.Size = new Size(115, 23);
            Txt_mat_frota.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(33, 63);
            label7.Name = "label7";
            label7.Size = new Size(76, 18);
            label7.TabIndex = 67;
            label7.Text = "Matrícula :";
            // 
            // data_frota
            // 
            data_frota.Location = new Point(826, 226);
            data_frota.Name = "data_frota";
            data_frota.Size = new Size(115, 29);
            data_frota.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(777, 237);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 64;
            label5.Text = "Data:";
            // 
            // txt_data_frota
            // 
            txt_data_frota.Location = new Point(826, 226);
            txt_data_frota.Name = "txt_data_frota";
            txt_data_frota.Size = new Size(115, 29);
            txt_data_frota.TabIndex = 65;
            txt_data_frota.TextAlign = HorizontalAlignment.Center;
            // 
            // lv_gasolina
            // 
            lv_gasolina.Columns.AddRange(new ColumnHeader[] { codigo, tag, combustivel, litro, data, cidade });
            lv_gasolina.Font = new Font("Segoe UI", 10F);
            lv_gasolina.FullRowSelect = true;
            lv_gasolina.GridLines = true;
            lv_gasolina.Location = new Point(29, 261);
            lv_gasolina.Name = "lv_gasolina";
            lv_gasolina.Size = new Size(917, 412);
            lv_gasolina.TabIndex = 63;
            lv_gasolina.UseCompatibleStateImageBehavior = false;
            lv_gasolina.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // tag
            // 
            tag.Text = "TAG";
            tag.TextAlign = HorizontalAlignment.Center;
            tag.Width = 180;
            // 
            // combustivel
            // 
            combustivel.Text = "Combustível";
            combustivel.TextAlign = HorizontalAlignment.Center;
            combustivel.Width = 180;
            // 
            // litro
            // 
            litro.Text = "Litros";
            litro.TextAlign = HorizontalAlignment.Center;
            litro.Width = 120;
            // 
            // data
            // 
            data.Text = "Data";
            data.TextAlign = HorizontalAlignment.Center;
            data.Width = 150;
            // 
            // cidade
            // 
            cidade.Text = "Cidade";
            cidade.TextAlign = HorizontalAlignment.Center;
            cidade.Width = 200;
            // 
            // Posto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1273, 716);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Posto";
            Text = "Posto";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox2;
        private Button btn_rel_frota;
        private TextBox txt_custo;
        private Label label2;
        private ComboBox Cbox_cidade;
        private Label city;
        private TextBox txt_km;
        private Label label1;
        private ComboBox Cbox_combustivel;
        private Button cad_veiculo;
        private TextBox txt_Lt;
        private Label label6;
        private TextBox txt_veiculo_gas;
        private Button btn_print_frota;
        private Button btn_pesquisa_epi;
        private Button btn_frota;
        private Label label9;
        private TextBox txt_nome_epi;
        private TextBox Txt_cod_veiculo;
        private Label label8;
        private TextBox Txt_mat_frota;
        private Label label7;
        private DateTimePicker data_frota;
        private Label label5;
        private TextBox txt_data_frota;
        private ListView lv_gasolina;
        private ColumnHeader codigo;
        private ColumnHeader tag;
        private ColumnHeader combustivel;
        private ColumnHeader litro;
        private ColumnHeader data;
        private ColumnHeader cidade;
    }
}