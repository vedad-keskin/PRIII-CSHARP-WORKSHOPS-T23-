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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "frmStudentInfoIB180079";
            // 
            // lblStudent
            // 
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.Location = new System.Drawing.Point(26, 288);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(340, 30);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            this.lblProsjek.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProsjek.Location = new System.Drawing.Point(26, 321);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(340, 20);
            this.lblProsjek.TabIndex = 0;
            this.lblProsjek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(71, 58);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(241, 219);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // frmStudentInfoIB180079
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 354);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentInfoIB180079";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.frmStudentInfoIB180079_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private Label lblProsjek;
        private PictureBox pbSlika;
    }
}