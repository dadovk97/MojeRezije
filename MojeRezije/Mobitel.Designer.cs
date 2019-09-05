namespace MojeRezije
{
    partial class Mobitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mobitel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Smece = new System.Windows.Forms.Button();
            this.btn_Internet = new System.Windows.Forms.Button();
            this.btn_Mobitel = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_ExportStruja = new System.Windows.Forms.Button();
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Odustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Internet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Cijena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_MMjesec = new System.Windows.Forms.ComboBox();
            this.cb_Godina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_Smece);
            this.panel1.Controls.Add(this.btn_Internet);
            this.panel1.Controls.Add(this.btn_Mobitel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 71;
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
            // btn_Smece
            // 
            this.btn_Smece.FlatAppearance.BorderSize = 0;
            this.btn_Smece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Smece.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Smece.ForeColor = System.Drawing.Color.White;
            this.btn_Smece.Image = global::MojeRezije.Properties.Resources.garbage;
            this.btn_Smece.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Smece.Location = new System.Drawing.Point(3, 221);
            this.btn_Smece.Name = "btn_Smece";
            this.btn_Smece.Size = new System.Drawing.Size(144, 68);
            this.btn_Smece.TabIndex = 15;
            this.btn_Smece.Text = "Smece";
            this.btn_Smece.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Smece.UseVisualStyleBackColor = true;
            this.btn_Smece.Click += new System.EventHandler(this.Btn_Smece_Click);
            // 
            // btn_Internet
            // 
            this.btn_Internet.FlatAppearance.BorderSize = 0;
            this.btn_Internet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Internet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Internet.ForeColor = System.Drawing.Color.White;
            this.btn_Internet.Image = global::MojeRezije.Properties.Resources.wifi;
            this.btn_Internet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Internet.Location = new System.Drawing.Point(3, 85);
            this.btn_Internet.Name = "btn_Internet";
            this.btn_Internet.Size = new System.Drawing.Size(144, 68);
            this.btn_Internet.TabIndex = 14;
            this.btn_Internet.Text = "Internet";
            this.btn_Internet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Internet.UseVisualStyleBackColor = true;
            this.btn_Internet.Click += new System.EventHandler(this.Btn_Internet_Click);
            // 
            // btn_Mobitel
            // 
            this.btn_Mobitel.FlatAppearance.BorderSize = 0;
            this.btn_Mobitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mobitel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mobitel.ForeColor = System.Drawing.Color.White;
            this.btn_Mobitel.Image = global::MojeRezije.Properties.Resources.smartphone;
            this.btn_Mobitel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Mobitel.Location = new System.Drawing.Point(3, 153);
            this.btn_Mobitel.Name = "btn_Mobitel";
            this.btn_Mobitel.Size = new System.Drawing.Size(144, 68);
            this.btn_Mobitel.TabIndex = 14;
            this.btn_Mobitel.Text = "Mobitel";
            this.btn_Mobitel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Mobitel.UseVisualStyleBackColor = true;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(589, 7);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 70;
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
            this.btn_exit.TabIndex = 69;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_ExportStruja
            // 
            this.btn_ExportStruja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_ExportStruja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportStruja.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_ExportStruja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ExportStruja.Location = new System.Drawing.Point(485, 356);
            this.btn_ExportStruja.Name = "btn_ExportStruja";
            this.btn_ExportStruja.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportStruja.TabIndex = 68;
            this.btn_ExportStruja.Text = "Export";
            this.btn_ExportStruja.UseVisualStyleBackColor = false;
            this.btn_ExportStruja.Click += new System.EventHandler(this.Btn_ExportStruja_Click);
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Spremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spremi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Spremi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Spremi.Location = new System.Drawing.Point(404, 356);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(75, 23);
            this.btn_Spremi.TabIndex = 75;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = false;
            this.btn_Spremi.Click += new System.EventHandler(this.Btn_Spremi_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(330, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 73;
            this.label12.Text = "Mobitel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(153, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 68);
            this.panel2.TabIndex = 72;
            // 
            // btn_Odustani
            // 
            this.btn_Odustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Odustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odustani.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Odustani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Odustani.Location = new System.Drawing.Point(566, 356);
            this.btn_Odustani.Name = "btn_Odustani";
            this.btn_Odustani.Size = new System.Drawing.Size(75, 23);
            this.btn_Odustani.TabIndex = 50;
            this.btn_Odustani.Text = "Izbornik";
            this.btn_Odustani.UseVisualStyleBackColor = false;
            this.btn_Odustani.Click += new System.EventHandler(this.Btn_Odustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Provider";
            // 
            // cb_Internet
            // 
            this.cb_Internet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Internet.FormattingEnabled = true;
            this.cb_Internet.Items.AddRange(new object[] {
            "Hrvatski Telekom",
            "A1 ",
            "BNET",
            "Optima"});
            this.cb_Internet.Location = new System.Drawing.Point(232, 200);
            this.cb_Internet.Name = "cb_Internet";
            this.cb_Internet.Size = new System.Drawing.Size(111, 21);
            this.cb_Internet.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cijena Racuna";
            // 
            // tb_Cijena
            // 
            this.tb_Cijena.Location = new System.Drawing.Point(232, 130);
            this.tb_Cijena.Name = "tb_Cijena";
            this.tb_Cijena.Size = new System.Drawing.Size(111, 20);
            this.tb_Cijena.TabIndex = 74;
            this.tb_Cijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Cijena_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(429, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Godina";
            // 
            // cb_MMjesec
            // 
            this.cb_MMjesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MMjesec.FormattingEnabled = true;
            this.cb_MMjesec.Items.AddRange(new object[] {
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
            this.cb_MMjesec.Location = new System.Drawing.Point(495, 129);
            this.cb_MMjesec.Name = "cb_MMjesec";
            this.cb_MMjesec.Size = new System.Drawing.Size(65, 21);
            this.cb_MMjesec.TabIndex = 71;
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
            this.cb_Godina.Location = new System.Drawing.Point(425, 130);
            this.cb_Godina.Name = "cb_Godina";
            this.cb_Godina.Size = new System.Drawing.Size(54, 21);
            this.cb_Godina.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(501, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Mjesec";
            // 
            // Mobitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Internet);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tb_Cijena);
            this.Controls.Add(this.btn_ExportStruja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.cb_MMjesec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_Godina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Odustani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mobitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobitel";
            this.Load += new System.EventHandler(this.Mobitel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Smece;
        private System.Windows.Forms.Button btn_Internet;
        private System.Windows.Forms.Button btn_Mobitel;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_ExportStruja;
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Odustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Internet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Cijena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_MMjesec;
        private System.Windows.Forms.ComboBox cb_Godina;
        private System.Windows.Forms.Label label7;
    }
}