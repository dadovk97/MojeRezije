namespace MojeRezije
{
    partial class Izbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izbornik));
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Ostalo = new System.Windows.Forms.Button();
            this.btn_Ispis = new System.Windows.Forms.Button();
            this.lbl_prijavljen = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Odjava = new System.Windows.Forms.Button();
            this.btn_Ocjena = new System.Windows.Forms.Button();
            this.btn_Plin = new System.Windows.Forms.Button();
            this.btn_Voda = new System.Windows.Forms.Button();
            this.btn_Struja = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(333, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 33);
            this.label11.TabIndex = 16;
            this.label11.Text = "Moje Režije";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_Ostalo);
            this.panel1.Controls.Add(this.btn_Ispis);
            this.panel1.Controls.Add(this.lbl_prijavljen);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_Odjava);
            this.panel1.Controls.Add(this.btn_Ocjena);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_Plin);
            this.panel1.Controls.Add(this.btn_Voda);
            this.panel1.Controls.Add(this.btn_Struja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 492);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btn_Ostalo
            // 
            this.btn_Ostalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ostalo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ostalo.ForeColor = System.Drawing.Color.White;
            this.btn_Ostalo.Image = global::MojeRezije.Properties.Resources.marketing;
            this.btn_Ostalo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ostalo.Location = new System.Drawing.Point(72, 252);
            this.btn_Ostalo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ostalo.Name = "btn_Ostalo";
            this.btn_Ostalo.Size = new System.Drawing.Size(200, 86);
            this.btn_Ostalo.TabIndex = 24;
            this.btn_Ostalo.Text = "Ostale režije";
            this.btn_Ostalo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ostalo.UseVisualStyleBackColor = true;
            this.btn_Ostalo.Click += new System.EventHandler(this.btn_Ostalo_Click);
            // 
            // btn_Ispis
            // 
            this.btn_Ispis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ispis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ispis.ForeColor = System.Drawing.Color.White;
            this.btn_Ispis.Image = global::MojeRezije.Properties.Resources.folder__1_;
            this.btn_Ispis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ispis.Location = new System.Drawing.Point(339, 252);
            this.btn_Ispis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ispis.Name = "btn_Ispis";
            this.btn_Ispis.Size = new System.Drawing.Size(200, 86);
            this.btn_Ispis.TabIndex = 23;
            this.btn_Ispis.Text = "Ispis";
            this.btn_Ispis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ispis.UseVisualStyleBackColor = true;
            this.btn_Ispis.Click += new System.EventHandler(this.Btn_Ispis_Click);
            // 
            // lbl_prijavljen
            // 
            this.lbl_prijavljen.AutoSize = true;
            this.lbl_prijavljen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prijavljen.ForeColor = System.Drawing.Color.White;
            this.lbl_prijavljen.Location = new System.Drawing.Point(16, 441);
            this.lbl_prijavljen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prijavljen.Name = "lbl_prijavljen";
            this.lbl_prijavljen.Size = new System.Drawing.Size(41, 21);
            this.lbl_prijavljen.TabIndex = 22;
            this.lbl_prijavljen.Text = "Ime";
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(785, 9);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(31, 28);
            this.btn_min.TabIndex = 21;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(824, 9);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 28);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_Odjava
            // 
            this.btn_Odjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Odjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odjava.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Odjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Odjava.Location = new System.Drawing.Point(725, 438);
            this.btn_Odjava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Odjava.Name = "btn_Odjava";
            this.btn_Odjava.Size = new System.Drawing.Size(100, 28);
            this.btn_Odjava.TabIndex = 19;
            this.btn_Odjava.Text = "Odjava";
            this.btn_Odjava.UseVisualStyleBackColor = false;
            this.btn_Odjava.Click += new System.EventHandler(this.Btn_Odjava_Click);
            // 
            // btn_Ocjena
            // 
            this.btn_Ocjena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ocjena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ocjena.ForeColor = System.Drawing.Color.White;
            this.btn_Ocjena.Image = global::MojeRezije.Properties.Resources.star32;
            this.btn_Ocjena.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ocjena.Location = new System.Drawing.Point(588, 252);
            this.btn_Ocjena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ocjena.Name = "btn_Ocjena";
            this.btn_Ocjena.Size = new System.Drawing.Size(200, 86);
            this.btn_Ocjena.TabIndex = 17;
            this.btn_Ocjena.Text = "Ocijeni aplikaciju";
            this.btn_Ocjena.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ocjena.UseVisualStyleBackColor = true;
            this.btn_Ocjena.Click += new System.EventHandler(this.Btn_Ocjena_Click);
            // 
            // btn_Plin
            // 
            this.btn_Plin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plin.ForeColor = System.Drawing.Color.White;
            this.btn_Plin.Image = global::MojeRezije.Properties.Resources.stove32;
            this.btn_Plin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Plin.Location = new System.Drawing.Point(588, 130);
            this.btn_Plin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Plin.Name = "btn_Plin";
            this.btn_Plin.Size = new System.Drawing.Size(200, 86);
            this.btn_Plin.TabIndex = 15;
            this.btn_Plin.Text = "Plin";
            this.btn_Plin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Plin.UseVisualStyleBackColor = true;
            this.btn_Plin.Click += new System.EventHandler(this.Btn_Plin_Click);
            // 
            // btn_Voda
            // 
            this.btn_Voda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voda.ForeColor = System.Drawing.Color.White;
            this.btn_Voda.Image = global::MojeRezije.Properties.Resources.tap32;
            this.btn_Voda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Voda.Location = new System.Drawing.Point(72, 130);
            this.btn_Voda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Voda.Name = "btn_Voda";
            this.btn_Voda.Size = new System.Drawing.Size(200, 86);
            this.btn_Voda.TabIndex = 14;
            this.btn_Voda.Text = "Voda";
            this.btn_Voda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Voda.UseVisualStyleBackColor = true;
            this.btn_Voda.Click += new System.EventHandler(this.Btn_Voda_Click);
            // 
            // btn_Struja
            // 
            this.btn_Struja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Struja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Struja.ForeColor = System.Drawing.Color.White;
            this.btn_Struja.Image = global::MojeRezije.Properties.Resources.struja32;
            this.btn_Struja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Struja.Location = new System.Drawing.Point(339, 130);
            this.btn_Struja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Struja.Name = "btn_Struja";
            this.btn_Struja.Size = new System.Drawing.Size(200, 86);
            this.btn_Struja.TabIndex = 14;
            this.btn_Struja.Text = "Struja";
            this.btn_Struja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Struja.UseVisualStyleBackColor = true;
            this.btn_Struja.Click += new System.EventHandler(this.Btn_Struja_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(867, 492);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Izbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Plin;
        private System.Windows.Forms.Button btn_Voda;
        private System.Windows.Forms.Button btn_Struja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ocjena;
        private System.Windows.Forms.Button btn_Odjava;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_prijavljen;
        private System.Windows.Forms.Button btn_Ispis;
        private System.Windows.Forms.Button btn_Ostalo;
    }
}