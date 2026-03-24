namespace SportElemzes
{
    partial class EdzesForm
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
            this.lblCim = new System.Windows.Forms.Label();
            this.lblSportoloFelirat = new System.Windows.Forms.Label();
            this.lblSportoloNev = new System.Windows.Forms.Label();
            this.dgvEdzesek = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtEdzestipus = new System.Windows.Forms.TextBox();
            this.numRpe = new System.Windows.Forms.NumericUpDown();
            this.numIdotartam = new System.Windows.Forms.NumericUpDown();
            this.btnHozzaadas = new System.Windows.Forms.Button();
            this.btnEdzesTorles = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdzesek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdotartam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.BackColor = System.Drawing.Color.Transparent;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(341, 159);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(120, 40);
            this.lblCim.TabIndex = 0;
            this.lblCim.Text = "Edzések";
            // 
            // lblSportoloFelirat
            // 
            this.lblSportoloFelirat.AutoSize = true;
            this.lblSportoloFelirat.BackColor = System.Drawing.Color.Transparent;
            this.lblSportoloFelirat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSportoloFelirat.ForeColor = System.Drawing.Color.White;
            this.lblSportoloFelirat.Location = new System.Drawing.Point(253, 244);
            this.lblSportoloFelirat.Name = "lblSportoloFelirat";
            this.lblSportoloFelirat.Size = new System.Drawing.Size(73, 21);
            this.lblSportoloFelirat.TabIndex = 1;
            this.lblSportoloFelirat.Text = "Sportoló:";
            // 
            // lblSportoloNev
            // 
            this.lblSportoloNev.AutoSize = true;
            this.lblSportoloNev.BackColor = System.Drawing.Color.Transparent;
            this.lblSportoloNev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSportoloNev.ForeColor = System.Drawing.Color.White;
            this.lblSportoloNev.Location = new System.Drawing.Point(332, 244);
            this.lblSportoloNev.Name = "lblSportoloNev";
            this.lblSportoloNev.Size = new System.Drawing.Size(16, 21);
            this.lblSportoloNev.TabIndex = 2;
            this.lblSportoloNev.Text = "-";
            this.lblSportoloNev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvEdzesek
            // 
            this.dgvEdzesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEdzesek.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvEdzesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdzesek.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEdzesek.Location = new System.Drawing.Point(0, 0);
            this.dgvEdzesek.Name = "dgvEdzesek";
            this.dgvEdzesek.Size = new System.Drawing.Size(800, 143);
            this.dgvEdzesek.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edzés típusa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "RPE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Időtartam (perc):";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatum.Location = new System.Drawing.Point(335, 272);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 8;
            // 
            // txtEdzestipus
            // 
            this.txtEdzestipus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEdzestipus.Location = new System.Drawing.Point(335, 300);
            this.txtEdzestipus.Name = "txtEdzestipus";
            this.txtEdzestipus.Size = new System.Drawing.Size(100, 22);
            this.txtEdzestipus.TabIndex = 9;
            // 
            // numRpe
            // 
            this.numRpe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numRpe.Location = new System.Drawing.Point(334, 328);
            this.numRpe.Name = "numRpe";
            this.numRpe.Size = new System.Drawing.Size(120, 22);
            this.numRpe.TabIndex = 10;
            // 
            // numIdotartam
            // 
            this.numIdotartam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIdotartam.Location = new System.Drawing.Point(334, 359);
            this.numIdotartam.Name = "numIdotartam";
            this.numIdotartam.Size = new System.Drawing.Size(120, 22);
            this.numIdotartam.TabIndex = 11;
            // 
            // btnHozzaadas
            // 
            this.btnHozzaadas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHozzaadas.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnHozzaadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHozzaadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaadas.ForeColor = System.Drawing.Color.White;
            this.btnHozzaadas.Location = new System.Drawing.Point(173, 406);
            this.btnHozzaadas.Name = "btnHozzaadas";
            this.btnHozzaadas.Size = new System.Drawing.Size(140, 30);
            this.btnHozzaadas.TabIndex = 12;
            this.btnHozzaadas.Text = "Új edzés";
            this.btnHozzaadas.UseVisualStyleBackColor = false;
            this.btnHozzaadas.Click += new System.EventHandler(this.btnHozzaadas_Click);
            // 
            // btnEdzesTorles
            // 
            this.btnEdzesTorles.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdzesTorles.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnEdzesTorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdzesTorles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdzesTorles.ForeColor = System.Drawing.Color.White;
            this.btnEdzesTorles.Location = new System.Drawing.Point(330, 406);
            this.btnEdzesTorles.Name = "btnEdzesTorles";
            this.btnEdzesTorles.Size = new System.Drawing.Size(140, 30);
            this.btnEdzesTorles.TabIndex = 13;
            this.btnEdzesTorles.Text = "Edzés törlése";
            this.btnEdzesTorles.UseVisualStyleBackColor = false;
            this.btnEdzesTorles.Click += new System.EventHandler(this.btnEdzesTorles_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBezar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBezar.ForeColor = System.Drawing.Color.White;
            this.btnBezar.Location = new System.Drawing.Point(487, 406);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(140, 30);
            this.btnBezar.TabIndex = 14;
            this.btnBezar.Text = "Bezárás";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // EdzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnEdzesTorles);
            this.Controls.Add(this.btnHozzaadas);
            this.Controls.Add(this.numIdotartam);
            this.Controls.Add(this.numRpe);
            this.Controls.Add(this.txtEdzestipus);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEdzesek);
            this.Controls.Add(this.lblSportoloNev);
            this.Controls.Add(this.lblSportoloFelirat);
            this.Controls.Add(this.lblCim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdzesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edzések";
            this.Load += new System.EventHandler(this.EdzesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdzesek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdotartam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblSportoloFelirat;
        private System.Windows.Forms.Label lblSportoloNev;
        private System.Windows.Forms.DataGridView dgvEdzesek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtEdzestipus;
        private System.Windows.Forms.NumericUpDown numRpe;
        private System.Windows.Forms.NumericUpDown numIdotartam;
        private System.Windows.Forms.Button btnHozzaadas;
        private System.Windows.Forms.Button btnEdzesTorles;
        private System.Windows.Forms.Button btnBezar;
    }
}