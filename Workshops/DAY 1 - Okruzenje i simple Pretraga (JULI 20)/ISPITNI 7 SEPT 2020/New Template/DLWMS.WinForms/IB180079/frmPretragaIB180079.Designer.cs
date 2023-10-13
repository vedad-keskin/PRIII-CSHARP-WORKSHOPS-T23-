namespace DLWMS.WinForms.IB180079
{
    partial class frmPretragaIB180079
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
            this.lblImeiPrezime = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            this.chbAktivan = new System.Windows.Forms.CheckBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Location = new System.Drawing.Point(12, 21);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(93, 15);
            this.lblImeiPrezime.TabIndex = 0;
            this.lblImeiPrezime.Text = "Ime ili prezime : ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(111, 18);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(294, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spol :";
            // 
            // cbSpol
            // 
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Location = new System.Drawing.Point(455, 19);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(121, 23);
            this.cbSpol.TabIndex = 2;
            this.cbSpol.SelectedIndexChanged += new System.EventHandler(this.cbSpol_SelectedIndexChanged);
            // 
            // chbAktivan
            // 
            this.chbAktivan.AutoSize = true;
            this.chbAktivan.Location = new System.Drawing.Point(597, 21);
            this.chbAktivan.Name = "chbAktivan";
            this.chbAktivan.Size = new System.Drawing.Size(66, 19);
            this.chbAktivan.TabIndex = 3;
            this.chbAktivan.Text = "Aktivan";
            this.chbAktivan.UseVisualStyleBackColor = true;
            this.chbAktivan.CheckedChanged += new System.EventHandler(this.chbAktivan_CheckedChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.Indeks,
            this.Aktivan,
            this.Slike});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 53);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 25;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(651, 215);
            this.dgvStudenti.TabIndex = 4;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // Indeks
            // 
            this.Indeks.DataPropertyName = "BrojIndeksa";
            this.Indeks.HeaderText = "Indeks";
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Slike
            // 
            this.Slike.HeaderText = "";
            this.Slike.Name = "Slike";
            this.Slike.ReadOnly = true;
            this.Slike.Text = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 295);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.chbAktivan);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblImeiPrezime);
            this.Name = "frmPretragaIB180079";
            this.Text = "Administracija korisnika";
            this.Load += new System.EventHandler(this.frmPretragaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblImeiPrezime;
        private TextBox txtPretraga;
        private Label label2;
        private ComboBox cbSpol;
        private CheckBox chbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Slike;
    }
}