namespace Ykire_System
{
    partial class epi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(epi));
            panel2 = new Panel();
            btn_print_epi = new Button();
            groupBox2 = new GroupBox();
            cad_funcionario = new Button();
            txt_CA = new TextBox();
            label6 = new Label();
            txt_epi_cod = new TextBox();
            btn_pesquisa_epi = new Button();
            btn_epi_save = new Button();
            txt_qt_epi = new TextBox();
            label9 = new Label();
            txt_nome_epi = new TextBox();
            Txt_epi_epi = new TextBox();
            label8 = new Label();
            Txt_mat_epi = new TextBox();
            label7 = new Label();
            data_epi = new DateTimePicker();
            label5 = new Label();
            txt_data_epi = new TextBox();
            lv_epi_func = new ListView();
            matricula_epi = new ColumnHeader("(nenhum)");
            nome = new ColumnHeader();
            epi_epi = new ColumnHeader();
            ca = new ColumnHeader();
            qt_epi = new ColumnHeader();
            data = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 931);
            panel2.TabIndex = 57;
            // 
            // btn_print_epi
            // 
            btn_print_epi.BackColor = Color.FromArgb(233, 240, 245);
            btn_print_epi.BackgroundImage = Properties.Resources.printer;
            btn_print_epi.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print_epi.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_print_epi.FlatStyle = FlatStyle.Flat;
            btn_print_epi.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print_epi.Location = new Point(786, 45);
            btn_print_epi.Name = "btn_print_epi";
            btn_print_epi.Size = new Size(39, 33);
            btn_print_epi.TabIndex = 3;
            btn_print_epi.UseVisualStyleBackColor = false;
            btn_print_epi.Click += btn_print_epi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cad_funcionario);
            groupBox2.Controls.Add(txt_CA);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_epi_cod);
            groupBox2.Controls.Add(btn_print_epi);
            groupBox2.Controls.Add(btn_pesquisa_epi);
            groupBox2.Controls.Add(btn_epi_save);
            groupBox2.Controls.Add(txt_qt_epi);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_nome_epi);
            groupBox2.Controls.Add(Txt_epi_epi);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(Txt_mat_epi);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(data_epi);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_data_epi);
            groupBox2.Controls.Add(lv_epi_func);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(166, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 635);
            groupBox2.TabIndex = 60;
            groupBox2.TabStop = false;
            groupBox2.Text = "EPI";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cad_funcionario
            // 
            cad_funcionario.BackColor = Color.FromArgb(233, 240, 245);
            cad_funcionario.BackgroundImage = (Image)resources.GetObject("cad_funcionario.BackgroundImage");
            cad_funcionario.BackgroundImageLayout = ImageLayout.Zoom;
            cad_funcionario.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            cad_funcionario.FlatStyle = FlatStyle.Flat;
            cad_funcionario.ForeColor = Color.FromArgb(186, 200, 208);
            cad_funcionario.Location = new Point(665, 45);
            cad_funcionario.Name = "cad_funcionario";
            cad_funcionario.Size = new Size(39, 34);
            cad_funcionario.TabIndex = 79;
            cad_funcionario.UseVisualStyleBackColor = false;
            cad_funcionario.Click += cad_funcionario_Click;
            // 
            // txt_CA
            // 
            txt_CA.Location = new Point(318, 125);
            txt_CA.Name = "txt_CA";
            txt_CA.Size = new Size(94, 29);
            txt_CA.TabIndex = 78;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(271, 126);
            label6.Name = "label6";
            label6.Size = new Size(41, 28);
            label6.TabIndex = 77;
            label6.Text = "CA:";
            // 
            // txt_epi_cod
            // 
            txt_epi_cod.Enabled = false;
            txt_epi_cod.Location = new Point(259, 85);
            txt_epi_cod.Name = "txt_epi_cod";
            txt_epi_cod.Size = new Size(191, 29);
            txt_epi_cod.TabIndex = 76;
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
            btn_pesquisa_epi.Click += btn_pesquisa_epi_Click;
            // 
            // btn_epi_save
            // 
            btn_epi_save.BackColor = Color.FromArgb(233, 240, 245);
            btn_epi_save.BackgroundImage = (Image)resources.GetObject("btn_epi_save.BackgroundImage");
            btn_epi_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_epi_save.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_epi_save.FlatStyle = FlatStyle.Flat;
            btn_epi_save.ForeColor = Color.FromArgb(186, 200, 208);
            btn_epi_save.Location = new Point(731, 45);
            btn_epi_save.Name = "btn_epi_save";
            btn_epi_save.Size = new Size(39, 33);
            btn_epi_save.TabIndex = 61;
            btn_epi_save.UseVisualStyleBackColor = false;
            btn_epi_save.Click += btn_epi_save_Click;
            // 
            // txt_qt_epi
            // 
            txt_qt_epi.Location = new Point(159, 125);
            txt_qt_epi.Name = "txt_qt_epi";
            txt_qt_epi.Size = new Size(94, 29);
            txt_qt_epi.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(29, 126);
            label9.Name = "label9";
            label9.Size = new Size(124, 28);
            label9.TabIndex = 73;
            label9.Text = "Quantidade :";
            // 
            // txt_nome_epi
            // 
            txt_nome_epi.Enabled = false;
            txt_nome_epi.Location = new Point(259, 45);
            txt_nome_epi.Name = "txt_nome_epi";
            txt_nome_epi.Size = new Size(191, 29);
            txt_nome_epi.TabIndex = 72;
            // 
            // Txt_epi_epi
            // 
            Txt_epi_epi.Location = new Point(138, 85);
            Txt_epi_epi.Name = "Txt_epi_epi";
            Txt_epi_epi.Size = new Size(115, 29);
            Txt_epi_epi.TabIndex = 70;
            Txt_epi_epi.TextChanged += Txt_epi_epi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(90, 85);
            label8.Name = "label8";
            label8.Size = new Size(42, 28);
            label8.TabIndex = 69;
            label8.Text = "EPI:";
            label8.Click += label8_Click;
            // 
            // Txt_mat_epi
            // 
            Txt_mat_epi.Location = new Point(138, 45);
            Txt_mat_epi.Name = "Txt_mat_epi";
            Txt_mat_epi.Size = new Size(115, 29);
            Txt_mat_epi.TabIndex = 68;
            Txt_mat_epi.TextChanged += Txt_mat_epi_TextChanged;
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
            // 
            // data_epi
            // 
            data_epi.Location = new Point(710, 125);
            data_epi.Name = "data_epi";
            data_epi.Size = new Size(115, 29);
            data_epi.TabIndex = 66;
            data_epi.ValueChanged += data_epi_ValueChanged;
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
            // txt_data_epi
            // 
            txt_data_epi.Location = new Point(710, 125);
            txt_data_epi.Name = "txt_data_epi";
            txt_data_epi.Size = new Size(115, 29);
            txt_data_epi.TabIndex = 65;
            txt_data_epi.TextAlign = HorizontalAlignment.Center;
            // 
            // lv_epi_func
            // 
            lv_epi_func.Columns.AddRange(new ColumnHeader[] { matricula_epi, nome, epi_epi, ca, qt_epi, data });
            lv_epi_func.FullRowSelect = true;
            lv_epi_func.GridLines = true;
            lv_epi_func.Location = new Point(29, 179);
            lv_epi_func.Name = "lv_epi_func";
            lv_epi_func.Size = new Size(796, 412);
            lv_epi_func.TabIndex = 63;
            lv_epi_func.UseCompatibleStateImageBehavior = false;
            lv_epi_func.View = View.Details;
            lv_epi_func.SelectedIndexChanged += lv_epi_func_SelectedIndexChanged;
            // 
            // matricula_epi
            // 
            matricula_epi.Text = "Matrícula";
            matricula_epi.Width = 80;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 250;
            // 
            // epi_epi
            // 
            epi_epi.Text = "EPI";
            epi_epi.TextAlign = HorizontalAlignment.Center;
            epi_epi.Width = 180;
            // 
            // ca
            // 
            ca.Text = "CA";
            ca.TextAlign = HorizontalAlignment.Center;
            // 
            // qt_epi
            // 
            qt_epi.Text = "Quantidade";
            qt_epi.TextAlign = HorizontalAlignment.Center;
            qt_epi.Width = 100;
            // 
            // data
            // 
            data.Text = "Data";
            data.TextAlign = HorizontalAlignment.Center;
            data.Width = 120;
            // 
            // epi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1843, 931);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "epi";
            Text = "EPI";
            Load += epi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btn_print_epi;
        private GroupBox groupBox2;
        private TextBox txt_qt_epi;
        private Label label9;
        private TextBox txt_nome_epi;
        private TextBox Txt_epi_epi;
        private Label label8;
        private TextBox Txt_mat_epi;
        private Label label7;
        private DateTimePicker data_epi;
        private Label label5;
        private TextBox txt_data_epi;
        private ListView lv_epi_func;
        private ColumnHeader matricula_epi;
        private ColumnHeader nome;
        private ColumnHeader epi_epi;
        private ColumnHeader data;
        private Button btn_epi_save;
        private ColumnHeader qt_epi;
        private Button btn_pesquisa_epi;
        private TextBox txt_epi_cod;
        private TextBox txt_CA;
        private Label label6;
        private ColumnHeader ca;
        private Button cad_funcionario;
    }
}