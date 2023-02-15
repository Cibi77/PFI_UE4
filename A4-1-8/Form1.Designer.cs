namespace A4_1_8
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
            this.LblVerbrauch = new System.Windows.Forms.Label();
            this.NumVerbrauch = new System.Windows.Forms.NumericUpDown();
            this.CmdCalculate = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumVerbrauch)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVerbrauch
            // 
            this.LblVerbrauch.AutoSize = true;
            this.LblVerbrauch.Location = new System.Drawing.Point(43, 72);
            this.LblVerbrauch.Name = "LblVerbrauch";
            this.LblVerbrauch.Size = new System.Drawing.Size(139, 20);
            this.LblVerbrauch.TabIndex = 0;
            this.LblVerbrauch.Text = "Verbrauch in kWh:";
            // 
            // NumVerbrauch
            // 
            this.NumVerbrauch.Location = new System.Drawing.Point(199, 72);
            this.NumVerbrauch.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumVerbrauch.Name = "NumVerbrauch";
            this.NumVerbrauch.Size = new System.Drawing.Size(120, 26);
            this.NumVerbrauch.TabIndex = 1;
            // 
            // CmdCalculate
            // 
            this.CmdCalculate.Location = new System.Drawing.Point(199, 130);
            this.CmdCalculate.Name = "CmdCalculate";
            this.CmdCalculate.Size = new System.Drawing.Size(154, 32);
            this.CmdCalculate.TabIndex = 2;
            this.CmdCalculate.Text = "Berechne Kosten";
            this.CmdCalculate.UseVisualStyleBackColor = true;
            this.CmdCalculate.Click += new System.EventHandler(this.CmdCalculate_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(47, 194);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(63, 20);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "Kosten:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 286);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.CmdCalculate);
            this.Controls.Add(this.NumVerbrauch);
            this.Controls.Add(this.LblVerbrauch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumVerbrauch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVerbrauch;
        private System.Windows.Forms.NumericUpDown NumVerbrauch;
        private System.Windows.Forms.Button CmdCalculate;
        private System.Windows.Forms.Label LblResult;
    }
}

