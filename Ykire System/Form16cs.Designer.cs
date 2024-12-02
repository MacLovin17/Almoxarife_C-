namespace Ykire_System
{
    partial class Form16cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16cs));
            groupBox1 = new GroupBox();
            btn_pesquisa_forn = new Button();
            button1 = new Button();
            lv_fornecedor = new ListView();
            codigo = new ColumnHeader("(nenhum)");
            nome = new ColumnHeader();
            ramo = new ColumnHeader();
            txt_ramo = new TextBox();
            label4 = new Label();
            txt_cnpj = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_nome_forn = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_pesquisa_forn);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lv_fornecedor);
            groupBox1.Controls.Add(txt_ramo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_cnpj);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_nome_forn);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(50, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 634);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Fornecedor";
            // 
            // btn_pesquisa_forn
            // 
            btn_pesquisa_forn.BackColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa_forn.BackgroundImage = (Image)resources.GetObject("btn_pesquisa_forn.BackgroundImage");
            btn_pesquisa_forn.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisa_forn.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa_forn.FlatStyle = FlatStyle.Flat;
            btn_pesquisa_forn.Font = new Font("Segoe UI", 12F);
            btn_pesquisa_forn.ForeColor = Color.FromArgb(31, 44, 50);
            btn_pesquisa_forn.Location = new Point(274, 63);
            btn_pesquisa_forn.Name = "btn_pesquisa_forn";
            btn_pesquisa_forn.Size = new Size(39, 33);
            btn_pesquisa_forn.TabIndex = 93;
            btn_pesquisa_forn.UseVisualStyleBackColor = false;
            btn_pesquisa_forn.Click += btn_pesquisa_forn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(233, 240, 245);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(186, 200, 208);
            button1.Location = new Point(559, 44);
            button1.Name = "button1";
            button1.Size = new Size(39, 34);
            button1.TabIndex = 92;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lv_fornecedor
            // 
            lv_fornecedor.Columns.AddRange(new ColumnHeader[] { codigo, nome, ramo });
            lv_fornecedor.Font = new Font("Segoe UI", 10F);
            lv_fornecedor.FullRowSelect = true;
            lv_fornecedor.GridLines = true;
            lv_fornecedor.Location = new Point(6, 179);
            lv_fornecedor.Name = "lv_fornecedor";
            lv_fornecedor.Size = new Size(592, 440);
            lv_fornecedor.TabIndex = 58;
            lv_fornecedor.UseCompatibleStateImageBehavior = false;
            lv_fornecedor.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 320;
            // 
            // ramo
            // 
            ramo.Text = "Ramo";
            ramo.TextAlign = HorizontalAlignment.Center;
            ramo.Width = 185;
            // 
            // txt_ramo
            // 
            txt_ramo.Font = new Font("Segoe UI", 9F);
            txt_ramo.Location = new Point(274, 131);
            txt_ramo.Name = "txt_ramo";
            txt_ramo.Size = new Size(253, 23);
            txt_ramo.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(275, 108);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 56;
            label4.Text = "Ramo";
            // 
            // txt_cnpj
            // 
            txt_cnpj.Font = new Font("Segoe UI", 11F);
            txt_cnpj.Location = new Point(5, 131);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(254, 27);
            txt_cnpj.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 54;
            label2.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(7, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 44;
            label3.Text = "Nome";
            // 
            // txt_nome_forn
            // 
            txt_nome_forn.Font = new Font("Segoe UI", 11F);
            txt_nome_forn.Location = new Point(6, 67);
            txt_nome_forn.Name = "txt_nome_forn";
            txt_nome_forn.Size = new Size(253, 27);
            txt_nome_forn.TabIndex = 53;
            // 
            // Form16cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(705, 685);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form16cs";
            Text = "Fornecedor";
            Load += Form16cs_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_fornecedor;
        private ColumnHeader codigo;
        private ColumnHeader nome;
        private ColumnHeader ramo;
        private TextBox txt_ramo;
        private Label label4;
        private TextBox txt_cnpj;
        private Label label2;
        private Label label3;
        private TextBox txt_nome_forn;
        private Button button1;
        private Button btn_pesquisa_forn;
    }
}