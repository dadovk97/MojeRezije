namespace MojeRezije.messagebox
{
    partial class EmailPostoji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailPostoji));
            this.btn_Uredu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Uredu
            // 
            this.btn_Uredu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Uredu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Uredu.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btn_Uredu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_Uredu.Location = new System.Drawing.Point(109, 87);
            this.btn_Uredu.Name = "btn_Uredu";
            this.btn_Uredu.Size = new System.Drawing.Size(91, 33);
            this.btn_Uredu.TabIndex = 23;
            this.btn_Uredu.Text = "U redu";
            this.btn_Uredu.UseVisualStyleBackColor = false;
            this.btn_Uredu.Click += new System.EventHandler(this.Btn_Uredu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(82, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email vec postoji!";
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(249, 9);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
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
            this.btn_exit.Location = new System.Drawing.Point(278, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // EmailPostoji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(314, 132);
            this.Controls.Add(this.btn_Uredu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailPostoji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailPostoji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Uredu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
    }
}