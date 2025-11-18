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
            this.Meteorit = new System.Windows.Forms.PictureBox();
            this.Raketa = new System.Windows.Forms.PictureBox();
            this.txtSkore = new System.Windows.Forms.Label();
            this.txtZivoty = new System.Windows.Forms.Label();
            this.txtPalivo = new System.Windows.Forms.Label();
            this.boxSkore = new System.Windows.Forms.MaskedTextBox();
            this.boxPalivo = new System.Windows.Forms.MaskedTextBox();
            this.Zivot1 = new System.Windows.Forms.PictureBox();
            this.Zivot2 = new System.Windows.Forms.PictureBox();
            this.Zivot3 = new System.Windows.Forms.PictureBox();
            this.groupOvladani = new System.Windows.Forms.GroupBox();
            this.labelRychlostMeteoritu = new System.Windows.Forms.Label();
            this.labelRaketaRychlost = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.trackBarMeteorit = new System.Windows.Forms.TrackBar();
            this.trackBarRaketa = new System.Windows.Forms.TrackBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBarPalivo = new System.Windows.Forms.ProgressBar();
            this.button_ZobrazVysledky = new System.Windows.Forms.Button();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.label_jmeno = new System.Windows.Forms.Label();
            this.hraciPlocha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot3)).BeginInit();
            this.groupOvladani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMeteorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRaketa)).BeginInit();
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
            this.hraciPlocha.Location = new System.Drawing.Point(34, 115);
            this.hraciPlocha.Name = "hraciPlocha";
            this.hraciPlocha.Size = new System.Drawing.Size(708, 314);
            this.hraciPlocha.TabIndex = 1;
            this.hraciPlocha.TabStop = false;
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
            // txtSkore
            // 
            this.txtSkore.AutoSize = true;
            this.txtSkore.Location = new System.Drawing.Point(31, 462);
            this.txtSkore.Name = "txtSkore";
            this.txtSkore.Size = new System.Drawing.Size(35, 13);
            this.txtSkore.TabIndex = 2;
            this.txtSkore.Text = "Skóre";
            // 
            // txtZivoty
            // 
            this.txtZivoty.AutoSize = true;
            this.txtZivoty.Location = new System.Drawing.Point(338, 462);
            this.txtZivoty.Name = "txtZivoty";
            this.txtZivoty.Size = new System.Drawing.Size(36, 13);
            this.txtZivoty.TabIndex = 3;
            this.txtZivoty.Text = "Životy";
            // 
            // txtPalivo
            // 
            this.txtPalivo.AutoSize = true;
            this.txtPalivo.Location = new System.Drawing.Point(629, 462);
            this.txtPalivo.Name = "txtPalivo";
            this.txtPalivo.Size = new System.Drawing.Size(36, 13);
            this.txtPalivo.TabIndex = 4;
            this.txtPalivo.Text = "Palivo";
            // 
            // boxSkore
            // 
            this.boxSkore.Location = new System.Drawing.Point(72, 459);
            this.boxSkore.Name = "boxSkore";
            this.boxSkore.Size = new System.Drawing.Size(71, 20);
            this.boxSkore.TabIndex = 5;
            // 
            // boxPalivo
            // 
            this.boxPalivo.Location = new System.Drawing.Point(671, 459);
            this.boxPalivo.Name = "boxPalivo";
            this.boxPalivo.Size = new System.Drawing.Size(71, 20);
            this.boxPalivo.TabIndex = 6;
            // 
            // Zivot1
            // 
            this.Zivot1.Image = ((System.Drawing.Image)(resources.GetObject("Zivot1.Image")));
            this.Zivot1.Location = new System.Drawing.Point(380, 459);
            this.Zivot1.Name = "Zivot1";
            this.Zivot1.Size = new System.Drawing.Size(32, 20);
            this.Zivot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Zivot1.TabIndex = 7;
            this.Zivot1.TabStop = false;
            // 
            // Zivot2
            // 
            this.Zivot2.Image = ((System.Drawing.Image)(resources.GetObject("Zivot2.Image")));
            this.Zivot2.Location = new System.Drawing.Point(418, 459);
            this.Zivot2.Name = "Zivot2";
            this.Zivot2.Size = new System.Drawing.Size(32, 20);
            this.Zivot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Zivot2.TabIndex = 8;
            this.Zivot2.TabStop = false;
            // 
            // Zivot3
            // 
            this.Zivot3.Image = ((System.Drawing.Image)(resources.GetObject("Zivot3.Image")));
            this.Zivot3.Location = new System.Drawing.Point(456, 459);
            this.Zivot3.Name = "Zivot3";
            this.Zivot3.Size = new System.Drawing.Size(32, 20);
            this.Zivot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Zivot3.TabIndex = 9;
            this.Zivot3.TabStop = false;
            // 
            // groupOvladani
            // 
            this.groupOvladani.Controls.Add(this.labelRychlostMeteoritu);
            this.groupOvladani.Controls.Add(this.labelRaketaRychlost);
            this.groupOvladani.Controls.Add(this.labelInfo);
            this.groupOvladani.Controls.Add(this.trackBarMeteorit);
            this.groupOvladani.Controls.Add(this.trackBarRaketa);
            this.groupOvladani.Controls.Add(this.buttonReset);
            this.groupOvladani.Controls.Add(this.buttonStop);
            this.groupOvladani.Controls.Add(this.buttonStart);
            this.groupOvladani.Location = new System.Drawing.Point(34, 42);
            this.groupOvladani.Name = "groupOvladani";
            this.groupOvladani.Size = new System.Drawing.Size(708, 76);
            this.groupOvladani.TabIndex = 10;
            this.groupOvladani.TabStop = false;
            this.groupOvladani.Text = "Ovládání hry";
            // 
            // labelRychlostMeteoritu
            // 
            this.labelRychlostMeteoritu.AutoSize = true;
            this.labelRychlostMeteoritu.Location = new System.Drawing.Point(604, 16);
            this.labelRychlostMeteoritu.Name = "labelRychlostMeteoritu";
            this.labelRychlostMeteoritu.Size = new System.Drawing.Size(95, 13);
            this.labelRychlostMeteoritu.TabIndex = 16;
            this.labelRychlostMeteoritu.Text = "Rychlost Meteoritů";
            // 
            // labelRaketaRychlost
            // 
            this.labelRaketaRychlost.AutoSize = true;
            this.labelRaketaRychlost.Location = new System.Drawing.Point(495, 16);
            this.labelRaketaRychlost.Name = "labelRaketaRychlost";
            this.labelRaketaRychlost.Size = new System.Drawing.Size(85, 13);
            this.labelRaketaRychlost.TabIndex = 15;
            this.labelRaketaRychlost.Text = "Rychlost Rakety";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(255, 57);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(47, 13);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "labelInfo";
            // 
            // trackBarMeteorit
            // 
            this.trackBarMeteorit.Location = new System.Drawing.Point(596, 35);
            this.trackBarMeteorit.Name = "trackBarMeteorit";
            this.trackBarMeteorit.Size = new System.Drawing.Size(104, 45);
            this.trackBarMeteorit.TabIndex = 13;
            // 
            // trackBarRaketa
            // 
            this.trackBarRaketa.Location = new System.Drawing.Point(486, 35);
            this.trackBarRaketa.Name = "trackBarRaketa";
            this.trackBarRaketa.Size = new System.Drawing.Size(104, 45);
            this.trackBarRaketa.TabIndex = 12;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonReset.Location = new System.Drawing.Point(174, 35);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStop.Location = new System.Drawing.Point(93, 35);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStart.Location = new System.Drawing.Point(6, 35);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // progressBarPalivo
            // 
            this.progressBarPalivo.Location = new System.Drawing.Point(632, 485);
            this.progressBarPalivo.Name = "progressBarPalivo";
            this.progressBarPalivo.Size = new System.Drawing.Size(110, 23);
            this.progressBarPalivo.TabIndex = 11;
            // 
            // button_ZobrazVysledky
            // 
            this.button_ZobrazVysledky.Location = new System.Drawing.Point(34, 485);
            this.button_ZobrazVysledky.Name = "button_ZobrazVysledky";
            this.button_ZobrazVysledky.Size = new System.Drawing.Size(109, 23);
            this.button_ZobrazVysledky.TabIndex = 12;
            this.button_ZobrazVysledky.Text = "Zobrazit výsledky";
            this.button_ZobrazVysledky.UseVisualStyleBackColor = true;
            this.button_ZobrazVysledky.Click += new System.EventHandler(this.button_ZobrazVysledky_Click);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(300, 557);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(188, 20);
            this.textBoxJmeno.TabIndex = 13;
            // 
            // label_jmeno
            // 
            this.label_jmeno.AutoSize = true;
            this.label_jmeno.Location = new System.Drawing.Point(373, 541);
            this.label_jmeno.Name = "label_jmeno";
            this.label_jmeno.Size = new System.Drawing.Size(38, 13);
            this.label_jmeno.TabIndex = 14;
            this.label_jmeno.Text = "Jméno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 589);
            this.Controls.Add(this.label_jmeno);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.button_ZobrazVysledky);
            this.Controls.Add(this.groupOvladani);
            this.Controls.Add(this.Zivot3);
            this.Controls.Add(this.Zivot2);
            this.Controls.Add(this.progressBarPalivo);
            this.Controls.Add(this.Zivot1);
            this.Controls.Add(this.boxPalivo);
            this.Controls.Add(this.txt_heading);
            this.Controls.Add(this.boxSkore);
            this.Controls.Add(this.txtPalivo);
            this.Controls.Add(this.txtZivoty);
            this.Controls.Add(this.txtSkore);
            this.Controls.Add(this.hraciPlocha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HraRaketa";
            this.hraciPlocha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Meteorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zivot3)).EndInit();
            this.groupOvladani.ResumeLayout(false);
            this.groupOvladani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMeteorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRaketa)).EndInit();
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
        private System.Windows.Forms.GroupBox groupOvladani;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBarPalivo;
        private System.Windows.Forms.TrackBar trackBarMeteorit;
        private System.Windows.Forms.TrackBar trackBarRaketa;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelRaketaRychlost;
        private System.Windows.Forms.Label labelRychlostMeteoritu;
        private System.Windows.Forms.Button button_ZobrazVysledky;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.Label label_jmeno;
    }
}

