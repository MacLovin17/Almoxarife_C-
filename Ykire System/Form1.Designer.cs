namespace Ykire_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_estoq = new Button();
            btn_ger = new Button();
            btn_cad = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 0;
            label1.Text = "Dit Corp";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btn_estoq);
            panel2.Controls.Add(btn_ger);
            panel2.Controls.Add(btn_cad);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 459);
            panel2.TabIndex = 1;
            // 
            // btn_estoq
            // 
            btn_estoq.BackColor = Color.Teal;
            btn_estoq.FlatStyle = FlatStyle.Flat;
            btn_estoq.ForeColor = SystemColors.ControlLightLight;
            btn_estoq.Location = new Point(12, 81);
            btn_estoq.Name = "btn_estoq";
            btn_estoq.Size = new Size(94, 34);
            btn_estoq.TabIndex = 4;
            btn_estoq.Text = "Estoque";
            btn_estoq.UseVisualStyleBackColor = false;
            btn_estoq.Click += btn_estoq_Click;
            // 
            // btn_ger
            // 
            btn_ger.BackColor = Color.Teal;
            btn_ger.FlatStyle = FlatStyle.Flat;
            btn_ger.ForeColor = SystemColors.ControlLightLight;
            btn_ger.Location = new Point(12, 135);
            btn_ger.Name = "btn_ger";
            btn_ger.Size = new Size(94, 34);
            btn_ger.TabIndex = 3;
            btn_ger.Text = "Gerencial";
            btn_ger.UseVisualStyleBackColor = false;
            // 
            // btn_cad
            // 
            btn_cad.BackColor = Color.Teal;
            btn_cad.FlatStyle = FlatStyle.Flat;
            btn_cad.ForeColor = SystemColors.ControlLightLight;
            btn_cad.Location = new Point(12, 29);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(94, 34);
            btn_cad.TabIndex = 2;
            btn_cad.Text = "Cadastro";
            btn_cad.UseVisualStyleBackColor = false;
            btn_cad.Click += btn_cad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 541);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Dit Corp";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_estoq;
        private Button btn_ger;
        private Button btn_cad;
        private Label label1;
    }
}
