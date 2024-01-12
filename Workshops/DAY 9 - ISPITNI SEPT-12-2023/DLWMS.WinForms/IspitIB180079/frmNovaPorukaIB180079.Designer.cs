namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmNovaPorukaIB180079
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbHitnost = new ComboBox();
            cbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            txtSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Slika";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 0;
            label2.Text = "Poruka je validna do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 0;
            label3.Text = "Odaberite predmet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Sadržaj poruke";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Hitnost poruke";
            // 
            // cbHitnost
            // 
            cbHitnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHitnost.FormattingEnabled = true;
            cbHitnost.Items.AddRange(new object[] { "Niska", "Srednja", "Visoka" });
            cbHitnost.Location = new Point(12, 131);
            cbHitnost.Name = "cbHitnost";
            cbHitnost.Size = new Size(209, 23);
            cbHitnost.TabIndex = 1;
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 27);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(209, 23);
            cbPredmet.TabIndex = 1;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 76);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(209, 23);
            dtpValidnost.TabIndex = 2;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 184);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(209, 135);
            txtSadrzaj.TabIndex = 3;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(252, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(321, 292);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 4;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(314, 331);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 5;
            button1.Text = "Odustani";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(451, 331);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 5;
            button2.Text = "Sačuvaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 366);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(cbPredmet);
            Controls.Add(cbHitnost);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruka";
            Load += frmNovaPorukaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbHitnost;
        private ComboBox cbPredmet;
        private DateTimePicker dtpValidnost;
        private TextBox txtSadrzaj;
        private PictureBox pbSlika;
        private Button button1;
        private Button button2;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}