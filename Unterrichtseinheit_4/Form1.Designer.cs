namespace Unterrichtseinheit_4
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
            this.LblTitel = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.CmdAnalyse = new System.Windows.Forms.Button();
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitel.Location = new System.Drawing.Point(59, 48);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(275, 32);
            this.LblTitel.TabIndex = 0;
            this.LblTitel.Text = "Bedingte Anweisung";
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(63, 122);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(224, 35);
            this.TxtInput.TabIndex = 1;
            // 
            // CmdAnalyse
            // 
            this.CmdAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAnalyse.Location = new System.Drawing.Point(324, 115);
            this.CmdAnalyse.Name = "CmdAnalyse";
            this.CmdAnalyse.Size = new System.Drawing.Size(169, 41);
            this.CmdAnalyse.TabIndex = 2;
            this.CmdAnalyse.Text = "Analysieren";
            this.CmdAnalyse.UseVisualStyleBackColor = true;
            this.CmdAnalyse.Click += new System.EventHandler(this.CmdAnalyse_Click);
            // 
            // TxtOut
            // 
            this.TxtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOut.Location = new System.Drawing.Point(63, 219);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(708, 207);
            this.TxtOut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.CmdAnalyse);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblTitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitel;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button CmdAnalyse;
        private System.Windows.Forms.TextBox TxtOut;
    }
}

