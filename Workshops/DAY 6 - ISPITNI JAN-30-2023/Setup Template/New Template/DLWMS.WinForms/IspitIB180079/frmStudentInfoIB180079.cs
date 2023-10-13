using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB180079
{
    public partial class frmStudentInfoIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();

   

        public frmStudentInfoIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentInfoIB180079_Load(object sender, EventArgs e)
        {
            this.Text = $"{student.BrojIndeksa}";
            lblStudent.Text = $"{student}";
            lblProsjek.Text = $"Prosjek: {db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena)}";
            pbSlika.Image =  ImageHelper.FromByteToImage(student.Slika);

        }
    }
}
