namespace DLWMS.WinForms.IspitIB180079
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
            this.labl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Uvjerenja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(12, 22);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(30, 15);
            this.labl.TabIndex = 0;
            this.labl.Text = "Spol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "rođen u periodu od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "do";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(312, 19);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumOd.TabIndex = 2;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(564, 19);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumDo.TabIndex = 2;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indeks,
            this.ImePrezime,
            this.Prosjek,
            this.Datum,
            this.Aktivan,
            this.Uvjerenja});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 57);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 25;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(752, 246);
            this.dgvStudenti.TabIndex = 3;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // Indeks
            // 
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Broj indeksa";
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum rođenja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            this.Uvjerenja.HeaderText = "";
            this.Uvjerenja.Name = "Uvjerenja";
            this.Uvjerenja.ReadOnly = true;
            this.Uvjerenja.Text = "Uvjerenja";
            this.Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // cbSpol
            // 
            this.cbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Location = new System.Drawing.Point(62, 18);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(121, 23);
            this.cbSpol.TabIndex = 4;
            this.cbSpol.SelectedIndexChanged += new System.EventHandler(this.cbSpol_SelectedIndexChanged);
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 315);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labl);
            this.Name = "frmPretragaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labl;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
        private ComboBox cbSpol;
    }
}