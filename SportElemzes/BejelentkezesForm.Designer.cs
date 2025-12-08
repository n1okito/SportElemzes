namespace SportElemzes
{
    partial class BejelentkezesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BejelentkezesForm));
            this.lblFelhasznalonev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.btnRegisztracio = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.txtFelhasznalonev = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFelhasznalonev
            // 
            this.lblFelhasznalonev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFelhasznalonev.AutoSize = true;
            this.lblFelhasznalonev.BackColor = System.Drawing.Color.Transparent;
            this.lblFelhasznalonev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFelhasznalonev.ForeColor = System.Drawing.Color.White;
            this.lblFelhasznalonev.Location = new System.Drawing.Point(342, 140);
            this.lblFelhasznalonev.Name = "lblFelhasznalonev";
            this.lblFelhasznalonev.Size = new System.Drawing.Size(116, 21);
            this.lblFelhasznalonev.TabIndex = 0;
            this.lblFelhasznalonev.Text = "Felhasználónév";
            // 
            // lblJelszo
            // 
            this.lblJelszo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.BackColor = System.Drawing.Color.Transparent;
            this.lblJelszo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJelszo.ForeColor = System.Drawing.Color.White;
            this.lblJelszo.Location = new System.Drawing.Point(375, 189);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(51, 21);
            this.lblJelszo.TabIndex = 1;
            this.lblJelszo.Text = "Jelszó";
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBejelentkezes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBejelentkezes.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBejelentkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBejelentkezes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBejelentkezes.ForeColor = System.Drawing.Color.White;
            this.btnBejelentkezes.Location = new System.Drawing.Point(340, 255);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(120, 40);
            this.btnBejelentkezes.TabIndex = 2;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = false;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBejelentkezes_Click);
            // 
            // btnRegisztracio
            // 
            this.btnRegisztracio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisztracio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegisztracio.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegisztracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisztracio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegisztracio.ForeColor = System.Drawing.Color.White;
            this.btnRegisztracio.Location = new System.Drawing.Point(340, 301);
            this.btnRegisztracio.Name = "btnRegisztracio";
            this.btnRegisztracio.Size = new System.Drawing.Size(120, 40);
            this.btnRegisztracio.TabIndex = 3;
            this.btnRegisztracio.Text = "Regisztráció";
            this.btnRegisztracio.UseVisualStyleBackColor = false;
            this.btnRegisztracio.Click += new System.EventHandler(this.btnRegisztracio_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(350, 370);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(100, 30);
            this.btnMegse.TabIndex = 4;
            this.btnMegse.Text = "Kilépés";
            this.btnMegse.UseVisualStyleBackColor = false;
            // 
            // txtFelhasznalonev
            // 
            this.txtFelhasznalonev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFelhasznalonev.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFelhasznalonev.Location = new System.Drawing.Point(315, 164);
            this.txtFelhasznalonev.Name = "txtFelhasznalonev";
            this.txtFelhasznalonev.Size = new System.Drawing.Size(170, 22);
            this.txtFelhasznalonev.TabIndex = 5;
            // 
            // txtJelszo
            // 
            this.txtJelszo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJelszo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJelszo.Location = new System.Drawing.Point(315, 213);
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.PasswordChar = '*';
            this.txtJelszo.Size = new System.Drawing.Size(170, 22);
            this.txtJelszo.TabIndex = 6;
            this.txtJelszo.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(776, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IQOS", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 147);
            this.label1.TabIndex = 17;
            this.label1.Text = "STER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "SportTeljesítmény Elemző Rendszer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BejelentkezesForm
            // 
            this.AcceptButton = this.btnBejelentkezes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnMegse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.txtFelhasznalonev);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnRegisztracio);
            this.Controls.Add(this.btnBejelentkezes);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.lblFelhasznalonev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BejelentkezesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFelhasznalonev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Button btnBejelentkezes;
        private System.Windows.Forms.Button btnRegisztracio;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.TextBox txtFelhasznalonev;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}