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
        private Student odabraniStudent;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmStudentInfoIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmStudentInfoIB180079_Load(object sender, EventArgs e)
        {
            UcitajInfo();

        }

        private void UcitajInfo()
        {
            lblStudent.Text = odabraniStudent.ToString();
            lblProsjek.Text = $"Prosjek: {odabraniStudent.Prosjek}";
            pbSlika.Image = ImageHelper.FromByteToImage(odabraniStudent.Slika);
            this.Text = odabraniStudent.BrojIndeksa;
        }
    }
}
