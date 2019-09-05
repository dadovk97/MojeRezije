namespace MojeRezije
{
    partial class IspisPlina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IspisPlina));
            this.GridIspis = new System.Windows.Forms.DataGridView();
            this.btn_Obrisi = new System.Windows.Forms.Button();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sPlin = new System.Windows.Forms.Button();
            this.btn_vStruja = new System.Windows.Forms.Button();
            this.btn_Voda = new System.Windows.Forms.Button();
            this.cb_GodinaPlin = new System.Windows.Forms.ComboBox();
            this.lbl_Ispis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Smece = new System.Windows.Forms.Button();
            this.btn_Mobitel = new System.Windows.Forms.Button();
            this.btn_Internet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridIspis)).BeginInit();
            this.SuspendLayout();
            // 
            // GridIspis
            // 
            this.GridIspis.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.GridIspis.AllowUserToAddRows = false;
            this.GridIspis.AllowUserToDeleteRows = false;
            this.GridIspis.AllowUserToResizeColumns = false;
            this.GridIspis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridIspis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridIspis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridIspis.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridIspis.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridIspis.Location = new System.Drawing.Point(146, 207);
            this.GridIspis.Margin = new System.Windows.Forms.Padding(2);
            this.GridIspis.Name = "GridIspis";
            this.GridIspis.ReadOnly = true;
            this.GridIspis.RowTemplate.Height = 24;
            this.GridIspis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridIspis.Size = new System.Drawing.Size(505, 195);
            this.GridIspis.TabIndex = 67;
            // 
            // btn_Obrisi
            // 
            this.btn_Obrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Obrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Obrisi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Obrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Obrisi.Location = new System.Drawing.Point(1, 206);
            this.btn_Obrisi.Name = "btn_Obrisi";
            this.btn_Obrisi.Size = new System.Drawing.Size(117, 33);
            this.btn_Obrisi.TabIndex = 66;
            this.btn_Obrisi.Text = "Obrisi Izracun";
            this.btn_Obrisi.UseVisualStyleBackColor = false;
            this.btn_Obrisi.Click += new System.EventHandler(this.Btn_Obrisi_Click);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Nazad.Location = new System.Drawing.Point(11, 10);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(48, 33);
            this.btn_Nazad.TabIndex = 65;
            this.btn_Nazad.Text = "<-";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.Btn_Nazad_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(617, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 64;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(588, 9);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 63;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(240, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 3);
            this.panel2.TabIndex = 68;
            // 
            // btn_sPlin
            // 
            this.btn_sPlin.FlatAppearance.BorderSize = 0;
            this.btn_sPlin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sPlin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sPlin.ForeColor = System.Drawing.Color.White;
            this.btn_sPlin.Image = global::MojeRezije.Properties.Resources.stove32;
            this.btn_sPlin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sPlin.Location = new System.Drawing.Point(240, 49);
            this.btn_sPlin.Name = "btn_sPlin";
            this.btn_sPlin.Size = new System.Drawing.Size(90, 65);
            this.btn_sPlin.TabIndex = 62;
            this.btn_sPlin.Text = "Plin";
            this.btn_sPlin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sPlin.UseVisualStyleBackColor = true;
            // 
            // btn_vStruja
            // 
            this.btn_vStruja.FlatAppearance.BorderSize = 0;
            this.btn_vStruja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vStruja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vStruja.ForeColor = System.Drawing.Color.White;
            this.btn_vStruja.Image = global::MojeRezije.Properties.Resources.struja32;
            this.btn_vStruja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vStruja.Location = new System.Drawing.Point(142, 49);
            this.btn_vStruja.Name = "btn_vStruja";
            this.btn_vStruja.Size = new System.Drawing.Size(90, 65);
            this.btn_vStruja.TabIndex = 61;
            this.btn_vStruja.Text = "Struja";
            this.btn_vStruja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vStruja.UseVisualStyleBackColor = true;
            this.btn_vStruja.Click += new System.EventHandler(this.Btn_vStruja_Click);
            // 
            // btn_Voda
            // 
            this.btn_Voda.FlatAppearance.BorderSize = 0;
            this.btn_Voda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voda.ForeColor = System.Drawing.Color.White;
            this.btn_Voda.Image = global::MojeRezije.Properties.Resources.tap32;
            this.btn_Voda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Voda.Location = new System.Drawing.Point(44, 49);
            this.btn_Voda.Name = "btn_Voda";
            this.btn_Voda.Size = new System.Drawing.Size(90, 65);
            this.btn_Voda.TabIndex = 60;
            this.btn_Voda.Text = "Voda";
            this.btn_Voda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Voda.UseVisualStyleBackColor = true;
            this.btn_Voda.Click += new System.EventHandler(this.Btn_Voda_Click);
            // 
            // cb_GodinaPlin
            // 
            this.cb_GodinaPlin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GodinaPlin.FormattingEnabled = true;
            this.cb_GodinaPlin.Items.AddRange(new object[] {
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
            this.cb_GodinaPlin.Location = new System.Drawing.Point(1, 149);
            this.cb_GodinaPlin.Name = "cb_GodinaPlin";
            this.cb_GodinaPlin.Size = new System.Drawing.Size(64, 21);
            this.cb_GodinaPlin.TabIndex = 69;
            this.cb_GodinaPlin.SelectedIndexChanged += new System.EventHandler(this.Cb_GodinaPlin_SelectedIndexChanged);
            // 
            // lbl_Ispis
            // 
            this.lbl_Ispis.AutoSize = true;
            this.lbl_Ispis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ispis.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Ispis.Location = new System.Drawing.Point(91, 149);
            this.lbl_Ispis.Name = "lbl_Ispis";
            this.lbl_Ispis.Size = new System.Drawing.Size(62, 20);
            this.lbl_Ispis.TabIndex = 70;
            this.lbl_Ispis.Text = "Izracun";
            this.lbl_Ispis.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Godisnji izracun";
            // 
            // btn_Smece
            // 
            this.btn_Smece.FlatAppearance.BorderSize = 0;
            this.btn_Smece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Smece.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Smece.ForeColor = System.Drawing.Color.White;
            this.btn_Smece.Image = global::MojeRezije.Properties.Resources.garbage;
            this.btn_Smece.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Smece.Location = new System.Drawing.Point(528, 49);
            this.btn_Smece.Name = "btn_Smece";
            this.btn_Smece.Size = new System.Drawing.Size(90, 65);
            this.btn_Smece.TabIndex = 117;
            this.btn_Smece.Text = "Smece";
            this.btn_Smece.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Smece.UseVisualStyleBackColor = true;
            this.btn_Smece.Click += new System.EventHandler(this.Btn_Smece_Click);
            // 
            // btn_Mobitel
            // 
            this.btn_Mobitel.FlatAppearance.BorderSize = 0;
            this.btn_Mobitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mobitel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mobitel.ForeColor = System.Drawing.Color.White;
            this.btn_Mobitel.Image = global::MojeRezije.Properties.Resources.smartphone;
            this.btn_Mobitel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Mobitel.Location = new System.Drawing.Point(432, 49);
            this.btn_Mobitel.Name = "btn_Mobitel";
            this.btn_Mobitel.Size = new System.Drawing.Size(90, 65);
            this.btn_Mobitel.TabIndex = 116;
            this.btn_Mobitel.Text = "Mobitel";
            this.btn_Mobitel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Mobitel.UseVisualStyleBackColor = true;
            this.btn_Mobitel.Click += new System.EventHandler(this.Btn_Mobitel_Click);
            // 
            // btn_Internet
            // 
            this.btn_Internet.FlatAppearance.BorderSize = 0;
            this.btn_Internet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Internet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Internet.ForeColor = System.Drawing.Color.White;
            this.btn_Internet.Image = global::MojeRezije.Properties.Resources.wifi;
            this.btn_Internet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Internet.Location = new System.Drawing.Point(336, 49);
            this.btn_Internet.Name = "btn_Internet";
            this.btn_Internet.Size = new System.Drawing.Size(90, 65);
            this.btn_Internet.TabIndex = 115;
            this.btn_Internet.Text = "Internet";
            this.btn_Internet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Internet.UseVisualStyleBackColor = true;
            this.btn_Internet.Click += new System.EventHandler(this.Btn_Internet_Click);
            // 
            // IspisPlina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.btn_Smece);
            this.Controls.Add(this.btn_Mobitel);
            this.Controls.Add(this.btn_Internet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Ispis);
            this.Controls.Add(this.cb_GodinaPlin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GridIspis);
            this.Controls.Add(this.btn_Obrisi);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_sPlin);
            this.Controls.Add(this.btn_vStruja);
            this.Controls.Add(this.btn_Voda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IspisPlina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IspisPlina";
            this.Load += new System.EventHandler(this.IspisPlina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridIspis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridIspis;
        private System.Windows.Forms.Button btn_Obrisi;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_sPlin;
        private System.Windows.Forms.Button btn_vStruja;
        private System.Windows.Forms.Button btn_Voda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_GodinaPlin;
        private System.Windows.Forms.Label lbl_Ispis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Smece;
        private System.Windows.Forms.Button btn_Mobitel;
        private System.Windows.Forms.Button btn_Internet;
    }
}