namespace MojeRezije
{
    partial class RacunanjePlin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacunanjePlin));
            this.cb_Tarifa = new System.Windows.Forms.ComboBox();
            this.btn_Pizracunaj = new System.Windows.Forms.Button();
            this.btn_Podustani = new System.Windows.Forms.Button();
            this.tb_Plin1 = new System.Windows.Forms.TextBox();
            this.tb_Plin2 = new System.Windows.Forms.TextBox();
            this.tb_Prazlika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Pizracunaj = new System.Windows.Forms.Label();
            this.cb_TM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ExportPlin = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sPlin = new System.Windows.Forms.Button();
            this.btn_pVoda = new System.Windows.Forms.Button();
            this.btn_pStruja = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.cb_Godina = new System.Windows.Forms.ComboBox();
            this.cb_PMjesec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Tarifa
            // 
            this.cb_Tarifa.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Tarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tarifa.FormattingEnabled = true;
            this.cb_Tarifa.Items.AddRange(new object[] {
            "PPD",
            "PIS"});
            this.cb_Tarifa.Location = new System.Drawing.Point(205, 221);
            this.cb_Tarifa.Name = "cb_Tarifa";
            this.cb_Tarifa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_Tarifa.Size = new System.Drawing.Size(121, 21);
            this.cb_Tarifa.TabIndex = 0;
            // 
            // btn_Pizracunaj
            // 
            this.btn_Pizracunaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Pizracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pizracunaj.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Pizracunaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Pizracunaj.Location = new System.Drawing.Point(301, 356);
            this.btn_Pizracunaj.Name = "btn_Pizracunaj";
            this.btn_Pizracunaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Pizracunaj.TabIndex = 1;
            this.btn_Pizracunaj.Text = "Izračunaj";
            this.btn_Pizracunaj.UseVisualStyleBackColor = false;
            this.btn_Pizracunaj.Click += new System.EventHandler(this.Btn_Pizracunaj_Click);
            // 
            // btn_Podustani
            // 
            this.btn_Podustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Podustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Podustani.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Podustani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Podustani.Location = new System.Drawing.Point(544, 356);
            this.btn_Podustani.Name = "btn_Podustani";
            this.btn_Podustani.Size = new System.Drawing.Size(75, 23);
            this.btn_Podustani.TabIndex = 2;
            this.btn_Podustani.Text = "Izbornik";
            this.btn_Podustani.UseVisualStyleBackColor = false;
            this.btn_Podustani.Click += new System.EventHandler(this.Btn_Podustani_Click);
            // 
            // tb_Plin1
            // 
            this.tb_Plin1.Location = new System.Drawing.Point(362, 114);
            this.tb_Plin1.Name = "tb_Plin1";
            this.tb_Plin1.Size = new System.Drawing.Size(100, 20);
            this.tb_Plin1.TabIndex = 3;
            // 
            // tb_Plin2
            // 
            this.tb_Plin2.Location = new System.Drawing.Point(508, 114);
            this.tb_Plin2.Name = "tb_Plin2";
            this.tb_Plin2.Size = new System.Drawing.Size(100, 20);
            this.tb_Plin2.TabIndex = 4;
            // 
            // tb_Prazlika
            // 
            this.tb_Prazlika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.tb_Prazlika.Enabled = false;
            this.tb_Prazlika.ForeColor = System.Drawing.Color.White;
            this.tb_Prazlika.Location = new System.Drawing.Point(508, 172);
            this.tb_Prazlika.Name = "tb_Prazlika";
            this.tb_Prazlika.Size = new System.Drawing.Size(100, 20);
            this.tb_Prazlika.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Potrosnja za prosli mjesec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Potrosnja za ovaj mjesec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(534, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Razlika";
            // 
            // lbl_Pizracunaj
            // 
            this.lbl_Pizracunaj.AutoSize = true;
            this.lbl_Pizracunaj.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_Pizracunaj.ForeColor = System.Drawing.Color.White;
            this.lbl_Pizracunaj.Location = new System.Drawing.Point(200, 308);
            this.lbl_Pizracunaj.Name = "lbl_Pizracunaj";
            this.lbl_Pizracunaj.Size = new System.Drawing.Size(98, 30);
            this.lbl_Pizracunaj.TabIndex = 9;
            this.lbl_Pizracunaj.Text = "Izračun";
            this.lbl_Pizracunaj.Visible = false;
            // 
            // cb_TM
            // 
            this.cb_TM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TM.FormattingEnabled = true;
            this.cb_TM.Items.AddRange(new object[] {
            "TM1",
            "TM2",
            "TM3",
            "TM4",
            "TM5",
            "TM6",
            "TM7",
            "TM8",
            "TM9",
            "TM10",
            "TM11",
            "TM12"});
            this.cb_TM.Location = new System.Drawing.Point(205, 113);
            this.cb_TM.Name = "cb_TM";
            this.cb_TM.Size = new System.Drawing.Size(121, 21);
            this.cb_TM.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(218, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tarifni Model";
            // 
            // btn_ExportPlin
            // 
            this.btn_ExportPlin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_ExportPlin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportPlin.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_ExportPlin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ExportPlin.Location = new System.Drawing.Point(463, 356);
            this.btn_ExportPlin.Name = "btn_ExportPlin";
            this.btn_ExportPlin.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportPlin.TabIndex = 12;
            this.btn_ExportPlin.Text = "Export";
            this.btn_ExportPlin.UseVisualStyleBackColor = false;
            this.btn_ExportPlin.Click += new System.EventHandler(this.Btn_ExportPlin_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(589, 7);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 19;
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
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(14, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Moje Režije";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_sPlin);
            this.panel1.Controls.Add(this.btn_pVoda);
            this.panel1.Controls.Add(this.btn_pStruja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 30;
            // 
            // btn_sPlin
            // 
            this.btn_sPlin.FlatAppearance.BorderSize = 0;
            this.btn_sPlin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sPlin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sPlin.ForeColor = System.Drawing.Color.White;
            this.btn_sPlin.Image = global::MojeRezije.Properties.Resources.stove32;
            this.btn_sPlin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sPlin.Location = new System.Drawing.Point(3, 221);
            this.btn_sPlin.Name = "btn_sPlin";
            this.btn_sPlin.Size = new System.Drawing.Size(144, 68);
            this.btn_sPlin.TabIndex = 15;
            this.btn_sPlin.Text = "Plin";
            this.btn_sPlin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sPlin.UseVisualStyleBackColor = true;
            // 
            // btn_pVoda
            // 
            this.btn_pVoda.FlatAppearance.BorderSize = 0;
            this.btn_pVoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pVoda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pVoda.ForeColor = System.Drawing.Color.White;
            this.btn_pVoda.Image = global::MojeRezije.Properties.Resources.tap32;
            this.btn_pVoda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pVoda.Location = new System.Drawing.Point(3, 85);
            this.btn_pVoda.Name = "btn_pVoda";
            this.btn_pVoda.Size = new System.Drawing.Size(144, 68);
            this.btn_pVoda.TabIndex = 14;
            this.btn_pVoda.Text = "Voda";
            this.btn_pVoda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pVoda.UseVisualStyleBackColor = true;
            this.btn_pVoda.Click += new System.EventHandler(this.Btn_pVoda_Click);
            // 
            // btn_pStruja
            // 
            this.btn_pStruja.FlatAppearance.BorderSize = 0;
            this.btn_pStruja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pStruja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pStruja.ForeColor = System.Drawing.Color.White;
            this.btn_pStruja.Image = global::MojeRezije.Properties.Resources.struja32;
            this.btn_pStruja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pStruja.Location = new System.Drawing.Point(3, 153);
            this.btn_pStruja.Name = "btn_pStruja";
            this.btn_pStruja.Size = new System.Drawing.Size(144, 68);
            this.btn_pStruja.TabIndex = 14;
            this.btn_pStruja.Text = "Struja";
            this.btn_pStruja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pStruja.UseVisualStyleBackColor = true;
            this.btn_pStruja.Click += new System.EventHandler(this.Btn_pStruja_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(153, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 68);
            this.panel2.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(330, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Računanje plina";
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
            this.btn_Spremi.TabIndex = 33;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = false;
            this.btn_Spremi.Click += new System.EventHandler(this.Btn_Spremi_Click);
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
            this.cb_Godina.TabIndex = 35;
            // 
            // cb_PMjesec
            // 
            this.cb_PMjesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PMjesec.FormattingEnabled = true;
            this.cb_PMjesec.Items.AddRange(new object[] {
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
            this.cb_PMjesec.Location = new System.Drawing.Point(543, 221);
            this.cb_PMjesec.Name = "cb_PMjesec";
            this.cb_PMjesec.Size = new System.Drawing.Size(65, 21);
            this.cb_PMjesec.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(488, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Godina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(552, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mjesec";
            // 
            // RacunanjePlin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_PMjesec);
            this.Controls.Add(this.cb_Godina);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ExportPlin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TM);
            this.Controls.Add(this.lbl_Pizracunaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Prazlika);
            this.Controls.Add(this.tb_Plin2);
            this.Controls.Add(this.tb_Plin1);
            this.Controls.Add(this.btn_Podustani);
            this.Controls.Add(this.btn_Pizracunaj);
            this.Controls.Add(this.cb_Tarifa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RacunanjePlin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RacunanjePlin";
            this.Load += new System.EventHandler(this.RacunanjePlin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Tarifa;
        private System.Windows.Forms.Button btn_Pizracunaj;
        private System.Windows.Forms.Button btn_Podustani;
        private System.Windows.Forms.TextBox tb_Plin1;
        private System.Windows.Forms.TextBox tb_Plin2;
        private System.Windows.Forms.TextBox tb_Prazlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Pizracunaj;
        private System.Windows.Forms.ComboBox cb_TM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ExportPlin;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sPlin;
        private System.Windows.Forms.Button btn_pVoda;
        private System.Windows.Forms.Button btn_pStruja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.ComboBox cb_Godina;
        private System.Windows.Forms.ComboBox cb_PMjesec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}