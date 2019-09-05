namespace MojeRezije
{
    partial class Registracija
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registracija));
            this.tb_ImeReg = new System.Windows.Forms.TextBox();
            this.tb_PrezimeReg = new System.Windows.Forms.TextBox();
            this.tb_EmailReg = new System.Windows.Forms.TextBox();
            this.tb_LozinkaReg = new System.Windows.Forms.TextBox();
            this.Registriraj = new System.Windows.Forms.Button();
            this.btn_Odustani = new System.Windows.Forms.Button();
            this.tb_PotvrdaLoz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ImeReg
            // 
            this.tb_ImeReg.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_ImeReg.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_ImeReg.Location = new System.Drawing.Point(66, 37);
            this.tb_ImeReg.Name = "tb_ImeReg";
            this.tb_ImeReg.Size = new System.Drawing.Size(150, 21);
            this.tb_ImeReg.TabIndex = 0;
            // 
            // tb_PrezimeReg
            // 
            this.tb_PrezimeReg.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_PrezimeReg.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_PrezimeReg.Location = new System.Drawing.Point(66, 86);
            this.tb_PrezimeReg.Name = "tb_PrezimeReg";
            this.tb_PrezimeReg.Size = new System.Drawing.Size(150, 21);
            this.tb_PrezimeReg.TabIndex = 1;
            // 
            // tb_EmailReg
            // 
            this.tb_EmailReg.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_EmailReg.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_EmailReg.Location = new System.Drawing.Point(331, 37);
            this.tb_EmailReg.Name = "tb_EmailReg";
            this.tb_EmailReg.Size = new System.Drawing.Size(150, 21);
            this.tb_EmailReg.TabIndex = 2;
            this.tb_EmailReg.TextChanged += new System.EventHandler(this.Tb_EmailReg_TextChanged);
            this.tb_EmailReg.Leave += new System.EventHandler(this.Tb_EmailReg_Leave);
            // 
            // tb_LozinkaReg
            // 
            this.tb_LozinkaReg.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_LozinkaReg.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_LozinkaReg.Location = new System.Drawing.Point(331, 86);
            this.tb_LozinkaReg.Name = "tb_LozinkaReg";
            this.tb_LozinkaReg.PasswordChar = '*';
            this.tb_LozinkaReg.Size = new System.Drawing.Size(150, 21);
            this.tb_LozinkaReg.TabIndex = 3;
            // 
            // Registriraj
            // 
            this.Registriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Registriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registriraj.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Registriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Registriraj.Location = new System.Drawing.Point(181, 193);
            this.Registriraj.Name = "Registriraj";
            this.Registriraj.Size = new System.Drawing.Size(117, 33);
            this.Registriraj.TabIndex = 4;
            this.Registriraj.Text = "Registriraj se";
            this.Registriraj.UseVisualStyleBackColor = false;
            this.Registriraj.Click += new System.EventHandler(this.Registriraj_Click);
            // 
            // btn_Odustani
            // 
            this.btn_Odustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Odustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odustani.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Odustani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Odustani.Location = new System.Drawing.Point(431, 328);
            this.btn_Odustani.Name = "btn_Odustani";
            this.btn_Odustani.Size = new System.Drawing.Size(150, 23);
            this.btn_Odustani.TabIndex = 5;
            this.btn_Odustani.Text = "Imate korisnički račun?";
            this.btn_Odustani.UseVisualStyleBackColor = false;
            this.btn_Odustani.Click += new System.EventHandler(this.Btn_Odustani_Click);
            // 
            // tb_PotvrdaLoz
            // 
            this.tb_PotvrdaLoz.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_PotvrdaLoz.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_PotvrdaLoz.Location = new System.Drawing.Point(331, 134);
            this.tb_PotvrdaLoz.Name = "tb_PotvrdaLoz";
            this.tb_PotvrdaLoz.PasswordChar = '*';
            this.tb_PotvrdaLoz.Size = new System.Drawing.Size(150, 21);
            this.tb_PotvrdaLoz.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(286, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(275, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(231, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Potvrda Lozinke";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(210, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 44);
            this.label6.TabIndex = 12;
            this.label6.Text = "Moje Režije";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.tb_ImeReg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_PotvrdaLoz);
            this.panel1.Controls.Add(this.Registriraj);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_LozinkaReg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_EmailReg);
            this.panel1.Controls.Add(this.tb_PrezimeReg);
            this.panel1.Location = new System.Drawing.Point(73, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 245);
            this.panel1.TabIndex = 13;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(589, 7);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 15;
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
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Odustani);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ImeReg;
        private System.Windows.Forms.TextBox tb_PrezimeReg;
        private System.Windows.Forms.TextBox tb_EmailReg;
        private System.Windows.Forms.TextBox tb_LozinkaReg;
        private System.Windows.Forms.Button Registriraj;
        private System.Windows.Forms.Button btn_Odustani;
        private System.Windows.Forms.TextBox tb_PotvrdaLoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
    }
}

