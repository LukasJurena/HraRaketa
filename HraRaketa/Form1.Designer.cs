namespace HraRaketa
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_heading = new System.Windows.Forms.Label();
            this.hraciPlocha = new System.Windows.Forms.GroupBox();
            this.txtSkore = new System.Windows.Forms.Label();
            this.txtZivoty = new System.Windows.Forms.Label();
            this.txtPalivo = new System.Windows.Forms.Label();
            this.boxSkore = new System.Windows.Forms.MaskedTextBox();
            this.boxPalivo = new System.Windows.Forms.MaskedTextBox();
            this.Raketa = new System.Windows.Forms.PictureBox();
            this.Meteorit = new System.Windows.Forms.PictureBox();
            this.Zivot1 = new System.Windows.Forms.PictureBox();
            this.Zivot2 = new System.Windows.Forms.PictureBox();
            this.Zivot3 = new System.Windows.Forms.PictureBox();
            this.hraciPlocha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Raketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_heading
            // 
            this.txt_heading.AutoSize = true;
            this.txt_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_heading.Location = new System.Drawing.Point(337, 19);
            this.txt_heading.Name = "txt_heading";
            this.txt_heading.Size = new System.Drawing.Size(112, 20);
            this.txt_heading.TabIndex = 0;
            this.txt_heading.Text = "HRA RAKETA";
            this.txt_heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hraciPlocha
            // 
            this.hraciPlocha.BackColor = System.Drawing.SystemColors.MenuText;
            this.hraciPlocha.Controls.Add(this.Meteorit);
            this.hraciPlocha.Controls.Add(this.Raketa);
            this.hraciPlocha.Location = new System.Drawing.Point(34, 55);
            this.hraciPlocha.Name = "hraciPlocha";
            this.hraciPlocha.Size = new System.Drawing.Size(708, 314);
            this.hraciPlocha.TabIndex = 1;
            this.hraciPlocha.TabStop = false;
            // 
            // txtSkore
            // 
            this.txtSkore.AutoSize = true;
            this.txtSkore.Location = new System.Drawing.Point(31, 402);
            this.txtSkore.Name = "txtSkore";
            this.txtSkore.Size = new System.Drawing.Size(35, 13);
            this.txtSkore.TabIndex = 2;
            this.txtSkore.Text = "Skóre";
            // 
            // txtZivoty
            // 
            this.txtZivoty.AutoSize = true;
            this.txtZivoty.Location = new System.Drawing.Point(338, 402);
            this.txtZivoty.Name = "txtZivoty";
            this.txtZivoty.Size = new System.Drawing.Size(36, 13);
            this.txtZivoty.TabIndex = 3;
            this.txtZivoty.Text = "Životy";
            // 
            // txtPalivo
            // 
            this.txtPalivo.AutoSize = true;
            this.txtPalivo.Location = new System.Drawing.Point(629, 402);
            this.txtPalivo.Name = "txtPalivo";
            this.txtPalivo.Size = new System.Drawing.Size(36, 13);
            this.txtPalivo.TabIndex = 4;
            this.txtPalivo.Text = "Palivo";
            // 
            // boxSkore
            // 
            this.boxSkore.Location = new System.Drawing.Point(72, 399);
            this.boxSkore.Name = "boxSkore";
            this.boxSkore.Size = new System.Drawing.Size(71, 20);
            this.boxSkore.TabIndex = 5;
            // 
            // boxPalivo
            // 
            this.boxPalivo.Location = new System.Drawing.Point(671, 399);
            this.boxPalivo.Name = "boxPalivo";
            this.boxPalivo.Size = new System.Drawing.Size(71, 20);
            this.boxPalivo.TabIndex = 6;
            // 
            // Raketa
            // 
            this.Raketa.Image = ((System.Drawing.Image)(resources.GetObject("Raketa.Image")));
            this.Raketa.Location = new System.Drawing.Point(344, 258);
            this.Raketa.Name = "Raketa";
            this.Raketa.Size = new System.Drawing.Size(33, 50);
            this.Raketa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Raketa.TabIndex = 0;
            this.Raketa.TabStop = false;
            // 
            // Meteorit
            // 
            this.Meteorit.Image = ((System.Drawing.Image)(resources.GetObject("Meteorit.Image")));
            this.Meteorit.Location = new System.Drawing.Point(337, 23);
            this.Meteorit.Name = "Meteorit";
            this.Meteorit.Size = new System.Drawing.Size(52, 50);
            this.Meteorit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Meteorit.TabIndex = 1;
            this.Meteorit.TabStop = false;
            // 
            // Zivot1
            // 
            this.Zivot1.Image = ((System.Drawing.Image)(resources.GetObject("Zivot1.Image")));
            this.Zivot1.Location = new System.Drawing.Point(380, 399);
            this.Zivot1.Name = "Zivot1";
            this.Zivot1.Size = new System.Drawing.Size(32, 20);
            this.Zivot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Zivot1.TabIndex = 7;
            this.Zivot1.TabStop = false;
            // 
            // Zivot2
            // 
            this.Zivot2.Image = ((System.Drawing.Image)(resources.GetObject("Zivot2.Image")));
            this.Zivot2.Location = new System.Drawing.Point(418, 399);
            this.Zivot2.Name = "Zivot2";
            this.Zivot2.Size = new System.Drawing.Size(32, 20);
            this.Zivot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Zivot2.TabIndex = 8;
            this.Zivot2.TabStop = false;
            // 
            // Zivot3
            // 
            this.Zivot3.Image = ((System.Drawing.Image)(resources.GetObject("Zivot3.Image")));
            this.Zivot3.Location = new System.Drawing.Point(456, 399);
            this.Zivot3.Name = "Zivot3";
            this.Zivot3.Size = new System.Drawing.Size(32, 20);
            this.Zivot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Zivot3.TabIndex = 9;
            this.Zivot3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.Zivot3);
            this.Controls.Add(this.Zivot2);
            this.Controls.Add(this.Zivot1);
            this.Controls.Add(this.boxPalivo);
            this.Controls.Add(this.boxSkore);
            this.Controls.Add(this.txtPalivo);
            this.Controls.Add(this.txtZivoty);
            this.Controls.Add(this.txtSkore);
            this.Controls.Add(this.hraciPlocha);
            this.Controls.Add(this.txt_heading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HraRaketa";
            this.hraciPlocha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Raketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_heading;
        private System.Windows.Forms.GroupBox hraciPlocha;
        private System.Windows.Forms.Label txtSkore;
        private System.Windows.Forms.Label txtZivoty;
        private System.Windows.Forms.Label txtPalivo;
        private System.Windows.Forms.MaskedTextBox boxSkore;
        private System.Windows.Forms.MaskedTextBox boxPalivo;
        private System.Windows.Forms.PictureBox Raketa;
        private System.Windows.Forms.PictureBox Meteorit;
        private System.Windows.Forms.PictureBox Zivot1;
        private System.Windows.Forms.PictureBox Zivot2;
        private System.Windows.Forms.PictureBox Zivot3;
    }
}

