namespace Ykire_System
{
    partial class Form15
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            groupBox2 = new GroupBox();
            txt_forn_manut = new TextBox();
            data_manut = new DateTimePicker();
            btn_manut_save = new Button();
            cbox_servico = new ComboBox();
            label3 = new Label();
            txt_custo_manut = new TextBox();
            label2 = new Label();
            button1 = new Button();
            txt_cod_forn_manut = new TextBox();
            label1 = new Label();
            btn_rel_frota = new Button();
            Cbox_cidade_manut = new ComboBox();
            city = new Label();
            Cbox_tipo_manut = new ComboBox();
            cad_veiculo = new Button();
            txt_veiculo_manut = new TextBox();
            btn_print_frota = new Button();
            btn_pesquisa_epi = new Button();
            label9 = new Label();
            txt_nome_manut = new TextBox();
            Txt_cod_veiculo_manut = new TextBox();
            label8 = new Label();
            Txt_mat_manut = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txt_data_manut = new TextBox();
            lv_manutencao = new ListView();
            cod_veiculo = new ColumnHeader("(nenhum)");
            cod_fornecedor = new ColumnHeader();
            cidade = new ColumnHeader();
            tipo = new ColumnHeader();
            servico = new ColumnHeader();
            valor = new ColumnHeader();
            data = new ColumnHeader();
            panel2 = new Panel();
            imageList1 = new ImageList(components);
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_forn_manut);
            groupBox2.Controls.Add(data_manut);
            groupBox2.Controls.Add(btn_manut_save);
            groupBox2.Controls.Add(cbox_servico);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_custo_manut);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txt_cod_forn_manut);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btn_rel_frota);
            groupBox2.Controls.Add(Cbox_cidade_manut);
            groupBox2.Controls.Add(city);
            groupBox2.Controls.Add(Cbox_tipo_manut);
            groupBox2.Controls.Add(cad_veiculo);
            groupBox2.Controls.Add(txt_veiculo_manut);
            groupBox2.Controls.Add(btn_print_frota);
            groupBox2.Controls.Add(btn_pesquisa_epi);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_nome_manut);
            groupBox2.Controls.Add(Txt_cod_veiculo_manut);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(Txt_mat_manut);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_data_manut);
            groupBox2.Controls.Add(lv_manutencao);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(165, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1208, 679);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manutenção";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txt_forn_manut
            // 
            txt_forn_manut.Enabled = false;
            txt_forn_manut.Font = new Font("Segoe UI", 9F);
            txt_forn_manut.Location = new Point(259, 149);
            txt_forn_manut.Name = "txt_forn_manut";
            txt_forn_manut.Size = new Size(311, 23);
            txt_forn_manut.TabIndex = 98;
            // 
            // data_manut
            // 
            data_manut.Location = new Point(1076, 228);
            data_manut.Name = "data_manut";
            data_manut.Size = new Size(115, 29);
            data_manut.TabIndex = 97;
            data_manut.ValueChanged += data_manut_ValueChanged_1;
            // 
            // btn_manut_save
            // 
            btn_manut_save.BackColor = Color.FromArgb(233, 240, 245);
            btn_manut_save.BackgroundImage = (Image)resources.GetObject("btn_manut_save.BackgroundImage");
            btn_manut_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_manut_save.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_manut_save.FlatStyle = FlatStyle.Flat;
            btn_manut_save.ForeColor = Color.FromArgb(186, 200, 208);
            btn_manut_save.Location = new Point(1027, 30);
            btn_manut_save.Name = "btn_manut_save";
            btn_manut_save.Size = new Size(39, 33);
            btn_manut_save.TabIndex = 78;
            btn_manut_save.UseVisualStyleBackColor = false;
            btn_manut_save.Click += btn_manut_save_Click;
            // 
            // cbox_servico
            // 
            cbox_servico.Font = new Font("Segoe UI", 9F);
            cbox_servico.FormattingEnabled = true;
            cbox_servico.ImeMode = ImeMode.NoControl;
            cbox_servico.Items.AddRange(new object[] { "Troca de óleo", "Troca de filtro de ar", "Troca de filtro de combustível", "Troca de filtro de cabine", "Revisão dos freios (pastilhas e discos)", "Alinhamento e balanceamento", "Rodízio de pneus", "Revisão do sistema de suspensão", "Troca de velas de ignição", "Revisão do sistema elétrico", "Revisão do sistema de ar-condicionado", "Troca de fluido de freio", "Troca de fluido da direção hidráulica", "Troca de fluido do radiador", "Troca de correia dentada", "Substituição de bateria", "Limpeza de bicos injetores", "Verificação e substituição de luzes", "Polimento e enceramento", "Higienização interna" });
            cbox_servico.Location = new Point(540, 202);
            cbox_servico.Name = "cbox_servico";
            cbox_servico.Size = new Size(235, 23);
            cbox_servico.TabIndex = 77;
            cbox_servico.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(468, 213);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 94;
            label3.Text = "Serviço :";
            // 
            // txt_custo_manut
            // 
            txt_custo_manut.Font = new Font("Segoe UI", 9F);
            txt_custo_manut.Location = new Point(696, 149);
            txt_custo_manut.Name = "txt_custo_manut";
            txt_custo_manut.Size = new Size(115, 23);
            txt_custo_manut.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(640, 160);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 92;
            label2.Text = "Valor :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(233, 240, 245);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(186, 200, 208);
            button1.Location = new Point(576, 144);
            button1.Name = "button1";
            button1.Size = new Size(39, 34);
            button1.TabIndex = 73;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_cod_forn_manut
            // 
            txt_cod_forn_manut.Font = new Font("Segoe UI", 9F);
            txt_cod_forn_manut.Location = new Point(138, 149);
            txt_cod_forn_manut.Name = "txt_cod_forn_manut";
            txt_cod_forn_manut.Size = new Size(115, 23);
            txt_cod_forn_manut.TabIndex = 72;
            txt_cod_forn_manut.TextChanged += txt_cod_forn_manut_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(7, 160);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 88;
            label1.Text = "Cod Fornecedor :";
            // 
            // btn_rel_frota
            // 
            btn_rel_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_rel_frota.BackgroundImage = (Image)resources.GetObject("btn_rel_frota.BackgroundImage");
            btn_rel_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_rel_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_rel_frota.FlatStyle = FlatStyle.Flat;
            btn_rel_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_rel_frota.Location = new Point(1135, 30);
            btn_rel_frota.Name = "btn_rel_frota";
            btn_rel_frota.Size = new Size(39, 33);
            btn_rel_frota.TabIndex = 80;
            btn_rel_frota.UseVisualStyleBackColor = false;
            // 
            // Cbox_cidade_manut
            // 
            Cbox_cidade_manut.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_cidade_manut.Font = new Font("Segoe UI", 9F);
            Cbox_cidade_manut.FormattingEnabled = true;
            Cbox_cidade_manut.ImeMode = ImeMode.NoControl;
            Cbox_cidade_manut.Items.AddRange(new object[] { "Paracatu-MG", "Brumadinho-MG", "Conceição Mato Dentro-MG" });
            Cbox_cidade_manut.Location = new Point(138, 202);
            Cbox_cidade_manut.Name = "Cbox_cidade_manut";
            Cbox_cidade_manut.Size = new Size(121, 23);
            Cbox_cidade_manut.TabIndex = 75;
            Cbox_cidade_manut.UseWaitCursor = true;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Font = new Font("Microsoft Sans Serif", 11.25F);
            city.ForeColor = SystemColors.ActiveCaptionText;
            city.Location = new Point(70, 212);
            city.Name = "city";
            city.Size = new Size(62, 18);
            city.TabIndex = 83;
            city.Text = "Cidade :";
            // 
            // Cbox_tipo_manut
            // 
            Cbox_tipo_manut.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_tipo_manut.Font = new Font("Segoe UI", 9F);
            Cbox_tipo_manut.FormattingEnabled = true;
            Cbox_tipo_manut.ImeMode = ImeMode.NoControl;
            Cbox_tipo_manut.Items.AddRange(new object[] { "Preventiva", "Corretiva", "Preditiva", "Detectiva" });
            Cbox_tipo_manut.Location = new Point(329, 202);
            Cbox_tipo_manut.Name = "Cbox_tipo_manut";
            Cbox_tipo_manut.Size = new Size(121, 23);
            Cbox_tipo_manut.TabIndex = 76;
            Cbox_tipo_manut.UseWaitCursor = true;
            // 
            // cad_veiculo
            // 
            cad_veiculo.BackColor = Color.FromArgb(233, 240, 245);
            cad_veiculo.BackgroundImage = (Image)resources.GetObject("cad_veiculo.BackgroundImage");
            cad_veiculo.BackgroundImageLayout = ImageLayout.Zoom;
            cad_veiculo.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            cad_veiculo.FlatStyle = FlatStyle.Flat;
            cad_veiculo.ForeColor = Color.FromArgb(186, 200, 208);
            cad_veiculo.Location = new Point(576, 100);
            cad_veiculo.Name = "cad_veiculo";
            cad_veiculo.Size = new Size(39, 34);
            cad_veiculo.TabIndex = 71;
            cad_veiculo.UseVisualStyleBackColor = false;
            cad_veiculo.Click += cad_veiculo_Click;
            // 
            // txt_veiculo_manut
            // 
            txt_veiculo_manut.Enabled = false;
            txt_veiculo_manut.Font = new Font("Segoe UI", 9F);
            txt_veiculo_manut.Location = new Point(259, 104);
            txt_veiculo_manut.Name = "txt_veiculo_manut";
            txt_veiculo_manut.Size = new Size(311, 23);
            txt_veiculo_manut.TabIndex = 76;
            // 
            // btn_print_frota
            // 
            btn_print_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.BackgroundImage = Properties.Resources.printer;
            btn_print_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.FlatStyle = FlatStyle.Flat;
            btn_print_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print_frota.Location = new Point(1076, 30);
            btn_print_frota.Name = "btn_print_frota";
            btn_print_frota.Size = new Size(39, 33);
            btn_print_frota.TabIndex = 79;
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
            btn_pesquisa_epi.Location = new Point(576, 50);
            btn_pesquisa_epi.Name = "btn_pesquisa_epi";
            btn_pesquisa_epi.Size = new Size(39, 33);
            btn_pesquisa_epi.TabIndex = 69;
            btn_pesquisa_epi.UseVisualStyleBackColor = false;
            btn_pesquisa_epi.Click += btn_pesquisa_epi_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(275, 212);
            label9.Name = "label9";
            label9.Size = new Size(45, 18);
            label9.TabIndex = 73;
            label9.Text = "Tipo :";
            // 
            // txt_nome_manut
            // 
            txt_nome_manut.Enabled = false;
            txt_nome_manut.Font = new Font("Segoe UI", 9F);
            txt_nome_manut.Location = new Point(259, 56);
            txt_nome_manut.Name = "txt_nome_manut";
            txt_nome_manut.Size = new Size(311, 23);
            txt_nome_manut.TabIndex = 72;
            // 
            // Txt_cod_veiculo_manut
            // 
            Txt_cod_veiculo_manut.Font = new Font("Segoe UI", 9F);
            Txt_cod_veiculo_manut.Location = new Point(138, 104);
            Txt_cod_veiculo_manut.Name = "Txt_cod_veiculo_manut";
            Txt_cod_veiculo_manut.Size = new Size(115, 23);
            Txt_cod_veiculo_manut.TabIndex = 70;
            Txt_cod_veiculo_manut.TextChanged += Txt_cod_veiculo_manut_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(33, 115);
            label8.Name = "label8";
            label8.Size = new Size(96, 18);
            label8.TabIndex = 69;
            label8.Text = "Cod Veículo :";
            // 
            // Txt_mat_manut
            // 
            Txt_mat_manut.Font = new Font("Segoe UI", 9F);
            Txt_mat_manut.Location = new Point(138, 56);
            Txt_mat_manut.Name = "Txt_mat_manut";
            Txt_mat_manut.Size = new Size(115, 23);
            Txt_mat_manut.TabIndex = 68;
            Txt_mat_manut.TextChanged += Txt_mat_manut_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(56, 65);
            label7.Name = "label7";
            label7.Size = new Size(76, 18);
            label7.TabIndex = 67;
            label7.Text = "Matrícula :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1027, 239);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 64;
            label5.Text = "Data:";
            // 
            // txt_data_manut
            // 
            txt_data_manut.Location = new Point(1076, 228);
            txt_data_manut.Name = "txt_data_manut";
            txt_data_manut.Size = new Size(115, 29);
            txt_data_manut.TabIndex = 65;
            txt_data_manut.TextAlign = HorizontalAlignment.Center;
            // 
            // lv_manutencao
            // 
            lv_manutencao.Columns.AddRange(new ColumnHeader[] { cod_veiculo, cod_fornecedor, cidade, tipo, servico, valor, data });
            lv_manutencao.Font = new Font("Segoe UI", 10F);
            lv_manutencao.FullRowSelect = true;
            lv_manutencao.GridLines = true;
            lv_manutencao.Location = new Point(41, 263);
            lv_manutencao.Name = "lv_manutencao";
            lv_manutencao.Size = new Size(1150, 412);
            lv_manutencao.TabIndex = 63;
            lv_manutencao.UseCompatibleStateImageBehavior = false;
            lv_manutencao.View = View.Details;
            // 
            // cod_veiculo
            // 
            cod_veiculo.Text = "Veículo";
            cod_veiculo.Width = 120;
            // 
            // cod_fornecedor
            // 
            cod_fornecedor.Text = "Fornecedor";
            cod_fornecedor.TextAlign = HorizontalAlignment.Center;
            cod_fornecedor.Width = 180;
            // 
            // cidade
            // 
            cidade.Text = "Cidade";
            cidade.TextAlign = HorizontalAlignment.Center;
            cidade.Width = 180;
            // 
            // tipo
            // 
            tipo.Text = "Tipo";
            tipo.TextAlign = HorizontalAlignment.Center;
            tipo.Width = 120;
            // 
            // servico
            // 
            servico.Text = "Serviço";
            servico.TextAlign = HorizontalAlignment.Center;
            servico.Width = 300;
            // 
            // valor
            // 
            valor.Text = "Custo";
            valor.TextAlign = HorizontalAlignment.Center;
            valor.Width = 80;
            // 
            // data
            // 
            data.Text = "Data";
            data.TextAlign = HorizontalAlignment.Center;
            data.Width = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 711);
            panel2.TabIndex = 63;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Black;
            imageList1.Images.SetKeyName(0, "formato-de-arquivo-pdf.png");
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1402, 711);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form15";
            Text = "Manutenção";
            Load += Form15_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_rel_frota;
        private ComboBox Cbox_cidade_manut;
        private Label city;
        private ComboBox Cbox_tipo_manut;
        private Button cad_veiculo;
        private TextBox txt_veiculo_manut;
        private Button btn_print_frota;
        private Button btn_pesquisa_epi;
        private Button btn_frota;
        private Label label9;
        private TextBox txt_nome_manut;
        private TextBox Txt_cod_veiculo_manut;
        private Label label8;
        private TextBox Txt_mat_manut;
        private Label label7;
        private DateTimePicker data_frota;
        private Label label5;
        private TextBox txt_data_manut;
        private ListView lv_manutencao;
        private ColumnHeader cod_veiculo;
        private ColumnHeader cod_fornecedor;
        private ColumnHeader cidade;
        private ColumnHeader tipo;
        private ColumnHeader servico;
        private ColumnHeader data;
        private Panel panel2;
        private Button button1;
        private TextBox txt_cod_forn_manut;
        private Label label1;
        private Label label3;
        private TextBox txt_custo_manut;
        private Label label2;
        private ComboBox cbox_servico;
        private Button btn_manut_save;
        private DateTimePicker data_manut;
        private ColumnHeader valor;
        private ImageList imageList1;
        private TextBox txt_forn_manut;
    }
}