namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmUvjerenjaIB180079
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            dgvUvjerenja = new DataGridView();
            DatumVrijeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Print = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            txtBroj = new TextBox();
            txtSvrha = new TextBox();
            cbVrsta = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(630, 12);
            button1.Name = "button1";
            button1.Size = new Size(169, 23);
            button1.TabIndex = 0;
            button1.Text = "Novi zahtjev";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { DatumVrijeme, Vrsta, Svrha, Uplatnica, Print, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 46);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowTemplate.Height = 25;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenja.Size = new Size(787, 181);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // DatumVrijeme
            // 
            DatumVrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumVrijeme.DataPropertyName = "DatumVrijeme";
            DatumVrijeme.HeaderText = "Datum";
            DatumVrijeme.Name = "DatumVrijeme";
            DatumVrijeme.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Print
            // 
            Print.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Print.DataPropertyName = "Print";
            Print.HeaderText = "Printano";
            Print.Name = "Print";
            Print.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Briši";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.HeaderText = "";
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(cbVrsta);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 205);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(15, 94);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(748, 95);
            txtInfo.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(577, 46);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(186, 23);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(459, 47);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(103, 23);
            txtBroj.TabIndex = 2;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(249, 47);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(193, 23);
            txtSvrha.TabIndex = 2;
            // 
            // cbVrsta
            // 
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim predmetima", "Uvjerenje o statusu studenta" });
            cbVrsta.Location = new Point(15, 47);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(211, 23);
            cbVrsta.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 76);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 0;
            label5.Text = "Info : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 29);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 0;
            label4.Text = "Vrsta uvjerenja :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 29);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj zahtjeva";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Svrha izdavanja :";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(button1);
            Name = "frmUvjerenjaIB180079";
            Text = "frmUvjerenjaIB180079";
            Load += frmUvjerenjaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn DatumVrijeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Print;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox groupBox1;
        private ComboBox cbVrsta;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtInfo;
        private Button btnDodaj;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private ErrorProvider err;
    }
}