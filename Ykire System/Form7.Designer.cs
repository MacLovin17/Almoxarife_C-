namespace Ykire_System
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            groupBox1 = new GroupBox();
            lv_func = new ListView();
            matricula = new ColumnHeader("(nenhum)");
            nome_epi = new ColumnHeader();
            funcao = new ColumnHeader();
            btn_cad_epi = new Button();
            txt_funcao_func = new TextBox();
            label4 = new Label();
            txt_matricula = new TextBox();
            txt_setor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nome_func = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lv_func);
            groupBox1.Controls.Add(btn_cad_epi);
            groupBox1.Controls.Add(txt_funcao_func);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_matricula);
            groupBox1.Controls.Add(txt_setor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_nome_func);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(52, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 634);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Funcionários";
            // 
            // lv_func
            // 
            lv_func.Columns.AddRange(new ColumnHeader[] { matricula, nome_epi, funcao });
            lv_func.FullRowSelect = true;
            lv_func.GridLines = true;
            lv_func.Location = new Point(6, 179);
            lv_func.Name = "lv_func";
            lv_func.Size = new Size(592, 440);
            lv_func.TabIndex = 58;
            lv_func.UseCompatibleStateImageBehavior = false;
            lv_func.View = View.Details;
            lv_func.SelectedIndexChanged += lv_func_SelectedIndexChanged;
            // 
            // matricula
            // 
            matricula.Text = "Matrícula";
            matricula.Width = 80;
            // 
            // nome_epi
            // 
            nome_epi.Text = "Nome";
            nome_epi.Width = 320;
            // 
            // funcao
            // 
            funcao.Text = "Função";
            funcao.TextAlign = HorizontalAlignment.Center;
            funcao.Width = 185;
            // 
            // btn_cad_epi
            // 
            btn_cad_epi.BackColor = Color.FromArgb(233, 240, 245);
            btn_cad_epi.BackgroundImage = (Image)resources.GetObject("btn_cad_epi.BackgroundImage");
            btn_cad_epi.BackgroundImageLayout = ImageLayout.Zoom;
            btn_cad_epi.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_cad_epi.FlatStyle = FlatStyle.Flat;
            btn_cad_epi.ForeColor = Color.FromArgb(186, 200, 208);
            btn_cad_epi.Location = new Point(448, 95);
            btn_cad_epi.Name = "btn_cad_epi";
            btn_cad_epi.Size = new Size(39, 33);
            btn_cad_epi.TabIndex = 2;
            btn_cad_epi.UseVisualStyleBackColor = false;
            btn_cad_epi.Click += btn_cad_epi_Click;
            // 
            // txt_funcao_func
            // 
            txt_funcao_func.Location = new Point(160, 132);
            txt_funcao_func.Name = "txt_funcao_func";
            txt_funcao_func.Size = new Size(253, 29);
            txt_funcao_func.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(161, 101);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 56;
            label4.Text = "Função";
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(5, 67);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(115, 29);
            txt_matricula.TabIndex = 52;
            // 
            // txt_setor
            // 
            txt_setor.Location = new Point(5, 132);
            txt_setor.Name = "txt_setor";
            txt_setor.Size = new Size(115, 29);
            txt_setor.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 43;
            label1.Text = "Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 54;
            label2.Text = "Setor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(161, 36);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 44;
            label3.Text = "Nome";
            // 
            // txt_nome_func
            // 
            txt_nome_func.Location = new Point(160, 67);
            txt_nome_func.Name = "txt_nome_func";
            txt_nome_func.Size = new Size(253, 29);
            txt_nome_func.TabIndex = 53;
            // 
            // Form7
            // 
            AcceptButton = btn_cad_epi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(746, 656);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Funcionários";
            Load += Func_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_func;
        private ColumnHeader matricula;
        private ColumnHeader nome_epi;
        private ColumnHeader funcao;
        private Button btn_cad_epi;
        private TextBox txt_funcao_func;
        private Label label4;
        private TextBox txt_matricula;
        private TextBox txt_setor;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nome_func;
    }
}