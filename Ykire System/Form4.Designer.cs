namespace Ykire_System
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel3 = new Panel();
            txt_pesquisa_saida = new TextBox();
            label7 = new Label();
            button2 = new Button();
            data_final = new DateTimePicker();
            data_inicio = new DateTimePicker();
            label5 = new Label();
            txt_data_final = new TextBox();
            txt_data_inicio = new TextBox();
            label6 = new Label();
            lv_est_said = new ListView();
            codigo = new ColumnHeader("(nenhum)");
            nome = new ColumnHeader();
            qt = new ColumnHeader();
            cgo = new ColumnHeader();
            obs = new ColumnHeader();
            txt_data_est_said = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_print = new Button();
            btn_salva_est_said = new Button();
            Cbox_said = new ComboBox();
            label2 = new Label();
            txt_cgo_desc = new TextBox();
            txt_cod_prod = new TextBox();
            txt_qt_est_said = new TextBox();
            txt_cod_est_said = new TextBox();
            date_est_said = new DateTimePicker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PrintDialog1 = new PrintDialog();
            pd1 = new System.Drawing.Printing.PrintDocument();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_pesquisa_saida);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(data_final);
            panel3.Controls.Add(data_inicio);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txt_data_final);
            panel3.Controls.Add(txt_data_inicio);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lv_est_said);
            panel3.Location = new Point(597, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 796);
            panel3.TabIndex = 34;
            // 
            // txt_pesquisa_saida
            // 
            txt_pesquisa_saida.Font = new Font("Segoe UI", 9F);
            txt_pesquisa_saida.Location = new Point(138, 62);
            txt_pesquisa_saida.Name = "txt_pesquisa_saida";
            txt_pesquisa_saida.Size = new Size(100, 23);
            txt_pesquisa_saida.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(47, 65);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 48;
            label7.Text = "Cód. Produto:";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(233, 240, 245);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.FromArgb(31, 44, 50);
            button2.Location = new Point(710, 50);
            button2.Name = "button2";
            button2.Size = new Size(74, 34);
            button2.TabIndex = 46;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // data_final
            // 
            data_final.DropDownAlign = LeftRightAlignment.Right;
            data_final.Location = new Point(589, 61);
            data_final.Name = "data_final";
            data_final.Size = new Size(115, 23);
            data_final.TabIndex = 45;
            data_final.ValueChanged += data_final_ValueChanged_1;
            // 
            // data_inicio
            // 
            data_inicio.DropDownAlign = LeftRightAlignment.Right;
            data_inicio.Location = new Point(468, 61);
            data_inicio.Name = "data_inicio";
            data_inicio.Size = new Size(115, 23);
            data_inicio.TabIndex = 47;
            data_inicio.ValueChanged += data_inicio_ValueChanged_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(401, 63);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 42;
            label5.Text = "Período :";
            // 
            // txt_data_final
            // 
            txt_data_final.Location = new Point(589, 61);
            txt_data_final.Name = "txt_data_final";
            txt_data_final.Size = new Size(115, 23);
            txt_data_final.TabIndex = 44;
            txt_data_final.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_data_inicio
            // 
            txt_data_inicio.Location = new Point(468, 61);
            txt_data_inicio.Name = "txt_data_inicio";
            txt_data_inicio.Size = new Size(115, 23);
            txt_data_inicio.TabIndex = 43;
            txt_data_inicio.TextAlign = HorizontalAlignment.Center;
            txt_data_inicio.TextChanged += txt_data_inicio_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(31, 6);
            label6.Name = "label6";
            label6.Size = new Size(207, 32);
            label6.TabIndex = 1;
            label6.Text = "Saída de Produtos";
            // 
            // lv_est_said
            // 
            lv_est_said.Columns.AddRange(new ColumnHeader[] { codigo, nome, qt, cgo, obs });
            lv_est_said.FullRowSelect = true;
            lv_est_said.GridLines = true;
            lv_est_said.Location = new Point(47, 91);
            lv_est_said.Name = "lv_est_said";
            lv_est_said.Size = new Size(737, 718);
            lv_est_said.TabIndex = 0;
            lv_est_said.UseCompatibleStateImageBehavior = false;
            lv_est_said.View = View.Details;
            lv_est_said.SelectedIndexChanged += lv_est_said_SelectedIndexChanged;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // nome
            // 
            nome.Text = "Descrição";
            nome.Width = 320;
            // 
            // qt
            // 
            qt.Text = "Quantidade";
            qt.TextAlign = HorizontalAlignment.Center;
            qt.Width = 100;
            // 
            // cgo
            // 
            cgo.Text = "CGO";
            cgo.TextAlign = HorizontalAlignment.Center;
            cgo.Width = 120;
            // 
            // obs
            // 
            obs.Text = "Data";
            obs.TextAlign = HorizontalAlignment.Center;
            obs.Width = 120;
            // 
            // txt_data_est_said
            // 
            txt_data_est_said.Location = new Point(155, 230);
            txt_data_est_said.Name = "txt_data_est_said";
            txt_data_est_said.Size = new Size(140, 23);
            txt_data_est_said.TabIndex = 33;
            txt_data_est_said.TextChanged += txt_data_est_said_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(155, 199);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 30;
            label4.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(156, 85);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 29;
            label3.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(156, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 28;
            label1.Text = "Código";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 44, 50);
            panel2.Controls.Add(btn_print);
            panel2.Controls.Add(btn_salva_est_said);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 825);
            panel2.TabIndex = 27;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.FromArgb(31, 44, 50);
            btn_print.BackgroundImage = Properties.Resources.printer;
            btn_print.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print.FlatAppearance.BorderColor = Color.FromArgb(31, 44, 50);
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print.Location = new Point(31, 80);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(39, 33);
            btn_print.TabIndex = 3;
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // btn_salva_est_said
            // 
            btn_salva_est_said.BackColor = Color.FromArgb(31, 44, 50);
            btn_salva_est_said.BackgroundImage = Properties.Resources.pngwing_com;
            btn_salva_est_said.BackgroundImageLayout = ImageLayout.Zoom;
            btn_salva_est_said.FlatAppearance.BorderColor = Color.FromArgb(31, 44, 50);
            btn_salva_est_said.FlatStyle = FlatStyle.Flat;
            btn_salva_est_said.ForeColor = Color.FromArgb(186, 200, 208);
            btn_salva_est_said.Location = new Point(31, 25);
            btn_salva_est_said.Name = "btn_salva_est_said";
            btn_salva_est_said.Size = new Size(39, 33);
            btn_salva_est_said.TabIndex = 2;
            btn_salva_est_said.UseVisualStyleBackColor = false;
            btn_salva_est_said.Click += btn_salva_est_said_Click;
            // 
            // Cbox_said
            // 
            Cbox_said.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_said.FormattingEnabled = true;
            Cbox_said.ImeMode = ImeMode.NoControl;
            Cbox_said.Location = new Point(156, 173);
            Cbox_said.Name = "Cbox_said";
            Cbox_said.Size = new Size(121, 23);
            Cbox_said.TabIndex = 35;
            Cbox_said.UseWaitCursor = true;
            Cbox_said.SelectedIndexChanged += Cbox_said_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(156, 142);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 36;
            label2.Text = "CGO";
            // 
            // txt_cgo_desc
            // 
            txt_cgo_desc.Enabled = false;
            txt_cgo_desc.Location = new Point(283, 173);
            txt_cgo_desc.Name = "txt_cgo_desc";
            txt_cgo_desc.Size = new Size(276, 23);
            txt_cgo_desc.TabIndex = 37;
            txt_cgo_desc.TextChanged += txt_cgo_desc_TextChanged;
            // 
            // txt_cod_prod
            // 
            txt_cod_prod.Enabled = false;
            txt_cod_prod.Location = new Point(283, 59);
            txt_cod_prod.Name = "txt_cod_prod";
            txt_cod_prod.Size = new Size(276, 23);
            txt_cod_prod.TabIndex = 38;
            txt_cod_prod.TextChanged += txt_cod_prod_TextChanged;
            // 
            // txt_qt_est_said
            // 
            txt_qt_est_said.Location = new Point(155, 116);
            txt_qt_est_said.Name = "txt_qt_est_said";
            txt_qt_est_said.Size = new Size(115, 23);
            txt_qt_est_said.TabIndex = 40;
            txt_qt_est_said.TextAlign = HorizontalAlignment.Center;
            txt_qt_est_said.TextChanged += txt_qt_est_said_TextChanged;
            // 
            // txt_cod_est_said
            // 
            txt_cod_est_said.Location = new Point(155, 59);
            txt_cod_est_said.Name = "txt_cod_est_said";
            txt_cod_est_said.Size = new Size(115, 23);
            txt_cod_est_said.TabIndex = 39;
            txt_cod_est_said.TextAlign = HorizontalAlignment.Center;
            txt_cod_est_said.TextChanged += txt_cod_est_said_TextChanged_1;
            // 
            // date_est_said
            // 
            date_est_said.DropDownAlign = LeftRightAlignment.Right;
            date_est_said.Location = new Point(155, 230);
            date_est_said.Name = "date_est_said";
            date_est_said.Size = new Size(140, 23);
            date_est_said.TabIndex = 41;
            date_est_said.ValueChanged += date_est_said_ValueChanged_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1454, 825);
            Controls.Add(date_est_said);
            Controls.Add(txt_qt_est_said);
            Controls.Add(txt_cod_est_said);
            Controls.Add(txt_cod_prod);
            Controls.Add(txt_cgo_desc);
            Controls.Add(label2);
            Controls.Add(Cbox_said);
            Controls.Add(panel3);
            Controls.Add(txt_data_est_said);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Baixa";
            Load += Form4_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label label6;
        private ListView lv_est_said;
        private ColumnHeader codigo;
        private ColumnHeader qt;
        private ColumnHeader obs;
        private TextBox txt_data_est_said;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Button btn_salva_est_said;
        private ComboBox Cbox_said;
        private Label label2;
        private ColumnHeader cgo;
        private TextBox txt_cgo_desc;
        private TextBox txt_cod_prod;
        private TextBox txt_qt_est_said;
        private TextBox txt_cod_est_said;
        private DateTimePicker date_est_said;
        private ColumnHeader nome;
        private TextBox txt_data_final;
        private TextBox txt_data_inicio;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker data_final;
        private Label label5;
        private Button button2;
        private DateTimePicker data_inicio;
        private Button btn_print;
        private PrintDialog PrintDialog1;
        private System.Drawing.Printing.PrintDocument pd1;
        private TextBox txt_pesquisa_saida;
        private Label label7;
    }
}