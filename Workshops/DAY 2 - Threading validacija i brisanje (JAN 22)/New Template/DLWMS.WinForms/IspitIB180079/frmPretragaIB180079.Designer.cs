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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTeorija = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta : ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(117, 14);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(639, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Brisi,
            this.Slike});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 45);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 25;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(744, 191);
            this.dgvStudenti.TabIndex = 2;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Ime i prezime";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum polaganja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // Slike
            // 
            this.Slike.HeaderText = "";
            this.Slike.Name = "Slike";
            this.Slike.ReadOnly = true;
            this.Slike.Text = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSumiraj);
            this.groupBox1.Controls.Add(this.txtSuma);
            this.groupBox1.Controls.Add(this.txtDo);
            this.groupBox1.Controls.Add(this.txtOd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sumiraj brojeve";
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(233, 58);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(101, 23);
            this.btnSumiraj.TabIndex = 2;
            this.btnSumiraj.Text = "Sumiraj =>";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(350, 58);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(207, 23);
            this.txtSuma.TabIndex = 1;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(118, 58);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(100, 23);
            this.txtDo.TabIndex = 1;
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(6, 58);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(100, 23);
            this.txtOd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Do :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Od : ";
            // 
            // btnTeorija
            // 
            this.btnTeorija.Location = new System.Drawing.Point(652, 311);
            this.btnTeorija.Name = "btnTeorija";
            this.btnTeorija.Size = new System.Drawing.Size(101, 23);
            this.btnTeorija.TabIndex = 2;
            this.btnTeorija.Text = "Teorija";
            this.btnTeorija.UseVisualStyleBackColor = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(652, 257);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(101, 23);
            this.btnPrintaj.TabIndex = 2;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 356);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnTeorija);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretaga";
            this.Load += new System.EventHandler(this.frmPretragaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPretraga;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Slike;
        private GroupBox groupBox1;
        private Button btnSumiraj;
        private TextBox txtSuma;
        private TextBox txtDo;
        private TextBox txtOd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnTeorija;
        private Button btnPrintaj;
        private ErrorProvider err;
    }
}