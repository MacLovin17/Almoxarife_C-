namespace Ykire_System
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            groupBox2 = new GroupBox();
            txt_km = new TextBox();
            label1 = new Label();
            Cbox_combustivel = new ComboBox();
            cad_veiculo = new Button();
            txt_Lt = new TextBox();
            label6 = new Label();
            txt_epi_cod = new TextBox();
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
            valor = new ColumnHeader();
            data = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_km);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Cbox_combustivel);
            groupBox2.Controls.Add(cad_veiculo);
            groupBox2.Controls.Add(txt_Lt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_epi_cod);
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
            groupBox2.Location = new Point(152, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 679);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "Combustível";
            // 
            // txt_km
            // 
            txt_km.Location = new Point(138, 179);
            txt_km.Name = "txt_km";
            txt_km.Size = new Size(94, 29);
            txt_km.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(81, 180);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 81;
            label1.Text = "KM :";
            // 
            // Cbox_combustivel
            // 
            Cbox_combustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_combustivel.FormattingEnabled = true;
            Cbox_combustivel.ImeMode = ImeMode.NoControl;
            Cbox_combustivel.Items.AddRange(new object[] { "Gasolina", "Etanol", "Diesel" });
            Cbox_combustivel.Location = new Point(138, 129);
            Cbox_combustivel.Name = "Cbox_combustivel";
            Cbox_combustivel.Size = new Size(121, 29);
            Cbox_combustivel.TabIndex = 80;
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
            cad_veiculo.Location = new Point(665, 45);
            cad_veiculo.Name = "cad_veiculo";
            cad_veiculo.Size = new Size(39, 34);
            cad_veiculo.TabIndex = 79;
            cad_veiculo.UseVisualStyleBackColor = false;
            cad_veiculo.Click += cad_veiculo_Click;
            // 
            // txt_Lt
            // 
            txt_Lt.Location = new Point(375, 129);
            txt_Lt.Name = "txt_Lt";
            txt_Lt.Size = new Size(94, 29);
            txt_Lt.TabIndex = 78;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(271, 126);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 77;
            label6.Text = "Litragem :";
            // 
            // txt_epi_cod
            // 
            txt_epi_cod.Enabled = false;
            txt_epi_cod.Location = new Point(259, 85);
            txt_epi_cod.Name = "txt_epi_cod";
            txt_epi_cod.Size = new Size(191, 29);
            txt_epi_cod.TabIndex = 76;
            // 
            // btn_print_frota
            // 
            btn_print_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.BackgroundImage = Properties.Resources.printer;
            btn_print_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.FlatStyle = FlatStyle.Flat;
            btn_print_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print_frota.Location = new Point(786, 45);
            btn_print_frota.Name = "btn_print_frota";
            btn_print_frota.Size = new Size(39, 33);
            btn_print_frota.TabIndex = 3;
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
            btn_pesquisa_epi.Location = new Point(456, 44);
            btn_pesquisa_epi.Name = "btn_pesquisa_epi";
            btn_pesquisa_epi.Size = new Size(39, 33);
            btn_pesquisa_epi.TabIndex = 75;
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
            btn_frota.Location = new Point(731, 45);
            btn_frota.Name = "btn_frota";
            btn_frota.Size = new Size(39, 33);
            btn_frota.TabIndex = 61;
            btn_frota.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(6, 129);
            label9.Name = "label9";
            label9.Size = new Size(130, 28);
            label9.TabIndex = 73;
            label9.Text = "Combustível :";
            // 
            // txt_nome_epi
            // 
            txt_nome_epi.Enabled = false;
            txt_nome_epi.Location = new Point(259, 45);
            txt_nome_epi.Name = "txt_nome_epi";
            txt_nome_epi.Size = new Size(191, 29);
            txt_nome_epi.TabIndex = 72;
            // 
            // Txt_cod_veiculo
            // 
            Txt_cod_veiculo.Location = new Point(138, 85);
            Txt_cod_veiculo.Name = "Txt_cod_veiculo";
            Txt_cod_veiculo.Size = new Size(115, 29);
            Txt_cod_veiculo.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(6, 86);
            label8.Name = "label8";
            label8.Size = new Size(125, 28);
            label8.TabIndex = 69;
            label8.Text = "Cod Veículo :";
            // 
            // Txt_mat_frota
            // 
            Txt_mat_frota.Location = new Point(138, 45);
            Txt_mat_frota.Name = "Txt_mat_frota";
            Txt_mat_frota.Size = new Size(115, 29);
            Txt_mat_frota.TabIndex = 68;
            Txt_mat_frota.TextChanged += Txt_mat_frota_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(29, 44);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 67;
            label7.Text = "Matrícula :";
            label7.Click += label7_Click;
            // 
            // data_frota
            // 
            data_frota.Location = new Point(710, 125);
            data_frota.Name = "data_frota";
            data_frota.Size = new Size(115, 29);
            data_frota.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(659, 129);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 64;
            label5.Text = "Data:";
            // 
            // txt_data_frota
            // 
            txt_data_frota.Location = new Point(710, 125);
            txt_data_frota.Name = "txt_data_frota";
            txt_data_frota.Size = new Size(115, 29);
            txt_data_frota.TabIndex = 65;
            txt_data_frota.TextAlign = HorizontalAlignment.Center;
            // 
            // lv_gasolina
            // 
            lv_gasolina.Columns.AddRange(new ColumnHeader[] { codigo, tag, combustivel, litro, valor, data });
            lv_gasolina.FullRowSelect = true;
            lv_gasolina.GridLines = true;
            lv_gasolina.Location = new Point(29, 261);
            lv_gasolina.Name = "lv_gasolina";
            lv_gasolina.Size = new Size(816, 412);
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
            tag.Width = 250;
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
            litro.Width = 100;
            // 
            // valor
            // 
            valor.Text = "Valor";
            valor.TextAlign = HorizontalAlignment.Center;
            valor.Width = 100;
            // 
            // data
            // 
            data.Text = "Data";
            data.TextAlign = HorizontalAlignment.Center;
            data.Width = 100;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1198, 724);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form10";
            Text = "Logistica";
            Load += Form10_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button cad_veiculo;
        private TextBox txt_Lt;
        private Label label6;
        private TextBox txt_epi_cod;
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
        private ColumnHeader valor;
        private ComboBox Cbox_combustivel;
        private TextBox txt_km;
        private Label label1;
        private ColumnHeader data;
    }
}