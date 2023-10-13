using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmScanIspitaIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<KorisniciIspitiScanIB180079> ispiti;

        public frmScanIspitaIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmScanIspitaIB180079_Load(object sender, EventArgs e)
        {
            dgvIspiti.AutoGenerateColumns = false;
            lblStudent.Text = student.ToString();
            UcitajIspite();
        }

        private void UcitajIspite()
        {
            ispiti = db.KorisniciIspitiScan.Include("Predmet").Include("Student").Where(x=> x.StudentId == student.Id).ToList();

            if(ispiti != null)
            {
                dgvIspiti.DataSource = null;
                dgvIspiti.DataSource = ispiti;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNoviScanIspitaIB180079 frmNova = new frmNoviScanIspitaIB180079(student);

            if(frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajIspite();
            }
        }

        private void dgvIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ispit = ispiti[e.RowIndex];

            if(e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati ovaj zapis","Pitanje",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.KorisniciIspitiScan.Remove(ispit);
                    db.SaveChanges();
                }
            }
            else
            {
                frmNoviScanIspitaIB180079 frmNova = new frmNoviScanIspitaIB180079(student,ispit);
                frmNova.ShowDialog();
            }
            UcitajIspite();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ispiti.Count() != 0)
            {
                frmIzvjestajIB180079 frmIzvjestaj = new frmIzvjestajIB180079(ispiti);
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}
