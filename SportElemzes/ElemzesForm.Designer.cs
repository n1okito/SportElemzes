namespace SportElemzes
{
    partial class ElemzesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElemzesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAkut = new System.Windows.Forms.Label();
            this.lblKronikus = new System.Windows.Forms.Label();
            this.lblAcwr = new System.Windows.Forms.Label();
            this.cmbSportolo = new System.Windows.Forms.ComboBox();
            this.dtpReferenciaDatum = new System.Windows.Forms.DateTimePicker();
            this.btnSzamitas = new System.Windows.Forms.Button();
            this.txtErtekeles = new System.Windows.Forms.TextBox();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sportoló:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Referencia Dátum:";
            // 
            // lblAkut
            // 
            this.lblAkut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAkut.AutoSize = true;
            this.lblAkut.BackColor = System.Drawing.Color.Transparent;
            this.lblAkut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAkut.ForeColor = System.Drawing.Color.White;
            this.lblAkut.Location = new System.Drawing.Point(231, 142);
            this.lblAkut.Name = "lblAkut";
            this.lblAkut.Size = new System.Drawing.Size(105, 21);
            this.lblAkut.TabIndex = 2;
            this.lblAkut.Text = "Akut Terhelés:";
            // 
            // lblKronikus
            // 
            this.lblKronikus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKronikus.AutoSize = true;
            this.lblKronikus.BackColor = System.Drawing.Color.Transparent;
            this.lblKronikus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKronikus.ForeColor = System.Drawing.Color.White;
            this.lblKronikus.Location = new System.Drawing.Point(193, 179);
            this.lblKronikus.Name = "lblKronikus";
            this.lblKronikus.Size = new System.Drawing.Size(143, 21);
            this.lblKronikus.TabIndex = 3;
            this.lblKronikus.Text = "Krónikus terhelés: -";
            // 
            // lblAcwr
            // 
            this.lblAcwr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcwr.AutoSize = true;
            this.lblAcwr.BackColor = System.Drawing.Color.Transparent;
            this.lblAcwr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAcwr.ForeColor = System.Drawing.Color.White;
            this.lblAcwr.Location = new System.Drawing.Point(268, 213);
            this.lblAcwr.Name = "lblAcwr";
            this.lblAcwr.Size = new System.Drawing.Size(68, 21);
            this.lblAcwr.TabIndex = 4;
            this.lblAcwr.Text = "ACWR: -";
            // 
            // cmbSportolo
            // 
            this.cmbSportolo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSportolo.FormattingEnabled = true;
            this.cmbSportolo.Location = new System.Drawing.Point(342, 62);
            this.cmbSportolo.Name = "cmbSportolo";
            this.cmbSportolo.Size = new System.Drawing.Size(121, 21);
            this.cmbSportolo.TabIndex = 5;
            // 
            // dtpReferenciaDatum
            // 
            this.dtpReferenciaDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReferenciaDatum.Location = new System.Drawing.Point(342, 102);
            this.dtpReferenciaDatum.Name = "dtpReferenciaDatum";
            this.dtpReferenciaDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpReferenciaDatum.TabIndex = 6;
            // 
            // btnSzamitas
            // 
            this.btnSzamitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSzamitas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSzamitas.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSzamitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzamitas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzamitas.ForeColor = System.Drawing.Color.White;
            this.btnSzamitas.Location = new System.Drawing.Point(350, 358);
            this.btnSzamitas.Name = "btnSzamitas";
            this.btnSzamitas.Size = new System.Drawing.Size(100, 35);
            this.btnSzamitas.TabIndex = 8;
            this.btnSzamitas.Text = "Számítás";
            this.btnSzamitas.UseVisualStyleBackColor = false;
            this.btnSzamitas.Click += new System.EventHandler(this.btnSzamitas_Click);
            // 
            // txtErtekeles
            // 
            this.txtErtekeles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErtekeles.Location = new System.Drawing.Point(250, 260);
            this.txtErtekeles.Multiline = true;
            this.txtErtekeles.Name = "txtErtekeles";
            this.txtErtekeles.ReadOnly = true;
            this.txtErtekeles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErtekeles.Size = new System.Drawing.Size(300, 50);
            this.txtErtekeles.TabIndex = 9;
            this.txtErtekeles.TextChanged += new System.EventHandler(this.txtErtekeles_TextChanged);
            // 
            // btnMegse
            // 
            this.btnMegse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(350, 399);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(100, 35);
            this.btnMegse.TabIndex = 10;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = false;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBezar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBezar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBezar.ForeColor = System.Drawing.Color.White;
            this.btnBezar.Location = new System.Drawing.Point(775, 0);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(25, 25);
            this.btnBezar.TabIndex = 11;
            this.btnBezar.Text = "X";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // ElemzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.txtErtekeles);
            this.Controls.Add(this.btnSzamitas);
            this.Controls.Add(this.dtpReferenciaDatum);
            this.Controls.Add(this.cmbSportolo);
            this.Controls.Add(this.lblAcwr);
            this.Controls.Add(this.lblKronikus);
            this.Controls.Add(this.lblAkut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElemzesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elemzés";
            this.Load += new System.EventHandler(this.ElemzesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAkut;
        private System.Windows.Forms.Label lblKronikus;
        private System.Windows.Forms.Label lblAcwr;
        private System.Windows.Forms.ComboBox cmbSportolo;
        private System.Windows.Forms.DateTimePicker dtpReferenciaDatum;
        private System.Windows.Forms.Button btnSzamitas;
        private System.Windows.Forms.TextBox txtErtekeles;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnBezar;
    }
}