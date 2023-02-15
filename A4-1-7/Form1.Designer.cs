namespace A4_1_7
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumCategory = new System.Windows.Forms.NumericUpDown();
            this.LblCategory = new System.Windows.Forms.Label();
            this.NumDuration = new System.Windows.Forms.NumericUpDown();
            this.LblDuration = new System.Windows.Forms.Label();
            this.NumWay = new System.Windows.Forms.NumericUpDown();
            this.LblWay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWay)).BeginInit();
            this.SuspendLayout();
            // 
            // NumCategory
            // 
            this.NumCategory.Location = new System.Drawing.Point(27, 89);
            this.NumCategory.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumCategory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCategory.Name = "NumCategory";
            this.NumCategory.Size = new System.Drawing.Size(120, 26);
            this.NumCategory.TabIndex = 0;
            this.NumCategory.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(27, 50);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(255, 20);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.Text = "Wagenkategorie (1=klein, 2=gross)";
            this.LblCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumDuration
            // 
            this.NumDuration.Location = new System.Drawing.Point(27, 189);
            this.NumDuration.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDuration.Name = "NumDuration";
            this.NumDuration.Size = new System.Drawing.Size(120, 26);
            this.NumDuration.TabIndex = 0;
            this.NumDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Location = new System.Drawing.Point(27, 150);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(149, 20);
            this.LblDuration.TabIndex = 1;
            this.LblDuration.Text = "Mietdauer in Tagen:";
            this.LblDuration.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumWay
            // 
            this.NumWay.Location = new System.Drawing.Point(27, 290);
            this.NumWay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumWay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumWay.Name = "NumWay";
            this.NumWay.Size = new System.Drawing.Size(120, 26);
            this.NumWay.TabIndex = 0;
            this.NumWay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblWay
            // 
            this.LblWay.AutoSize = true;
            this.LblWay.Location = new System.Drawing.Point(27, 251);
            this.LblWay.Name = "LblWay";
            this.LblWay.Size = new System.Drawing.Size(234, 20);
            this.LblWay.TabIndex = 1;
            this.LblWay.Text = "Stecke in km (auf km gerundet):";
            this.LblWay.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Berechne Kosten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(59, 414);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(63, 20);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "Kosten:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 474);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblWay);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.NumWay);
            this.Controls.Add(this.NumDuration);
            this.Controls.Add(this.NumCategory);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-1-9";
            ((System.ComponentModel.ISupportInitialize)(this.NumCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumCategory;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.NumericUpDown NumDuration;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.NumericUpDown NumWay;
        private System.Windows.Forms.Label LblWay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblOutput;
    }
}

