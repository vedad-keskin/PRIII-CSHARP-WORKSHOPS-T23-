namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmStudentInfoIB180079
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
            label1 = new Label();
            pbSlika = new PictureBox();
            lblProsjek = new Label();
            lblStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 0;
            label1.Text = "frmStudentInfoIB180079";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(60, 42);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(292, 256);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            // 
            // lblProsjek
            // 
            lblProsjek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProsjek.Location = new Point(60, 336);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(292, 35);
            lblProsjek.TabIndex = 2;
            lblProsjek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudent
            // 
            lblStudent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudent.Location = new Point(60, 301);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(292, 35);
            lblStudent.TabIndex = 2;
            lblStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 389);
            Controls.Add(lblStudent);
            Controls.Add(lblProsjek);
            Controls.Add(pbSlika);
            Controls.Add(label1);
            Name = "frmStudentInfoIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentInfoIB180079";
            Load += frmStudentInfoIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbSlika;
        private Label lblProsjek;
        private Label lblStudent;
    }
}