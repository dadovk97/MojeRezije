namespace MojeRezije
{
    partial class Recenzija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recenzija));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.bunifu = new Bunifu.Framework.UI.BunifuRating();
            this.tb_Recenzija = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(618, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 15;
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
            this.btn_min.TabIndex = 16;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // bunifu
            // 
            this.bunifu.BackColor = System.Drawing.Color.Transparent;
            this.bunifu.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifu.Location = new System.Drawing.Point(166, 92);
            this.bunifu.Name = "bunifu";
            this.bunifu.Size = new System.Drawing.Size(316, 50);
            this.bunifu.TabIndex = 17;
            this.bunifu.Value = 0;
            // 
            // tb_Recenzija
            // 
            this.tb_Recenzija.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_Recenzija.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Recenzija.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_Recenzija.BorderThickness = 3;
            this.tb_Recenzija.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Recenzija.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Recenzija.ForeColor = System.Drawing.Color.White;
            this.tb_Recenzija.isPassword = false;
            this.tb_Recenzija.Location = new System.Drawing.Point(138, 160);
            this.tb_Recenzija.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Recenzija.Name = "tb_Recenzija";
            this.tb_Recenzija.Size = new System.Drawing.Size(370, 147);
            this.tb_Recenzija.TabIndex = 19;
            this.tb_Recenzija.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ocijenite aplikaciju";
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Spremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spremi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Spremi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Spremi.Location = new System.Drawing.Point(511, 346);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(117, 33);
            this.btn_Spremi.TabIndex = 21;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = false;
            this.btn_Spremi.Click += new System.EventHandler(this.Btn_Spremi_Click);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Nazad.Location = new System.Drawing.Point(12, 8);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(48, 33);
            this.btn_Nazad.TabIndex = 22;
            this.btn_Nazad.Text = "<-";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.Btn_Nazad_Click);
            // 
            // Recenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Recenzija);
            this.Controls.Add(this.bunifu);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recenzija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recenzija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private Bunifu.Framework.UI.BunifuRating bunifu;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_Recenzija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.Button btn_Nazad;
    }
}