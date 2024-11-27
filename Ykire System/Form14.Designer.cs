namespace Ykire_System
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            groupBox2 = new GroupBox();
            btn_pesquisa_gasolina = new Button();
            data_final = new DateTimePicker();
            data_inicio = new DateTimePicker();
            label5 = new Label();
            txt_data_final_frota = new TextBox();
            txt_data_inicio_frota = new TextBox();
            btn_print_frota = new Button();
            lv_rel_comb = new ListView();
            codigo = new ColumnHeader("(nenhum)");
            tag = new ColumnHeader();
            combustivel = new ColumnHeader();
            litragem_total = new ColumnHeader();
            custo_total = new ColumnHeader();
            km_total = new ColumnHeader();
            combust_km = new ColumnHeader();
            km_por_dia = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_pesquisa_gasolina);
            groupBox2.Controls.Add(data_final);
            groupBox2.Controls.Add(data_inicio);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_data_final_frota);
            groupBox2.Controls.Add(txt_data_inicio_frota);
            groupBox2.Controls.Add(btn_print_frota);
            groupBox2.Controls.Add(lv_rel_comb);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(35, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1168, 774);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Combustível";
            // 
            // btn_pesquisa_gasolina
            // 
            btn_pesquisa_gasolina.BackColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa_gasolina.BackgroundImage = (Image)resources.GetObject("btn_pesquisa_gasolina.BackgroundImage");
            btn_pesquisa_gasolina.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisa_gasolina.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_pesquisa_gasolina.FlatStyle = FlatStyle.Flat;
            btn_pesquisa_gasolina.Font = new Font("Segoe UI", 12F);
            btn_pesquisa_gasolina.ForeColor = Color.FromArgb(31, 44, 50);
            btn_pesquisa_gasolina.Location = new Point(987, 56);
            btn_pesquisa_gasolina.Name = "btn_pesquisa_gasolina";
            btn_pesquisa_gasolina.Size = new Size(74, 34);
            btn_pesquisa_gasolina.TabIndex = 67;
            btn_pesquisa_gasolina.UseVisualStyleBackColor = false;
            btn_pesquisa_gasolina.Click += btn_pesquisa_gasolina_Click;
            // 
            // data_final
            // 
            data_final.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data_final.DropDownAlign = LeftRightAlignment.Right;
            data_final.Location = new Point(866, 63);
            data_final.Name = "data_final";
            data_final.Size = new Size(115, 29);
            data_final.TabIndex = 66;
            data_final.ValueChanged += data_final_ValueChanged;
            // 
            // data_inicio
            // 
            data_inicio.DropDownAlign = LeftRightAlignment.Right;
            data_inicio.Location = new Point(745, 63);
            data_inicio.Name = "data_inicio";
            data_inicio.Size = new Size(115, 29);
            data_inicio.TabIndex = 68;
            data_inicio.ValueChanged += data_inicio_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(672, 70);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 63;
            label5.Text = "Período :";
            // 
            // txt_data_final_frota
            // 
            txt_data_final_frota.Location = new Point(866, 63);
            txt_data_final_frota.Name = "txt_data_final_frota";
            txt_data_final_frota.Size = new Size(115, 29);
            txt_data_final_frota.TabIndex = 65;
            txt_data_final_frota.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_data_inicio_frota
            // 
            txt_data_inicio_frota.Location = new Point(745, 63);
            txt_data_inicio_frota.Name = "txt_data_inicio_frota";
            txt_data_inicio_frota.Size = new Size(115, 29);
            txt_data_inicio_frota.TabIndex = 64;
            txt_data_inicio_frota.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_print_frota
            // 
            btn_print_frota.BackColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.BackgroundImage = Properties.Resources.printer;
            btn_print_frota.BackgroundImageLayout = ImageLayout.Zoom;
            btn_print_frota.FlatAppearance.BorderColor = Color.FromArgb(233, 240, 245);
            btn_print_frota.FlatStyle = FlatStyle.Flat;
            btn_print_frota.ForeColor = Color.FromArgb(186, 200, 208);
            btn_print_frota.Location = new Point(1076, 56);
            btn_print_frota.Name = "btn_print_frota";
            btn_print_frota.Size = new Size(39, 33);
            btn_print_frota.TabIndex = 3;
            btn_print_frota.UseVisualStyleBackColor = false;
            btn_print_frota.Click += btn_print_frota_Click;
            // 
            // lv_rel_comb
            // 
            lv_rel_comb.Columns.AddRange(new ColumnHeader[] { codigo, tag, combustivel, litragem_total, custo_total, km_total, combust_km, km_por_dia });
            lv_rel_comb.Font = new Font("Segoe UI", 10F);
            lv_rel_comb.FullRowSelect = true;
            lv_rel_comb.GridLines = true;
            lv_rel_comb.Location = new Point(29, 97);
            lv_rel_comb.Name = "lv_rel_comb";
            lv_rel_comb.Size = new Size(1099, 657);
            lv_rel_comb.TabIndex = 63;
            lv_rel_comb.UseCompatibleStateImageBehavior = false;
            lv_rel_comb.View = View.Details;
            lv_rel_comb.SelectedIndexChanged += lv_rel_comb_SelectedIndexChanged;
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
            tag.Width = 150;
            // 
            // combustivel
            // 
            combustivel.Text = "Combustível";
            combustivel.TextAlign = HorizontalAlignment.Center;
            combustivel.Width = 180;
            // 
            // litragem_total
            // 
            litragem_total.Text = "Litros Total";
            litragem_total.TextAlign = HorizontalAlignment.Center;
            litragem_total.Width = 120;
            // 
            // custo_total
            // 
            custo_total.Text = "Custo Total";
            custo_total.TextAlign = HorizontalAlignment.Center;
            custo_total.Width = 150;
            // 
            // km_total
            // 
            km_total.Text = "Km Total";
            km_total.TextAlign = HorizontalAlignment.Center;
            km_total.Width = 110;
            // 
            // combust_km
            // 
            combust_km.Text = "Km/L";
            combust_km.TextAlign = HorizontalAlignment.Center;
            combust_km.Width = 150;
            // 
            // km_por_dia
            // 
            km_por_dia.Text = "Km/dia";
            km_por_dia.TextAlign = HorizontalAlignment.Center;
            km_por_dia.Width = 150;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 240, 245);
            ClientSize = new Size(1319, 813);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form14";
            Text = "Relatório Frota";
            Load += Form14_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_print_frota;
        private ListView lv_rel_comb;
        private ColumnHeader codigo;
        private ColumnHeader tag;
        private ColumnHeader combustivel;
        private ColumnHeader litragem_total;
        private ColumnHeader custo_total;
        private ColumnHeader combust_km;
        private Button btn_pesquisa_gasolina;
        private DateTimePicker data_final;
        private DateTimePicker data_inicio;
        private Label label5;
        private TextBox txt_data_final_frota;
        private TextBox txt_data_inicio_frota;
        private ColumnHeader km_total;
        private ColumnHeader km_por_dia;
    }
}