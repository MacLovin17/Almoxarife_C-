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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            date_est_said = new DateTimePicker();
            panel3 = new Panel();
            label6 = new Label();
            lv_est_said = new ListView();
            codigo = new ColumnHeader();
            qt = new ColumnHeader();
            cgo = new ColumnHeader();
            obs = new ColumnHeader();
            txt_data_est_said = new TextBox();
            txt_qt_est_said = new TextBox();
            txt_cod_est_said = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_salva_est_said = new Button();
            Cbox_said = new ComboBox();
            label2 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // date_est_said
            // 
            date_est_said.Location = new Point(155, 230);
            date_est_said.Name = "date_est_said";
            date_est_said.Size = new Size(161, 23);
            date_est_said.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lv_est_said);
            panel3.Location = new Point(602, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 412);
            panel3.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(55, 6);
            label6.Name = "label6";
            label6.Size = new Size(207, 32);
            label6.TabIndex = 1;
            label6.Text = "Saída de Produtos";
            // 
            // lv_est_said
            // 
            lv_est_said.Columns.AddRange(new ColumnHeader[] { codigo, qt, cgo, obs });
            lv_est_said.Location = new Point(67, 60);
            lv_est_said.Name = "lv_est_said";
            lv_est_said.Size = new Size(386, 333);
            lv_est_said.TabIndex = 0;
            lv_est_said.UseCompatibleStateImageBehavior = false;
            lv_est_said.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // qt
            // 
            qt.Text = "Quantidade";
            qt.Width = 100;
            // 
            // cgo
            // 
            cgo.Text = "CGO";
            cgo.Width = 120;
            // 
            // obs
            // 
            obs.Text = "Data";
            obs.Width = 80;
            // 
            // txt_data_est_said
            // 
            txt_data_est_said.Location = new Point(155, 230);
            txt_data_est_said.Name = "txt_data_est_said";
            txt_data_est_said.Size = new Size(161, 23);
            txt_data_est_said.TabIndex = 33;
            txt_data_est_said.TextChanged += txt_data_est_said_TextChanged;
            // 
            // txt_qt_est_said
            // 
            txt_qt_est_said.Location = new Point(156, 116);
            txt_qt_est_said.Name = "txt_qt_est_said";
            txt_qt_est_said.Size = new Size(403, 23);
            txt_qt_est_said.TabIndex = 32;
            // 
            // txt_cod_est_said
            // 
            txt_cod_est_said.Location = new Point(156, 59);
            txt_cod_est_said.Name = "txt_cod_est_said";
            txt_cod_est_said.Size = new Size(403, 23);
            txt_cod_est_said.TabIndex = 31;
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
            panel2.Controls.Add(btn_salva_est_said);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 450);
            panel2.TabIndex = 27;
            // 
            // btn_salva_est_said
            // 
            btn_salva_est_said.BackColor = Color.FromArgb(31, 44, 50);
            btn_salva_est_said.FlatStyle = FlatStyle.Flat;
            btn_salva_est_said.ForeColor = Color.FromArgb(186, 200, 208);
            btn_salva_est_said.Location = new Point(12, 29);
            btn_salva_est_said.Name = "btn_salva_est_said";
            btn_salva_est_said.Size = new Size(94, 34);
            btn_salva_est_said.TabIndex = 2;
            btn_salva_est_said.Text = "Confirmar";
            btn_salva_est_said.UseVisualStyleBackColor = false;
            btn_salva_est_said.Click += btn_salva_est_said_Click;
            // 
            // Cbox_said
            // 
            Cbox_said.FormattingEnabled = true;
            Cbox_said.Location = new Point(156, 173);
            Cbox_said.Name = "Cbox_said";
            Cbox_said.Size = new Size(121, 23);
            Cbox_said.TabIndex = 35;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1454, 450);
            Controls.Add(label2);
            Controls.Add(Cbox_said);
            Controls.Add(date_est_said);
            Controls.Add(panel3);
            Controls.Add(txt_data_est_said);
            Controls.Add(txt_qt_est_said);
            Controls.Add(txt_cod_est_said);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date_est_said;
        private Panel panel3;
        private Label label6;
        private ListView lv_est_said;
        private ColumnHeader codigo;
        private ColumnHeader qt;
        private ColumnHeader obs;
        private TextBox txt_data_est_said;
        private TextBox txt_qt_est_said;
        private TextBox txt_cod_est_said;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Button btn_salva_est_said;
        private ComboBox Cbox_said;
        private Label label2;
        private ColumnHeader cgo;
    }
}