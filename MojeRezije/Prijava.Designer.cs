namespace MojeRezije
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Lozinka = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Reg = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Email.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_Email.Location = new System.Drawing.Point(255, 132);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(150, 21);
            this.tb_Email.TabIndex = 0;
            // 
            // tb_Lozinka
            // 
            this.tb_Lozinka.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Lozinka.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tb_Lozinka.Location = new System.Drawing.Point(255, 178);
            this.tb_Lozinka.Name = "tb_Lozinka";
            this.tb_Lozinka.PasswordChar = '*';
            this.tb_Lozinka.Size = new System.Drawing.Size(150, 21);
            this.tb_Lozinka.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btn_Login.Location = new System.Drawing.Point(290, 229);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Prijavi se";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // lbl_Reg
            // 
            this.lbl_Reg.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Reg.AutoSize = true;
            this.lbl_Reg.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbl_Reg.ForeColor = System.Drawing.Color.White;
            this.lbl_Reg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Reg.Location = new System.Drawing.Point(264, 294);
            this.lbl_Reg.Name = "lbl_Reg";
            this.lbl_Reg.Size = new System.Drawing.Size(141, 16);
            this.lbl_Reg.TabIndex = 6;
            this.lbl_Reg.TabStop = true;
            this.lbl_Reg.Text = "Nemate korisnički račun?";
            this.lbl_Reg.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_Reg_LinkClicked);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(618, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(589, 7);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 10;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(219, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Moje Režije";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(132, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 170);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.pictureBox1.Image = global::MojeRezije.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(93, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.pictureBox2.Image = global::MojeRezije.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(93, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.lbl_Reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Lozinka);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Lozinka;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel lbl_Reg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}