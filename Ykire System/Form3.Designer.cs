namespace Ykire_System
{
    partial class Form3
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
            panel3 = new Panel();
            label6 = new Label();
            lv_est = new ListView();
            codigo = new ColumnHeader();
            nome = new ColumnHeader();
            qt = new ColumnHeader();
            obs = new ColumnHeader();
            txt_data_est = new TextBox();
            txt_qt_est = new TextBox();
            txt_cod_est = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_salva_est = new Button();
            date_est = new DateTimePicker();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lv_est);
            panel3.Location = new Point(597, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 412);
            panel3.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(45, 15);
            label6.Name = "label6";
            label6.Size = new Size(265, 32);
            label6.TabIndex = 1;
            label6.Text = "Movimentação Estoque";
            label6.Click += label6_Click;
            // 
            // lv_est
            // 
            lv_est.Columns.AddRange(new ColumnHeader[] { codigo, nome, qt, obs });
            lv_est.Location = new Point(54, 60);
            lv_est.Name = "lv_est";
            lv_est.Size = new Size(501, 333);
            lv_est.TabIndex = 0;
            lv_est.UseCompatibleStateImageBehavior = false;
            lv_est.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "Código";
            codigo.Width = 80;
            // 
            // nome
            // 
            nome.Text = "Descrição";
            nome.Width = 250;
            // 
            // qt
            // 
            qt.Text = "Quantidade";
            qt.Width = 100;
            // 
            // obs
            // 
            obs.Text = "Data";
            obs.Width = 80;
            // 
            // txt_data_est
            // 
            txt_data_est.Location = new Point(151, 173);
            txt_data_est.Name = "txt_data_est";
            txt_data_est.Size = new Size(161, 23);
            txt_data_est.TabIndex = 23;
            // 
            // txt_qt_est
            // 
            txt_qt_est.Location = new Point(151, 116);
            txt_qt_est.Name = "txt_qt_est";
            txt_qt_est.Size = new Size(403, 23);
            txt_qt_est.TabIndex = 22;
            // 
            // txt_cod_est
            // 
            txt_cod_est.Location = new Point(151, 59);
            txt_cod_est.Name = "txt_cod_est";
            txt_cod_est.Size = new Size(403, 23);
            txt_cod_est.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(151, 142);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 19;
            label4.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(151, 85);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 18;
            label3.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(151, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 17;
            label1.Text = "Código";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btn_salva_est);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 450);
            panel2.TabIndex = 16;
            // 
            // btn_salva_est
            // 
            btn_salva_est.BackColor = Color.Teal;
            btn_salva_est.FlatStyle = FlatStyle.Flat;
            btn_salva_est.ForeColor = SystemColors.ControlLightLight;
            btn_salva_est.Location = new Point(12, 29);
            btn_salva_est.Name = "btn_salva_est";
            btn_salva_est.Size = new Size(94, 34);
            btn_salva_est.TabIndex = 2;
            btn_salva_est.Text = "Confirmar";
            btn_salva_est.UseVisualStyleBackColor = false;
            btn_salva_est.Click += btn_salva_est_Click;
            // 
            // date_est
            // 
            date_est.Location = new Point(151, 173);
            date_est.Name = "date_est";
            date_est.Size = new Size(161, 23);
            date_est.TabIndex = 2;
            date_est.ValueChanged += date_est_ValueChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 450);
            Controls.Add(date_est);
            Controls.Add(panel3);
            Controls.Add(txt_data_est);
            Controls.Add(txt_qt_est);
            Controls.Add(txt_cod_est);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Form3";
            Text = "Estoque";
            Load += Form3_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label6;
        private ListView lv_est;
        private ColumnHeader codigo;
        private ColumnHeader nome;
        private ColumnHeader qt;
        private ColumnHeader obs;
        private TextBox txt_data_est;
        private TextBox txt_qt_est;
        private TextBox txt_cod_est;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Button btn_salva_est;
        private DateTimePicker date_est;
    }
}