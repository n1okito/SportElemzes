namespace SportElemzes
{
    partial class RegisztracioForm
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
            this.lblfelhasznalonev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.lblJelszoMegerosites = new System.Windows.Forms.Label();
            this.lblTeljesNev = new System.Windows.Forms.Label();
            this.txtFelhasznalonev = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.txtJelszoMegerosites = new System.Windows.Forms.TextBox();
            this.txtTeljesNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisztral = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfelhasznalonev
            // 
            this.lblfelhasznalonev.AutoSize = true;
            this.lblfelhasznalonev.BackColor = System.Drawing.Color.Transparent;
            this.lblfelhasznalonev.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblfelhasznalonev.ForeColor = System.Drawing.Color.White;
            this.lblfelhasznalonev.Location = new System.Drawing.Point(323, 78);
            this.lblfelhasznalonev.Name = "lblfelhasznalonev";
            this.lblfelhasznalonev.Size = new System.Drawing.Size(154, 30);
            this.lblfelhasznalonev.TabIndex = 0;
            this.lblfelhasznalonev.Text = "Felhasználónév";
            this.lblfelhasznalonev.Click += new System.EventHandler(this.lblfelhasznalonev_Click);
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.BackColor = System.Drawing.Color.Transparent;
            this.lblJelszo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJelszo.ForeColor = System.Drawing.Color.White;
            this.lblJelszo.Location = new System.Drawing.Point(366, 209);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(68, 30);
            this.lblJelszo.TabIndex = 1;
            this.lblJelszo.Text = "Jelszó";
            this.lblJelszo.Click += new System.EventHandler(this.lblJelszo_Click);
            // 
            // lblJelszoMegerosites
            // 
            this.lblJelszoMegerosites.AutoSize = true;
            this.lblJelszoMegerosites.BackColor = System.Drawing.Color.Transparent;
            this.lblJelszoMegerosites.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJelszoMegerosites.ForeColor = System.Drawing.Color.White;
            this.lblJelszoMegerosites.Location = new System.Drawing.Point(301, 278);
            this.lblJelszoMegerosites.Name = "lblJelszoMegerosites";
            this.lblJelszoMegerosites.Size = new System.Drawing.Size(198, 30);
            this.lblJelszoMegerosites.TabIndex = 2;
            this.lblJelszoMegerosites.Text = "Jelszó Megerősítése";
            this.lblJelszoMegerosites.Click += new System.EventHandler(this.lblJelszoMegerosites_Click);
            // 
            // lblTeljesNev
            // 
            this.lblTeljesNev.AutoSize = true;
            this.lblTeljesNev.BackColor = System.Drawing.Color.Transparent;
            this.lblTeljesNev.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeljesNev.ForeColor = System.Drawing.Color.White;
            this.lblTeljesNev.Location = new System.Drawing.Point(347, 141);
            this.lblTeljesNev.Name = "lblTeljesNev";
            this.lblTeljesNev.Size = new System.Drawing.Size(106, 30);
            this.lblTeljesNev.TabIndex = 3;
            this.lblTeljesNev.Text = "Teljes Név";
            this.lblTeljesNev.Click += new System.EventHandler(this.lblTeljesNev_Click);
            // 
            // txtFelhasznalonev
            // 
            this.txtFelhasznalonev.Location = new System.Drawing.Point(335, 111);
            this.txtFelhasznalonev.Name = "txtFelhasznalonev";
            this.txtFelhasznalonev.Size = new System.Drawing.Size(130, 20);
            this.txtFelhasznalonev.TabIndex = 4;
            // 
            // txtJelszo
            // 
            this.txtJelszo.Location = new System.Drawing.Point(310, 242);
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.PasswordChar = '*';
            this.txtJelszo.Size = new System.Drawing.Size(180, 20);
            this.txtJelszo.TabIndex = 6;
            this.txtJelszo.UseSystemPasswordChar = true;
            // 
            // txtJelszoMegerosites
            // 
            this.txtJelszoMegerosites.Location = new System.Drawing.Point(310, 311);
            this.txtJelszoMegerosites.Name = "txtJelszoMegerosites";
            this.txtJelszoMegerosites.PasswordChar = '*';
            this.txtJelszoMegerosites.Size = new System.Drawing.Size(180, 20);
            this.txtJelszoMegerosites.TabIndex = 7;
            this.txtJelszoMegerosites.UseSystemPasswordChar = true;
            // 
            // txtTeljesNev
            // 
            this.txtTeljesNev.Location = new System.Drawing.Point(310, 174);
            this.txtTeljesNev.Name = "txtTeljesNev";
            this.txtTeljesNev.Size = new System.Drawing.Size(180, 20);
            this.txtTeljesNev.TabIndex = 5;
            this.txtTeljesNev.TextChanged += new System.EventHandler(this.txtTeljesNev_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Regisztráció";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegisztral
            // 
            this.btnRegisztral.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegisztral.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegisztral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisztral.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegisztral.ForeColor = System.Drawing.Color.White;
            this.btnRegisztral.Location = new System.Drawing.Point(347, 353);
            this.btnRegisztral.Name = "btnRegisztral";
            this.btnRegisztral.Size = new System.Drawing.Size(106, 35);
            this.btnRegisztral.TabIndex = 9;
            this.btnRegisztral.Text = "Regisztrálás";
            this.btnRegisztral.UseVisualStyleBackColor = false;
            this.btnRegisztral.Click += new System.EventHandler(this.btnRegisztral_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(347, 399);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(106, 35);
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
            this.btnBezar.Location = new System.Drawing.Point(776, 0);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(25, 25);
            this.btnBezar.TabIndex = 12;
            this.btnBezar.Text = "X";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // RegisztracioForm
            // 
            this.AcceptButton = this.btnRegisztral;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnMegse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnRegisztral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeljesNev);
            this.Controls.Add(this.txtJelszoMegerosites);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.txtFelhasznalonev);
            this.Controls.Add(this.lblTeljesNev);
            this.Controls.Add(this.lblJelszoMegerosites);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.lblfelhasznalonev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisztracioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.RegisztracioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfelhasznalonev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Label lblJelszoMegerosites;
        private System.Windows.Forms.Label lblTeljesNev;
        private System.Windows.Forms.TextBox txtFelhasznalonev;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.TextBox txtJelszoMegerosites;
        private System.Windows.Forms.TextBox txtTeljesNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegisztral;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnBezar;
    }
}