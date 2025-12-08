namespace SportElemzes
{
    partial class WellnessForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnWellnessFelvitel = new System.Windows.Forms.Button();
            this.btnWellnessElemzes = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnWellnessLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellness";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnWellnessFelvitel
            // 
            this.btnWellnessFelvitel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWellnessFelvitel.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnWellnessFelvitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWellnessFelvitel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWellnessFelvitel.ForeColor = System.Drawing.Color.White;
            this.btnWellnessFelvitel.Location = new System.Drawing.Point(350, 118);
            this.btnWellnessFelvitel.Name = "btnWellnessFelvitel";
            this.btnWellnessFelvitel.Size = new System.Drawing.Size(100, 30);
            this.btnWellnessFelvitel.TabIndex = 1;
            this.btnWellnessFelvitel.Text = "Felvitel";
            this.btnWellnessFelvitel.UseVisualStyleBackColor = false;
            this.btnWellnessFelvitel.Click += new System.EventHandler(this.btnWellnessFelvitel_Click);
            // 
            // btnWellnessElemzes
            // 
            this.btnWellnessElemzes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWellnessElemzes.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnWellnessElemzes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWellnessElemzes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWellnessElemzes.ForeColor = System.Drawing.Color.White;
            this.btnWellnessElemzes.Location = new System.Drawing.Point(350, 236);
            this.btnWellnessElemzes.Name = "btnWellnessElemzes";
            this.btnWellnessElemzes.Size = new System.Drawing.Size(100, 30);
            this.btnWellnessElemzes.TabIndex = 2;
            this.btnWellnessElemzes.Text = "Elemzés";
            this.btnWellnessElemzes.UseVisualStyleBackColor = false;
            // 
            // btnMegse
            // 
            this.btnMegse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.ForeColor = System.Drawing.Color.White;
            this.btnMegse.Location = new System.Drawing.Point(350, 373);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(100, 30);
            this.btnMegse.TabIndex = 3;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = false;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnWellnessLista
            // 
            this.btnWellnessLista.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWellnessLista.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnWellnessLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWellnessLista.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWellnessLista.ForeColor = System.Drawing.Color.White;
            this.btnWellnessLista.Location = new System.Drawing.Point(350, 177);
            this.btnWellnessLista.Name = "btnWellnessLista";
            this.btnWellnessLista.Size = new System.Drawing.Size(100, 30);
            this.btnWellnessLista.TabIndex = 4;
            this.btnWellnessLista.Text = "Adatok";
            this.btnWellnessLista.UseVisualStyleBackColor = false;
            this.btnWellnessLista.Click += new System.EventHandler(this.btnWellnessLista_Click);
            // 
            // WellnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SportElemzes.Properties.Resources.mobile_677411_3439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWellnessLista);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnWellnessElemzes);
            this.Controls.Add(this.btnWellnessFelvitel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WellnessForm";
            this.Text = "WellnessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWellnessFelvitel;
        private System.Windows.Forms.Button btnWellnessElemzes;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnWellnessLista;
    }
}