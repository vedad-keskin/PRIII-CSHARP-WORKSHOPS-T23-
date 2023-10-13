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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Godina studija :";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(108, 18);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(400, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // cbGodina
            // 
            this.cbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbGodina.Location = new System.Drawing.Point(641, 18);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(121, 23);
            this.cbGodina.TabIndex = 2;
            this.cbGodina.SelectedIndexChanged += new System.EventHandler(this.cbGodina_SelectedIndexChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.GodinaStudija,
            this.Prosjek,
            this.Konsultacije});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 52);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 25;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(750, 250);
            this.dgvStudenti.TabIndex = 3;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Ime ili prezime";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosječna ocjena";
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Konsultacije
            // 
            this.Konsultacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Konsultacije.HeaderText = "";
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.ReadOnly = true;
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 318);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.cbGodina);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPretraga;
        private ComboBox cbGodina;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn Konsultacije;
    }
}