namespace ATPappWinForms
{
<<<<<<< Updated upstream:ATPappWinForms/ATPappWinForms/Form1.Designer.cs
    partial class frmAvvio
=======
    partial class frmHome
>>>>>>> Stashed changes:ATPappWinForms/ATPappWinForms/frmHome.Designer.cs
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< Updated upstream:ATPappWinForms/ATPappWinForms/Form1.Designer.cs
            this.lstAgenti = new System.Windows.Forms.ListBox();
            this.lblAgenti = new System.Windows.Forms.Label();
            this.btnCaricaElenco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAgenti
            // 
            this.lstAgenti.FormattingEnabled = true;
            this.lstAgenti.Location = new System.Drawing.Point(27, 60);
            this.lstAgenti.Name = "lstAgenti";
            this.lstAgenti.Size = new System.Drawing.Size(176, 186);
            this.lstAgenti.TabIndex = 0;
            // 
            // lblAgenti
            // 
            this.lblAgenti.AutoSize = true;
            this.lblAgenti.Location = new System.Drawing.Point(32, 41);
            this.lblAgenti.Name = "lblAgenti";
            this.lblAgenti.Size = new System.Drawing.Size(73, 13);
            this.lblAgenti.TabIndex = 1;
            this.lblAgenti.Text = "Elenco Agenti";
            // 
            // btnCaricaElenco
            // 
            this.btnCaricaElenco.Location = new System.Drawing.Point(257, 60);
            this.btnCaricaElenco.Name = "btnCaricaElenco";
            this.btnCaricaElenco.Size = new System.Drawing.Size(84, 46);
            this.btnCaricaElenco.TabIndex = 2;
            this.btnCaricaElenco.Text = "Carica Elenco Agenti";
            this.btnCaricaElenco.UseVisualStyleBackColor = true;
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 415);
            this.Controls.Add(this.btnCaricaElenco);
            this.Controls.Add(this.lblAgenti);
            this.Controls.Add(this.lstAgenti);
            this.Name = "frmAvvio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.SuspendLayout();
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
>>>>>>> Stashed changes:ATPappWinForms/ATPappWinForms/frmHome.Designer.cs

        }

        #endregion

        private System.Windows.Forms.ListBox lstAgenti;
        private System.Windows.Forms.Label lblAgenti;
        private System.Windows.Forms.Button btnCaricaElenco;
    }
}

