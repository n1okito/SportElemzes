namespace SportElemzes
{
    partial class WellnessElemzesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnFrissit = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTol = new System.Windows.Forms.DateTimePicker();
            this.dtpIg = new System.Windows.Forms.DateTimePicker();
            this.chtWellness = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbSportolo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtWellness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrissit
            // 
            this.btnFrissit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFrissit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFrissit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrissit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrissit.ForeColor = System.Drawing.Color.White;
            this.btnFrissit.Location = new System.Drawing.Point(86, 302);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.Size = new System.Drawing.Size(100, 30);
            this.btnFrissit.TabIndex = 3;
            this.btnFrissit.Text = "Frissítés";
            this.btnFrissit.UseVisualStyleBackColor = false;
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(207, 302);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(100, 30);
            this.btnMegse.TabIndex = 4;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = false;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wellness adatok";
            // 
            // dtpTol
            // 
            this.dtpTol.Location = new System.Drawing.Point(97, 193);
            this.dtpTol.Name = "dtpTol";
            this.dtpTol.Size = new System.Drawing.Size(200, 20);
            this.dtpTol.TabIndex = 9;
            // 
            // dtpIg
            // 
            this.dtpIg.Location = new System.Drawing.Point(97, 236);
            this.dtpIg.Name = "dtpIg";
            this.dtpIg.Size = new System.Drawing.Size(200, 20);
            this.dtpIg.TabIndex = 10;
            // 
            // chtWellness
            // 
            this.chtWellness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.chtWellness.ChartAreas.Add(chartArea2);
            this.chtWellness.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chtWellness.Legends.Add(legend2);
            this.chtWellness.Location = new System.Drawing.Point(389, 0);
            this.chtWellness.Name = "chtWellness";
            this.chtWellness.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtWellness.Series.Add(series2);
            this.chtWellness.Size = new System.Drawing.Size(411, 450);
            this.chtWellness.TabIndex = 11;
            // 
            // cmbSportolo
            // 
            this.cmbSportolo.FormattingEnabled = true;
            this.cmbSportolo.Location = new System.Drawing.Point(139, 148);
            this.cmbSportolo.Name = "cmbSportolo";
            this.cmbSportolo.Size = new System.Drawing.Size(121, 21);
            this.cmbSportolo.TabIndex = 12;
            // 
            // WellnessElemzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSportolo);
            this.Controls.Add(this.chtWellness);
            this.Controls.Add(this.dtpIg);
            this.Controls.Add(this.dtpTol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnFrissit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WellnessElemzesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elemzés";
            this.Load += new System.EventHandler(this.WellnessElemzesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtWellness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrissit;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTol;
        private System.Windows.Forms.DateTimePicker dtpIg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWellness;
        private System.Windows.Forms.ComboBox cmbSportolo;
    }
}