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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbAktivnost = new System.Windows.Forms.ComboBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.BrojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Godina studija : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aktivnost :";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(111, 14);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(292, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // cbGodina
            // 
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Items.AddRange(new object[] {
            "Sve",
            "1",
            "2",
            "3"});
            this.cbGodina.Location = new System.Drawing.Point(507, 14);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(121, 23);
            this.cbGodina.TabIndex = 2;
            this.cbGodina.SelectedIndexChanged += new System.EventHandler(this.cbGodina_SelectedIndexChanged);
            // 
            // cbAktivnost
            // 
            this.cbAktivnost.FormattingEnabled = true;
            this.cbAktivnost.Items.AddRange(new object[] {
            "Svi",
            "Aktivni",
            "Neaktivni"});
            this.cbAktivnost.Location = new System.Drawing.Point(715, 14);
            this.cbAktivnost.Name = "cbAktivnost";
            this.cbAktivnost.Size = new System.Drawing.Size(121, 23);
            this.cbAktivnost.TabIndex = 2;
            this.cbAktivnost.SelectedIndexChanged += new System.EventHandler(this.cbAktivnost_SelectedIndexChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojIndeksa,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.Godina,
            this.Aktivan,
            this.Polozeni});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 48);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 25;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(827, 286);
            this.dgvStudenti.TabIndex = 3;
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.DataPropertyName = "BrojIndeksa";
            this.BrojIndeksa.HeaderText = "Indeks";
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.ReadOnly = true;
            this.BrojIndeksa.Width = 108;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 108;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // Godina
            // 
            this.Godina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Godina.DataPropertyName = "GodinaStudija";
            this.Godina.HeaderText = "Godina studija";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Broj studenata :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prosjecna ocjena : ";
            // 
            // lblBroj
            // 
            this.lblBroj.Location = new System.Drawing.Point(107, 337);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(89, 15);
            this.lblBroj.TabIndex = 0;
            // 
            // lblProsjek
            // 
            this.lblProsjek.Location = new System.Drawing.Point(123, 357);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(105, 15);
            this.lblProsjek.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(715, 342);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 381);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.cbAktivnost);
            this.Controls.Add(this.cbGodina);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPretraga;
        private ComboBox cbGodina;
        private ComboBox cbAktivnost;
        private DataGridView dgvStudenti;
        private Label label4;
        private Label label5;
        private Label lblBroj;
        private Label lblProsjek;
        private Button btnPrint;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
        private ErrorProvider err;
    }
}