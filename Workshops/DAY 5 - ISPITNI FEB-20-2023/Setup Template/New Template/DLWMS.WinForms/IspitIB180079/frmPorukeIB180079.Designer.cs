namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmPorukeIB180079
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Validnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.dtpValidnost = new System.Windows.Forms.DateTimePicker();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poruke studenta ";
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(114, 19);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(264, 15);
            this.lblStudent.TabIndex = 0;
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(725, 15);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(121, 23);
            this.btnNovaPoruka.TabIndex = 1;
            this.btnNovaPoruka.Text = "Nova poruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Sadrzaj,
            this.Slika,
            this.Validnost,
            this.Brisi});
            this.dgvPoruke.Location = new System.Drawing.Point(12, 49);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowTemplate.Height = 25;
            this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruke.Size = new System.Drawing.Size(834, 216);
            this.dgvPoruke.TabIndex = 2;
            this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Validnost
            // 
            this.Validnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Validnost.DataPropertyName = "Validnost";
            this.Validnost.HeaderText = "Validnost";
            this.Validnost.Name = "Validnost";
            this.Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.dtpValidnost);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Controls.Add(this.cbPredmet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje poruka : ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(8, 168);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(210, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj => ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(228, 41);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(589, 150);
            this.txtInfo.TabIndex = 4;
            // 
            // dtpValidnost
            // 
            this.dtpValidnost.Location = new System.Drawing.Point(9, 133);
            this.dtpValidnost.Name = "dtpValidnost";
            this.dtpValidnost.Size = new System.Drawing.Size(209, 23);
            this.dtpValidnost.TabIndex = 3;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(9, 41);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(209, 23);
            this.txtBroj.TabIndex = 2;
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(8, 86);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(210, 23);
            this.cbPredmet.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Info :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Poruka je validna :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Odaberite predmet : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Broj poruka :";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Printaj ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPorukeIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.btnNovaPoruka);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmPorukeIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poruke";
            this.Load += new System.EventHandler(this.frmPorukeIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private Button btnNovaPoruka;
        private DataGridView dgvPoruke;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private TextBox txtInfo;
        private DateTimePicker dtpValidnost;
        private TextBox txtBroj;
        private ComboBox cbPredmet;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ErrorProvider err;
        private Button button1;
    }
}