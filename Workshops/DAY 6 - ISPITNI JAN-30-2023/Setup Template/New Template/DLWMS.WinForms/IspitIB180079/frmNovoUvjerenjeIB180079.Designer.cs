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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta uvjerenja : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Skenirana uplatnica : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Svrha uvjerenja : ";
            // 
            // cbVrsta
            // 
            this.cbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Items.AddRange(new object[] {
            "Uvjerenje o polozenim ispitima",
            "Uvjerenje o statusu studenta",
            "Uvjerenje o prosjeku studenta"});
            this.cbVrsta.Location = new System.Drawing.Point(12, 31);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(237, 23);
            this.cbVrsta.TabIndex = 1;
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(12, 90);
            this.txtSvrha.Multiline = true;
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(237, 266);
            this.txtSvrha.TabIndex = 2;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(286, 33);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(621, 279);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 3;
            this.pbSlika.TabStop = false;
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovoUvjerenjeIB180079";
            this.Text = "Novi zahtjev za izdavanje uvjerenja";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbVrsta;
        private TextBox txtSvrha;
        private PictureBox pbSlika;
        private Button button1;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}