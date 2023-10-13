namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmNoviScanIspitaIB180079
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
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.chbVaranje = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slika :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Napomena :";
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(12, 47);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(223, 23);
            this.cbPredmet.TabIndex = 1;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(12, 117);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(223, 188);
            this.txtNapomena.TabIndex = 2;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(265, 52);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(247, 253);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 3;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // chbVaranje
            // 
            this.chbVaranje.AutoSize = true;
            this.chbVaranje.Location = new System.Drawing.Point(12, 319);
            this.chbVaranje.Name = "chbVaranje";
            this.chbVaranje.Size = new System.Drawing.Size(64, 19);
            this.chbVaranje.TabIndex = 4;
            this.chbVaranje.Text = "Varanje";
            this.chbVaranje.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNoviScanIspitaIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbVaranje);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspitaIB180079";
            this.Text = "Scan ispita";
            this.Load += new System.EventHandler(this.frmNoviScanIspitaIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbPredmet;
        private TextBox txtNapomena;
        private PictureBox pbSlika;
        private CheckBox chbVaranje;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
    }
}