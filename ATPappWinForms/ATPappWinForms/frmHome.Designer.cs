namespace ATPappWinforms
{
    partial class frmHome
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
            this.lstAgenti = new System.Windows.Forms.ListBox();
            this.btnCarica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAgenti
            // 
            this.lstAgenti.FormattingEnabled = true;
            this.lstAgenti.ItemHeight = 16;
            this.lstAgenti.Location = new System.Drawing.Point(46, 71);
            this.lstAgenti.Name = "lstAgenti";
            this.lstAgenti.Size = new System.Drawing.Size(362, 196);
            this.lstAgenti.TabIndex = 0;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(512, 71);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(141, 60);
            this.btnCarica.TabIndex = 1;
            this.btnCarica.Text = "Carica agenti";
            this.btnCarica.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.lstAgenti);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAgenti;
        private System.Windows.Forms.Button btnCarica;
    }
}

