namespace SportElemzes
{
    partial class EdzesGrafikonForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbSportolo = new System.Windows.Forms.ComboBox();
            this.dtpTol = new System.Windows.Forms.DateTimePicker();
            this.dtpIg = new System.Windows.Forms.DateTimePicker();
            this.btnFrissit = new System.Windows.Forms.Button();
            this.chtTerheles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMegse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtTerheles)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSportolo
            // 
            this.cmbSportolo.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbSportolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSportolo.FormattingEnabled = true;
            this.cmbSportolo.Location = new System.Drawing.Point(120, 164);
            this.cmbSportolo.Name = "cmbSportolo";
            this.cmbSportolo.Size = new System.Drawing.Size(200, 21);
            this.cmbSportolo.TabIndex = 0;
            // 
            // dtpTol
            // 
            this.dtpTol.Location = new System.Drawing.Point(120, 204);
            this.dtpTol.Name = "dtpTol";
            this.dtpTol.Size = new System.Drawing.Size(200, 20);
            this.dtpTol.TabIndex = 2;
            // 
            // dtpIg
            // 
            this.dtpIg.Location = new System.Drawing.Point(120, 241);
            this.dtpIg.Name = "dtpIg";
            this.dtpIg.Size = new System.Drawing.Size(200, 20);
            this.dtpIg.TabIndex = 3;
            // 
            // btnFrissit
            // 
            this.btnFrissit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFrissit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFrissit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrissit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrissit.ForeColor = System.Drawing.Color.White;
            this.btnFrissit.Location = new System.Drawing.Point(168, 279);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.Size = new System.Drawing.Size(100, 30);
            this.btnFrissit.TabIndex = 4;
            this.btnFrissit.Text = "Frissítés";
            this.btnFrissit.UseVisualStyleBackColor = false;
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);
            // 
            // chtTerheles
            // 
            this.chtTerheles.BackSecondaryColor = System.Drawing.Color.Black;
            this.chtTerheles.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chtTerheles.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtTerheles.Legends.Add(legend1);
            this.chtTerheles.Location = new System.Drawing.Point(356, 12);
            this.chtTerheles.Name = "chtTerheles";
            this.chtTerheles.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtTerheles.Series.Add(series1);
            this.chtTerheles.Size = new System.Drawing.Size(432, 426);
            this.chtTerheles.TabIndex = 5;
            this.chtTerheles.Text = "Terhelés";
            this.chtTerheles.Click += new System.EventHandler(this.chtTerheles_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(14, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Kezdő Dátum";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(14, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Záró Dátum";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMegse
            // 
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(168, 315);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(100, 33);
            this.btnMegse.TabIndex = 11;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = false;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "SportTeljesítmény Elemző Rendszer";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 108);
            this.label1.TabIndex = 19;
            this.label1.Text = "STER";
            // 
            // EdzesGrafikonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chtTerheles);
            this.Controls.Add(this.btnFrissit);
            this.Controls.Add(this.dtpIg);
            this.Controls.Add(this.dtpTol);
            this.Controls.Add(this.cmbSportolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdzesGrafikonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EdzesGrafikonForm";
            this.Load += new System.EventHandler(this.EdzesGrafikonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtTerheles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSportolo;
        private System.Windows.Forms.DateTimePicker dtpTol;
        private System.Windows.Forms.DateTimePicker dtpIg;
        private System.Windows.Forms.Button btnFrissit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTerheles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}