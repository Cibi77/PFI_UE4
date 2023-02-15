namespace Aufgabe_A4_2_3_mit_oeffnendem_Fenster
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
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.LblRestrictions = new System.Windows.Forms.Label();
            this.CmdDraw = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.LblBoxLength = new System.Windows.Forms.Label();
            this.LblBoxHeight = new System.Windows.Forms.Label();
            this.LblQuadrat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(111, 127);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(100, 26);
            this.TxtHeight.TabIndex = 0;
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(111, 84);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(100, 26);
            this.TxtWidth.TabIndex = 0;
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(22, 127);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(52, 20);
            this.LblHeight.TabIndex = 1;
            this.LblHeight.Text = "Höhe:";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(22, 87);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(55, 20);
            this.LblWidth.TabIndex = 1;
            this.LblWidth.Text = "Breite:";
            // 
            // LblRestrictions
            // 
            this.LblRestrictions.AutoSize = true;
            this.LblRestrictions.Location = new System.Drawing.Point(22, 222);
            this.LblRestrictions.Name = "LblRestrictions";
            this.LblRestrictions.Size = new System.Drawing.Size(262, 20);
            this.LblRestrictions.TabIndex = 1;
            this.LblRestrictions.Text = "Werte zwischen 50 und 100 erlaubt.";
            // 
            // CmdDraw
            // 
            this.CmdDraw.Location = new System.Drawing.Point(111, 283);
            this.CmdDraw.Name = "CmdDraw";
            this.CmdDraw.Size = new System.Drawing.Size(120, 38);
            this.CmdDraw.TabIndex = 2;
            this.CmdDraw.Text = "Zeichne";
            this.CmdDraw.UseVisualStyleBackColor = true;
            this.CmdDraw.Click += new System.EventHandler(this.CmdDraw_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtBox.Location = new System.Drawing.Point(324, 84);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(149, 89);
            this.TxtBox.TabIndex = 3;
            // 
            // LblBoxLength
            // 
            this.LblBoxLength.AutoSize = true;
            this.LblBoxLength.Location = new System.Drawing.Point(378, 61);
            this.LblBoxLength.Name = "LblBoxLength";
            this.LblBoxLength.Size = new System.Drawing.Size(51, 20);
            this.LblBoxLength.TabIndex = 4;
            this.LblBoxLength.Text = "Breite";
            // 
            // LblBoxHeight
            // 
            this.LblBoxHeight.AutoSize = true;
            this.LblBoxHeight.Location = new System.Drawing.Point(480, 116);
            this.LblBoxHeight.Name = "LblBoxHeight";
            this.LblBoxHeight.Size = new System.Drawing.Size(48, 20);
            this.LblBoxHeight.TabIndex = 5;
            this.LblBoxHeight.Text = "Höhe";
            // 
            // LblQuadrat
            // 
            this.LblQuadrat.AutoSize = true;
            this.LblQuadrat.Location = new System.Drawing.Point(324, 193);
            this.LblQuadrat.Name = "LblQuadrat";
            this.LblQuadrat.Size = new System.Drawing.Size(0, 20);
            this.LblQuadrat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 368);
            this.Controls.Add(this.LblQuadrat);
            this.Controls.Add(this.LblBoxHeight);
            this.Controls.Add(this.LblBoxLength);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.CmdDraw);
            this.Controls.Add(this.LblRestrictions);
            this.Controls.Add(this.LblWidth);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.TxtHeight);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-2-3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.Label LblRestrictions;
        private System.Windows.Forms.Button CmdDraw;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Label LblBoxLength;
        private System.Windows.Forms.Label LblBoxHeight;
        private System.Windows.Forms.Label LblQuadrat;
    }
}

