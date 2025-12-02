namespace HraRaketa
{
    partial class FormSkore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_NacistVysledky = new System.Windows.Forms.Button();
            this.button_VymazVysledky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_NacistVysledky
            // 
            this.button_NacistVysledky.Location = new System.Drawing.Point(12, 415);
            this.button_NacistVysledky.Name = "button_NacistVysledky";
            this.button_NacistVysledky.Size = new System.Drawing.Size(104, 23);
            this.button_NacistVysledky.TabIndex = 1;
            this.button_NacistVysledky.Text = "Načti výsledky";
            this.button_NacistVysledky.UseVisualStyleBackColor = true;
            this.button_NacistVysledky.Click += new System.EventHandler(this.button_NacistVysledky_Click);
            // 
            // button_VymazVysledky
            // 
            this.button_VymazVysledky.BackColor = System.Drawing.Color.IndianRed;
            this.button_VymazVysledky.Location = new System.Drawing.Point(684, 415);
            this.button_VymazVysledky.Name = "button_VymazVysledky";
            this.button_VymazVysledky.Size = new System.Drawing.Size(104, 23);
            this.button_VymazVysledky.TabIndex = 2;
            this.button_VymazVysledky.Text = "Vymaž výsledky";
            this.button_VymazVysledky.UseVisualStyleBackColor = false;
            this.button_VymazVysledky.Click += new System.EventHandler(this.button_VymazVysledky_Click);
            // 
            // FormSkore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_VymazVysledky);
            this.Controls.Add(this.button_NacistVysledky);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSkore";
            this.Text = "FormSkore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_NacistVysledky;
        private System.Windows.Forms.Button button_VymazVysledky;
    }
}