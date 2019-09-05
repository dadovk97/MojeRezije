namespace MojeRezije
{
    partial class AdminPage
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_Odjava = new System.Windows.Forms.Button();
            this.GridRecenzija = new System.Windows.Forms.DataGridView();
            this.lbl_Pros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRecenzija)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Graf
            // 
            this.Graf.BackColor = System.Drawing.Color.Transparent;
            this.Graf.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            chartArea1.Name = "ChartArea1";
            this.Graf.ChartAreas.Add(chartArea1);
            this.bunifuTransition1.SetDecoration(this.Graf, BunifuAnimatorNS.DecorationType.None);
            legend1.Name = "Legend1";
            this.Graf.Legends.Add(legend1);
            this.Graf.Location = new System.Drawing.Point(13, 58);
            this.Graf.Margin = new System.Windows.Forms.Padding(4);
            this.Graf.Name = "Graf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Graf.Series.Add(series1);
            this.Graf.Size = new System.Drawing.Size(294, 161);
            this.Graf.TabIndex = 44;
            this.Graf.Text = "chart1";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.bunifuTransition1.SetDecoration(this.btn_exit, BunifuAnimatorNS.DecorationType.None);
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(618, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 45;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.bunifuTransition1.SetDecoration(this.btn_min, BunifuAnimatorNS.DecorationType.None);
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(589, 7);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 46;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // btn_Odjava
            // 
            this.btn_Odjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.bunifuTransition1.SetDecoration(this.btn_Odjava, BunifuAnimatorNS.DecorationType.None);
            this.btn_Odjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odjava.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Odjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Odjava.Location = new System.Drawing.Point(12, 355);
            this.btn_Odjava.Name = "btn_Odjava";
            this.btn_Odjava.Size = new System.Drawing.Size(104, 33);
            this.btn_Odjava.TabIndex = 47;
            this.btn_Odjava.Text = "Odjava";
            this.btn_Odjava.UseVisualStyleBackColor = false;
            this.btn_Odjava.Click += new System.EventHandler(this.Btn_Odjava_Click);
            // 
            // GridRecenzija
            // 
            this.GridRecenzija.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GridRecenzija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.GridRecenzija, BunifuAnimatorNS.DecorationType.None);
            this.GridRecenzija.Location = new System.Drawing.Point(314, 60);
            this.GridRecenzija.Name = "GridRecenzija";
            this.GridRecenzija.Size = new System.Drawing.Size(298, 315);
            this.GridRecenzija.TabIndex = 48;
            // 
            // lbl_Pros
            // 
            this.lbl_Pros.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Pros, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Pros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pros.ForeColor = System.Drawing.Color.White;
            this.lbl_Pros.Location = new System.Drawing.Point(21, 245);
            this.lbl_Pros.Name = "lbl_Pros";
            this.lbl_Pros.Size = new System.Drawing.Size(121, 17);
            this.lbl_Pros.TabIndex = 49;
            this.lbl_Pros.Text = "Prosječna Ocjena";
            this.lbl_Pros.Visible = false;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.lbl_Pros);
            this.Controls.Add(this.GridRecenzija);
            this.Controls.Add(this.btn_Odjava);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Graf);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRecenzija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graf;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_Odjava;
        private System.Windows.Forms.DataGridView GridRecenzija;
        private System.Windows.Forms.Label lbl_Pros;
    }
}