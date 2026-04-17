namespace SportElemzes
{
    partial class SportoloFelvitelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportoloFelvitelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSzuletesiDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoszt = new System.Windows.Forms.TextBox();
            this.chkAktiv = new System.Windows.Forms.CheckBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(350, 138);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(140, 20);
            this.txtNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Születési Dátum";
            // 
            // dtpSzuletesiDatum
            // 
            this.dtpSzuletesiDatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpSzuletesiDatum.Location = new System.Drawing.Point(350, 181);
            this.dtpSzuletesiDatum.Name = "dtpSzuletesiDatum";
            this.dtpSzuletesiDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpSzuletesiDatum.TabIndex = 3;
            this.dtpSzuletesiDatum.ValueChanged += new System.EventHandler(this.dtpSzuletesiDatum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Poszt";
            // 
            // txtPoszt
            // 
            this.txtPoszt.Location = new System.Drawing.Point(350, 227);
            this.txtPoszt.Name = "txtPoszt";
            this.txtPoszt.Size = new System.Drawing.Size(100, 20);
            this.txtPoszt.TabIndex = 5;
            // 
            // chkAktiv
            // 
            this.chkAktiv.AutoCheck = false;
            this.chkAktiv.AutoSize = true;
            this.chkAktiv.BackColor = System.Drawing.Color.RoyalBlue;
            this.chkAktiv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAktiv.Checked = true;
            this.chkAktiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkAktiv.ForeColor = System.Drawing.Color.White;
            this.chkAktiv.Location = new System.Drawing.Point(369, 275);
            this.chkAktiv.Name = "chkAktiv";
            this.chkAktiv.Size = new System.Drawing.Size(62, 24);
            this.chkAktiv.TabIndex = 6;
            this.chkAktiv.Text = "Aktív";
            this.chkAktiv.UseVisualStyleBackColor = false;
            this.chkAktiv.CheckedChanged += new System.EventHandler(this.chkAktiv_CheckedChanged);
            // 
            // btnMentes
            // 
            this.btnMentes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMentes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMentes.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.ForeColor = System.Drawing.Color.White;
            this.btnMentes.Location = new System.Drawing.Point(363, 326);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 36);
            this.btnMentes.TabIndex = 7;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = false;
            // 
            // btnMegse
            // 
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(363, 368);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 36);
            this.btnMegse.TabIndex = 8;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = false;
            this.btnMegse.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "ÚJ SPORTOLÓ FELVITELE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBezar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBezar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBezar.ForeColor = System.Drawing.Color.White;
            this.btnBezar.Location = new System.Drawing.Point(776, -1);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(25, 25);
            this.btnBezar.TabIndex = 13;
            this.btnBezar.Text = "X";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // SportoloFelvitelForm
            // 
            this.AcceptButton = this.btnMentes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnMegse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.chkAktiv);
            this.Controls.Add(this.txtPoszt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSzuletesiDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SportoloFelvitelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Új Sportoló felvitele";
            this.Load += new System.EventHandler(this.SportoloFelvitelForm_Load);
            this.Click += new System.EventHandler(this.btnMentes_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSzuletesiDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoszt;
        private System.Windows.Forms.CheckBox chkAktiv;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBezar;
    }
}