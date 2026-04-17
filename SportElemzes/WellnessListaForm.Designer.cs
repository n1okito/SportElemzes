namespace SportElemzes
{
    partial class WellnessListaForm
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
            this.btnFrissit = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.cmbSportolo = new System.Windows.Forms.ComboBox();
            this.dgvWellness = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWellness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrissit
            // 
            this.btnFrissit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFrissit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFrissit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrissit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrissit.ForeColor = System.Drawing.Color.White;
            this.btnFrissit.Location = new System.Drawing.Point(215, 113);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.Size = new System.Drawing.Size(130, 40);
            this.btnFrissit.TabIndex = 2;
            this.btnFrissit.Text = "Frissítés";
            this.btnFrissit.UseVisualStyleBackColor = false;
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(455, 113);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(130, 40);
            this.btnMegse.TabIndex = 4;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = false;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // cmbSportolo
            // 
            this.cmbSportolo.FormattingEnabled = true;
            this.cmbSportolo.Location = new System.Drawing.Point(294, 197);
            this.cmbSportolo.Name = "cmbSportolo";
            this.cmbSportolo.Size = new System.Drawing.Size(213, 21);
            this.cmbSportolo.TabIndex = 5;
            // 
            // dgvWellness
            // 
            this.dgvWellness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWellness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvWellness.Location = new System.Drawing.Point(0, 226);
            this.dgvWellness.Name = "dgvWellness";
            this.dgvWellness.Size = new System.Drawing.Size(800, 224);
            this.dgvWellness.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wellness adatok";
            // 
            // WellnessListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWellness);
            this.Controls.Add(this.cmbSportolo);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnFrissit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WellnessListaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WellnessListaForm";
            this.Load += new System.EventHandler(this.WellnessListaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWellness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrissit;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.ComboBox cmbSportolo;
        private System.Windows.Forms.DataGridView dgvWellness;
        private System.Windows.Forms.Label label1;
    }
}