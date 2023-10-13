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
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNajveciStudent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.lblSamoglasnici = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prosjek prikazanih ocjena : ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(117, 20);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(689, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Polozeni,
            this.Broj,
            this.Prosjek,
            this.Ispiti});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 60);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 25;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(794, 256);
            this.dgvStudenti.TabIndex = 2;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Polozeni.DataPropertyName = "Polozeni";
            this.Polozeni.HeaderText = "Polozeni predmeti";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            // 
            // Broj
            // 
            this.Broj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Broj.DataPropertyName = "Broj";
            this.Broj.HeaderText = "Broj polozenih";
            this.Broj.Name = "Broj";
            this.Broj.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Ispiti
            // 
            this.Ispiti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispiti.HeaderText = "";
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ispiti.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // lblProsjek
            // 
            this.lblProsjek.Location = new System.Drawing.Point(167, 327);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(210, 15);
            this.lblProsjek.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ime ili prezime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Najveci prosjek ostvario :";
            // 
            // lblNajveciStudent
            // 
            this.lblNajveciStudent.Location = new System.Drawing.Point(637, 327);
            this.lblNajveciStudent.Name = "lblNajveciStudent";
            this.lblNajveciStudent.Size = new System.Drawing.Size(181, 15);
            this.lblNajveciStudent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.lblZnakovi);
            this.groupBox1.Controls.Add(this.lblSuglasnici);
            this.groupBox1.Controls.Add(this.lblSamoglasnici);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generiši info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 37);
            this.txtInfo.MaxLength = 32767234;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(773, 84);
            this.txtInfo.TabIndex = 1;
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.Location = new System.Drawing.Point(306, 154);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(266, 15);
            this.lblZnakovi.TabIndex = 0;
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.Location = new System.Drawing.Point(268, 139);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(266, 15);
            this.lblSuglasnici.TabIndex = 0;
            // 
            // lblSamoglasnici
            // 
            this.lblSamoglasnici.Location = new System.Drawing.Point(285, 124);
            this.lblSamoglasnici.Name = "lblSamoglasnici";
            this.lblSamoglasnici.Size = new System.Drawing.Size(266, 15);
            this.lblSamoglasnici.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Znakovi (!,?,<,>,*) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Suglasnici : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Samoglasnici : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sadržaj info :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unesite sadržaj :";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmPretragaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblNajveciStudent);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
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
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Polozeni;
        private DataGridViewTextBoxColumn Broj;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn Ispiti;
        private Label lblProsjek;
        private Label label3;
        private Label label2;
        private Label lblNajveciStudent;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtInfo;
        private Label lblZnakovi;
        private Label lblSuglasnici;
        private Label lblSamoglasnici;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ErrorProvider err;
    }
}