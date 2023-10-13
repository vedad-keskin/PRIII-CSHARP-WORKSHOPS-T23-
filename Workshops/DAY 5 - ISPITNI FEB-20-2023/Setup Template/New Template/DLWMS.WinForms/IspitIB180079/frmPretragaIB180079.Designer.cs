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
            this.dgvStudentiPredmeti = new System.Windows.Forms.DataGridView();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.cbOcjenaDo = new System.Windows.Forms.ComboBox();
            this.cbOcjenaOd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentiPredmeti
            // 
            this.dgvStudentiPredmeti.AllowUserToAddRows = false;
            this.dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            this.dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indeks,
            this.ImePrezime,
            this.Predmet,
            this.Ocjena,
            this.Datum,
            this.Poruke});
            this.dgvStudentiPredmeti.Location = new System.Drawing.Point(12, 44);
            this.dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            this.dgvStudentiPredmeti.ReadOnly = true;
            this.dgvStudentiPredmeti.RowTemplate.Height = 25;
            this.dgvStudentiPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentiPredmeti.Size = new System.Drawing.Size(891, 256);
            this.dgvStudentiPredmeti.TabIndex = 12;
            this.dgvStudentiPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiPredmeti_CellContentClick);
            // 
            // Indeks
            // 
            this.Indeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Indeks";
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
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "DatumPolaganja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Poruke
            // 
            this.Poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poruke.HeaderText = "";
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(711, 12);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(192, 23);
            this.dtpDatumDo.TabIndex = 10;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(486, 12);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(192, 23);
            this.dtpDatumOd.TabIndex = 11;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // cbOcjenaDo
            // 
            this.cbOcjenaDo.FormattingEnabled = true;
            this.cbOcjenaDo.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6"});
            this.cbOcjenaDo.Location = new System.Drawing.Point(227, 15);
            this.cbOcjenaDo.Name = "cbOcjenaDo";
            this.cbOcjenaDo.Size = new System.Drawing.Size(121, 23);
            this.cbOcjenaDo.TabIndex = 8;
            this.cbOcjenaDo.SelectedIndexChanged += new System.EventHandler(this.cbOcjenaDo_SelectedIndexChanged);
            // 
            // cbOcjenaOd
            // 
            this.cbOcjenaOd.FormattingEnabled = true;
            this.cbOcjenaOd.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbOcjenaOd.Location = new System.Drawing.Point(79, 15);
            this.cbOcjenaOd.Name = "cbOcjenaOd";
            this.cbOcjenaOd.Size = new System.Drawing.Size(121, 23);
            this.cbOcjenaOd.TabIndex = 9;
            this.cbOcjenaOd.SelectedIndexChanged += new System.EventHandler(this.cbOcjenaOd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "položena u periodu od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ocjena od ";
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 317);
            this.Controls.Add(this.dgvStudentiPredmeti);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.cbOcjenaDo);
            this.Controls.Add(this.cbOcjenaOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvStudentiPredmeti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewButtonColumn Poruke;
        private DateTimePicker dtpDatumDo;
        private DateTimePicker dtpDatumOd;
        private ComboBox cbOcjenaDo;
        private ComboBox cbOcjenaOd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}