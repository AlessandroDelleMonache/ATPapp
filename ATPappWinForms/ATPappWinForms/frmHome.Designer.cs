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
            this.lstAgenti.Location = new System.Drawing.Point(34, 58);
            this.lstAgenti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAgenti.Name = "lstAgenti";
            this.lstAgenti.Size = new System.Drawing.Size(272, 160);
            this.lstAgenti.TabIndex = 0;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(354, 58);
            this.btnCarica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(106, 49);
            this.btnCarica.TabIndex = 1;
            this.btnCarica.Text = "Carica agenti";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 341);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.lstAgenti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

