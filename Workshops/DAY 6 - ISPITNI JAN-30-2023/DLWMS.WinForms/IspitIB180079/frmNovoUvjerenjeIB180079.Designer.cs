namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmNovoUvjerenjeIB180079
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
            cbVrsta = new ComboBox();
            txtSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            button1 = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 0;
            label2.Text = "Skenirana uplatnica : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Svrha izdavanja : ";
            // 
            // cbVrsta
            // 
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim predmetima", "Uvjerenje o statusu studenta" });
            cbVrsta.Location = new Point(12, 27);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(226, 23);
            cbVrsta.TabIndex = 1;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(12, 91);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(226, 164);
            txtSvrha.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(275, 28);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(490, 184);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(659, 232);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 272);
            Controls.Add(button1);
            Controls.Add(pbUplatnica);
            Controls.Add(txtSvrha);
            Controls.Add(cbVrsta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi zahtjev za izdavanjem uvjerenja";
            Load += frmNovoUvjerenjeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbVrsta;
        private TextBox txtSvrha;
        private PictureBox pbUplatnica;
        private Button button1;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}