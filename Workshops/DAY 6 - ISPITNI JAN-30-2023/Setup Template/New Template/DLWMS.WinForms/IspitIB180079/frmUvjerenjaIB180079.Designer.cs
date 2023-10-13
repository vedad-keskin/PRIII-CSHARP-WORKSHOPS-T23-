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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUvjerenja = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uplatnica = new System.Windows.Forms.DataGridViewImageColumn();
            this.Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Printaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Novi zahtjev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUvjerenja
            // 
            this.dgvUvjerenja.AllowUserToAddRows = false;
            this.dgvUvjerenja.AllowUserToDeleteRows = false;
            this.dgvUvjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUvjerenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Vrsta,
            this.Svrha,
            this.Uplatnica,
            this.Print,
            this.Brisi,
            this.Printaj});
            this.dgvUvjerenja.Location = new System.Drawing.Point(12, 62);
            this.dgvUvjerenja.Name = "dgvUvjerenja";
            this.dgvUvjerenja.ReadOnly = true;
            this.dgvUvjerenja.RowTemplate.Height = 25;
            this.dgvUvjerenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUvjerenja.Size = new System.Drawing.Size(787, 229);
            this.dgvUvjerenja.TabIndex = 1;
            this.dgvUvjerenja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUvjerenja_CellContentClick);
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Vrijeme";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            this.Uplatnica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uplatnica.DataPropertyName = "Uplatnica";
            this.Uplatnica.HeaderText = "Uplatnica";
            this.Uplatnica.Name = "Uplatnica";
            this.Uplatnica.ReadOnly = true;
            // 
            // Print
            // 
            this.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Print.DataPropertyName = "Print";
            this.Print.HeaderText = "Printano";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
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
            // Printaj
            // 
            this.Printaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Printaj.HeaderText = "";
            this.Printaj.Name = "Printaj";
            this.Printaj.ReadOnly = true;
            this.Printaj.Text = "Printaj";
            this.Printaj.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Controls.Add(this.txtSvrha);
            this.groupBox1.Controls.Add(this.cbVrsta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavnje zahtjeva za izdavanjem uvjerenja";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 95);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(772, 90);
            this.txtInfo.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(657, 52);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(540, 53);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(111, 23);
            this.txtBroj.TabIndex = 2;
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(261, 53);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(273, 23);
            this.txtSvrha.TabIndex = 2;
            // 
            // cbVrsta
            // 
            this.cbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Items.AddRange(new object[] {
            "Uvjerenje o polozenim ispitima",
            "Uvjerenje o statusu studenta",
            "Uvjerenje o prosjeku studenta"});
            this.cbVrsta.Location = new System.Drawing.Point(6, 53);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(243, 23);
            this.cbVrsta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Broj zahtjeva :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Info :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Svrha uvjerenja :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta uvjerenja : ";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmUvjerenjaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUvjerenja);
            this.Controls.Add(this.button1);
            this.Name = "frmUvjerenjaIB180079";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uvjerenja";
            this.Load += new System.EventHandler(this.frmUvjerenjaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Print;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnDodaj;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private ComboBox cbVrsta;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ErrorProvider err;
    }
}