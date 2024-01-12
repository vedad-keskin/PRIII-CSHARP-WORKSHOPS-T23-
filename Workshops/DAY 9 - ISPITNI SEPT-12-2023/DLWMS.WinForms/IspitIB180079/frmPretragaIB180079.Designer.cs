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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbOcjenaOd = new ComboBox();
            cbOcjenaDo = new ComboBox();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            chbAktivan = new CheckBox();
            dgvStudentiPredmeti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "položena u periodu od ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Ocjena od";
            // 
            // cbOcjenaOd
            // 
            cbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaOd.FormattingEnabled = true;
            cbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cbOcjenaOd.Location = new Point(79, 6);
            cbOcjenaOd.Name = "cbOcjenaOd";
            cbOcjenaOd.Size = new Size(67, 23);
            cbOcjenaOd.TabIndex = 1;
            cbOcjenaOd.SelectedIndexChanged += cbOcjenaOd_SelectedIndexChanged;
            // 
            // cbOcjenaDo
            // 
            cbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaDo.FormattingEnabled = true;
            cbOcjenaDo.Items.AddRange(new object[] { "10", "9", "8", "7", "6" });
            cbOcjenaDo.Location = new Point(183, 6);
            cbOcjenaDo.Name = "cbOcjenaDo";
            cbOcjenaDo.Size = new Size(71, 23);
            cbOcjenaDo.TabIndex = 1;
            cbOcjenaDo.SelectedIndexChanged += cbOcjenaDo_SelectedIndexChanged;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(395, 6);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(200, 23);
            dtpDatumOd.TabIndex = 2;
            dtpDatumOd.Value = new DateTime(2020, 1, 9, 15, 39, 0, 0);
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(628, 6);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(200, 23);
            dtpDatumDo.TabIndex = 3;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(834, 8);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(110, 19);
            chbAktivan.TabIndex = 4;
            chbAktivan.Text = "Student Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // dgvStudentiPredmeti
            // 
            dgvStudentiPredmeti.AllowUserToAddRows = false;
            dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPredmeti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Student, Predmet, Ocjena, Datum, Aktivan, Poruke });
            dgvStudentiPredmeti.Location = new Point(14, 35);
            dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            dgvStudentiPredmeti.ReadOnly = true;
            dgvStudentiPredmeti.RowTemplate.Height = 25;
            dgvStudentiPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPredmeti.Size = new Size(930, 275);
            dgvStudentiPredmeti.TabIndex = 5;
            dgvStudentiPredmeti.CellContentClick += dgvStudentiPredmeti_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Indeks";
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "StudentPodaci";
            Student.HeaderText = "Ime i prezime";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "PredmetPodaci";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 322);
            Controls.Add(dgvStudentiPredmeti);
            Controls.Add(chbAktivan);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(cbOcjenaDo);
            Controls.Add(cbOcjenaOd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbOcjenaOd;
        private ComboBox cbOcjenaDo;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private CheckBox chbAktivan;
        private DataGridView dgvStudentiPredmeti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
    }
}