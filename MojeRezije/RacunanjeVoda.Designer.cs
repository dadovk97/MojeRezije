namespace MojeRezije
{
    partial class RacunanjeVoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacunanjeVoda));
            this.cb_Voda = new System.Windows.Forms.ComboBox();
            this.tb_Staro = new System.Windows.Forms.TextBox();
            this.tb_novo = new System.Windows.Forms.TextBox();
            this.tb_RazlikaVoda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_IzracunajVoda = new System.Windows.Forms.Button();
            this.btn_VodaOdustani = new System.Windows.Forms.Button();
            this.lbl_VodaIzracun = new System.Windows.Forms.Label();
            this.lbl_CijenaPDV = new System.Windows.Forms.Label();
            this.lbl_FiksniDio = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_vPlin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_vStruja = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Godina = new System.Windows.Forms.ComboBox();
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.cb_VMjesec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Voda
            // 
            this.cb_Voda.FormattingEnabled = true;
            this.cb_Voda.Items.AddRange(new object[] {
            "Vodovod - Osijek d.o.o",
            "Vodovod i Kanalizacija d.o.o Rijeka",
            "Vodoopskrba i odvodnja d.o.o Zagreb"});
            this.cb_Voda.Location = new System.Drawing.Point(205, 113);
            this.cb_Voda.Name = "cb_Voda";
            this.cb_Voda.Size = new System.Drawing.Size(121, 21);
            this.cb_Voda.TabIndex = 0;
            // 
            // tb_Staro
            // 
            this.tb_Staro.Location = new System.Drawing.Point(362, 114);
            this.tb_Staro.Name = "tb_Staro";
            this.tb_Staro.Size = new System.Drawing.Size(100, 20);
            this.tb_Staro.TabIndex = 1;
            // 
            // tb_novo
            // 
            this.tb_novo.Location = new System.Drawing.Point(508, 114);
            this.tb_novo.Name = "tb_novo";
            this.tb_novo.Size = new System.Drawing.Size(100, 20);
            this.tb_novo.TabIndex = 2;
            // 
            // tb_RazlikaVoda
            // 
            this.tb_RazlikaVoda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.tb_RazlikaVoda.Enabled = false;
            this.tb_RazlikaVoda.ForeColor = System.Drawing.Color.White;
            this.tb_RazlikaVoda.Location = new System.Drawing.Point(508, 172);
            this.tb_RazlikaVoda.Name = "tb_RazlikaVoda";
            this.tb_RazlikaVoda.Size = new System.Drawing.Size(100, 20);
            this.tb_RazlikaVoda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staro Stanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(521, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Novo Stanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(534, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Razlika";
            // 
            // btn_IzracunajVoda
            // 
            this.btn_IzracunajVoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IzracunajVoda.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_IzracunajVoda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_IzracunajVoda.Location = new System.Drawing.Point(301, 356);
            this.btn_IzracunajVoda.Name = "btn_IzracunajVoda";
            this.btn_IzracunajVoda.Size = new System.Drawing.Size(75, 23);
            this.btn_IzracunajVoda.TabIndex = 7;
            this.btn_IzracunajVoda.Text = "Izračunaj";
            this.btn_IzracunajVoda.UseVisualStyleBackColor = true;
            this.btn_IzracunajVoda.Click += new System.EventHandler(this.Btn_IzracunajVoda_Click);
            // 
            // btn_VodaOdustani
            // 
            this.btn_VodaOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VodaOdustani.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_VodaOdustani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_VodaOdustani.Location = new System.Drawing.Point(544, 356);
            this.btn_VodaOdustani.Name = "btn_VodaOdustani";
            this.btn_VodaOdustani.Size = new System.Drawing.Size(75, 23);
            this.btn_VodaOdustani.TabIndex = 8;
            this.btn_VodaOdustani.Text = "Izbornik";
            this.btn_VodaOdustani.UseVisualStyleBackColor = true;
            this.btn_VodaOdustani.Click += new System.EventHandler(this.Btn_VodaOdustani_Click);
            // 
            // lbl_VodaIzracun
            // 
            this.lbl_VodaIzracun.AutoSize = true;
            this.lbl_VodaIzracun.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_VodaIzracun.ForeColor = System.Drawing.Color.White;
            this.lbl_VodaIzracun.Location = new System.Drawing.Point(200, 308);
            this.lbl_VodaIzracun.Name = "lbl_VodaIzracun";
            this.lbl_VodaIzracun.Size = new System.Drawing.Size(105, 30);
            this.lbl_VodaIzracun.TabIndex = 9;
            this.lbl_VodaIzracun.Text = "Izračun ";
            this.lbl_VodaIzracun.Visible = false;
            // 
            // lbl_CijenaPDV
            // 
            this.lbl_CijenaPDV.AutoSize = true;
            this.lbl_CijenaPDV.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbl_CijenaPDV.ForeColor = System.Drawing.Color.White;
            this.lbl_CijenaPDV.Location = new System.Drawing.Point(202, 191);
            this.lbl_CijenaPDV.Name = "lbl_CijenaPDV";
            this.lbl_CijenaPDV.Size = new System.Drawing.Size(161, 16);
            this.lbl_CijenaPDV.TabIndex = 10;
            this.lbl_CijenaPDV.Text = "Ukupni dio cijene sa PDV-om";
            this.lbl_CijenaPDV.Visible = false;
            // 
            // lbl_FiksniDio
            // 
            this.lbl_FiksniDio.AutoSize = true;
            this.lbl_FiksniDio.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbl_FiksniDio.ForeColor = System.Drawing.Color.White;
            this.lbl_FiksniDio.Location = new System.Drawing.Point(202, 237);
            this.lbl_FiksniDio.Name = "lbl_FiksniDio";
            this.lbl_FiksniDio.Size = new System.Drawing.Size(88, 16);
            this.lbl_FiksniDio.TabIndex = 11;
            this.lbl_FiksniDio.Text = "Fiksni dio cijene";
            this.lbl_FiksniDio.Visible = false;
            // 
            // btn_Export
            // 
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Export.Location = new System.Drawing.Point(463, 356);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 12;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_vPlin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_vStruja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Moje Režije";
            // 
            // btn_vPlin
            // 
            this.btn_vPlin.FlatAppearance.BorderSize = 0;
            this.btn_vPlin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vPlin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vPlin.ForeColor = System.Drawing.Color.White;
            this.btn_vPlin.Image = global::MojeRezije.Properties.Resources.stove32;
            this.btn_vPlin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vPlin.Location = new System.Drawing.Point(3, 221);
            this.btn_vPlin.Name = "btn_vPlin";
            this.btn_vPlin.Size = new System.Drawing.Size(144, 68);
            this.btn_vPlin.TabIndex = 15;
            this.btn_vPlin.Text = "Plin";
            this.btn_vPlin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vPlin.UseVisualStyleBackColor = true;
            this.btn_vPlin.Click += new System.EventHandler(this.Btn_vPlin_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MojeRezije.Properties.Resources.tap32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "Voda";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_vStruja
            // 
            this.btn_vStruja.FlatAppearance.BorderSize = 0;
            this.btn_vStruja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vStruja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vStruja.ForeColor = System.Drawing.Color.White;
            this.btn_vStruja.Image = global::MojeRezije.Properties.Resources.struja32;
            this.btn_vStruja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vStruja.Location = new System.Drawing.Point(3, 153);
            this.btn_vStruja.Name = "btn_vStruja";
            this.btn_vStruja.Size = new System.Drawing.Size(144, 68);
            this.btn_vStruja.TabIndex = 14;
            this.btn_vStruja.Text = "Struja";
            this.btn_vStruja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vStruja.UseVisualStyleBackColor = true;
            this.btn_vStruja.Click += new System.EventHandler(this.Btn_vStruja_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(153, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 68);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Računanje vode";
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(589, 7);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 17;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(618, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Odaberite vodoopskrbnika";
            // 
            // cb_Godina
            // 
            this.cb_Godina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Godina.FormattingEnabled = true;
            this.cb_Godina.Items.AddRange(new object[] {
            "-",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cb_Godina.Location = new System.Drawing.Point(483, 221);
            this.cb_Godina.Name = "cb_Godina";
            this.cb_Godina.Size = new System.Drawing.Size(54, 21);
            this.cb_Godina.TabIndex = 36;
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Spremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spremi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Spremi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Spremi.Location = new System.Drawing.Point(382, 356);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(75, 23);
            this.btn_Spremi.TabIndex = 38;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = false;
            this.btn_Spremi.Click += new System.EventHandler(this.Btn_Spremi_Click);
            // 
            // cb_VMjesec
            // 
            this.cb_VMjesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VMjesec.FormattingEnabled = true;
            this.cb_VMjesec.Items.AddRange(new object[] {
            "Sijecanj",
            "Veljaca",
            "Ozujak",
            "Travanj",
            "Svibanj",
            "Lipanj",
            "Srpanj",
            "Kolovoz",
            "Rujan",
            "Listopad",
            "Studeni",
            "Prosinac"});
            this.cb_VMjesec.Location = new System.Drawing.Point(543, 221);
            this.cb_VMjesec.Name = "cb_VMjesec";
            this.cb_VMjesec.Size = new System.Drawing.Size(65, 21);
            this.cb_VMjesec.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(552, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mjesec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(488, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Godina";
            // 
            // RacunanjeVoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_VMjesec);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.cb_Godina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.lbl_FiksniDio);
            this.Controls.Add(this.lbl_CijenaPDV);
            this.Controls.Add(this.lbl_VodaIzracun);
            this.Controls.Add(this.btn_VodaOdustani);
            this.Controls.Add(this.btn_IzracunajVoda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_RazlikaVoda);
            this.Controls.Add(this.tb_novo);
            this.Controls.Add(this.tb_Staro);
            this.Controls.Add(this.cb_Voda);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RacunanjeVoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RacunanjeVoda";
            this.Load += new System.EventHandler(this.RacunanjeVoda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Voda;
        private System.Windows.Forms.TextBox tb_Staro;
        private System.Windows.Forms.TextBox tb_novo;
        private System.Windows.Forms.TextBox tb_RazlikaVoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_IzracunajVoda;
        private System.Windows.Forms.Button btn_VodaOdustani;
        private System.Windows.Forms.Label lbl_VodaIzracun;
        private System.Windows.Forms.Label lbl_CijenaPDV;
        private System.Windows.Forms.Label lbl_FiksniDio;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_vPlin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_vStruja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Godina;
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.ComboBox cb_VMjesec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}