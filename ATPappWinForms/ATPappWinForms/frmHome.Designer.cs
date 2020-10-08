namespace ATPappWinForms
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
            this.components = new System.ComponentModel.Container();
            this.btnCarica = new System.Windows.Forms.Button();
            this.dgvAgenti = new System.Windows.Forms.DataGridView();
            this.agentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAgenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaAgenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(555, 79);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(146, 60);
            this.btnCarica.TabIndex = 1;
            this.btnCarica.Text = "Carica agenti";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // dgvAgenti
            // 
            this.dgvAgenti.AllowUserToAddRows = false;
            this.dgvAgenti.AllowUserToDeleteRows = false;
            this.dgvAgenti.AutoGenerateColumns = false;
            this.dgvAgenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentiIdDataGridViewTextBoxColumn,
            this.nomeAgenteDataGridViewTextBoxColumn,
            this.siglaAgenteDataGridViewTextBoxColumn});
            this.dgvAgenti.DataSource = this.agentiBindingSource;
            this.dgvAgenti.Location = new System.Drawing.Point(33, 79);
            this.dgvAgenti.Name = "dgvAgenti";
            this.dgvAgenti.ReadOnly = true;
            this.dgvAgenti.RowHeadersWidth = 51;
            this.dgvAgenti.RowTemplate.Height = 24;
            this.dgvAgenti.Size = new System.Drawing.Size(501, 100);
            this.dgvAgenti.TabIndex = 2;
            // 
            // agentiBindingSource
            // 
            this.agentiBindingSource.DataSource = typeof(ATPappWinForms.Classi.Agenti);
            // 
            // agentiIdDataGridViewTextBoxColumn
            // 
            this.agentiIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.agentiIdDataGridViewTextBoxColumn.DataPropertyName = "AgentiId";
            this.agentiIdDataGridViewTextBoxColumn.HeaderText = "AgentiId";
            this.agentiIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agentiIdDataGridViewTextBoxColumn.Name = "agentiIdDataGridViewTextBoxColumn";
            this.agentiIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeAgenteDataGridViewTextBoxColumn
            // 
            this.nomeAgenteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeAgenteDataGridViewTextBoxColumn.DataPropertyName = "NomeAgente";
            this.nomeAgenteDataGridViewTextBoxColumn.HeaderText = "NomeAgente";
            this.nomeAgenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeAgenteDataGridViewTextBoxColumn.Name = "nomeAgenteDataGridViewTextBoxColumn";
            this.nomeAgenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siglaAgenteDataGridViewTextBoxColumn
            // 
            this.siglaAgenteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siglaAgenteDataGridViewTextBoxColumn.DataPropertyName = "SiglaAgente";
            this.siglaAgenteDataGridViewTextBoxColumn.HeaderText = "SiglaAgente";
            this.siglaAgenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siglaAgenteDataGridViewTextBoxColumn.Name = "siglaAgenteDataGridViewTextBoxColumn";
            this.siglaAgenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.dgvAgenti);
            this.Controls.Add(this.btnCarica);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.DataGridView dgvAgenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaAgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agentiBindingSource;
    }
}

