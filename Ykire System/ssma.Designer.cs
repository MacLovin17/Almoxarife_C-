namespace Ykire_System
{
    partial class ssma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ssma));
            Txt_mat_epi = new TextBox();
            label7 = new Label();
            label1 = new Label();
            Cbox_said = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // Txt_mat_epi
            // 
            Txt_mat_epi.Location = new Point(142, 31);
            Txt_mat_epi.Name = "Txt_mat_epi";
            Txt_mat_epi.Size = new Size(103, 23);
            Txt_mat_epi.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(33, 31);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 79;
            label7.Text = "Matrícula :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(254, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 81;
            label1.Text = "Nível :";
            // 
            // Cbox_said
            // 
            Cbox_said.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_said.FormattingEnabled = true;
            Cbox_said.ImeMode = ImeMode.NoControl;
            Cbox_said.Items.AddRange(new object[] { "Urgente", "Alta", "Média " });
            Cbox_said.Location = new Point(326, 31);
            Cbox_said.Name = "Cbox_said";
            Cbox_said.Size = new Size(121, 23);
            Cbox_said.TabIndex = 82;
            Cbox_said.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(33, 97);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 84;
            label2.Text = "Descrição :";
            // 
            // ssma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1512, 667);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Cbox_said);
            Controls.Add(label1);
            Controls.Add(Txt_mat_epi);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ssma";
            Text = "HelpDesk";
            Load += ssma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_mat_epi;
        private Label label7;
        private Label label1;
        private ComboBox Cbox_said;
        private TextBox textBox1;
        private Label label2;
    }
}