using DLWMS.Data;
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
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbSpol.DataSource = db.Spolovi.ToList();
            UcitajSve();
        }

        private void UcitajSve()
        {

            studenti = db.Studenti.Include("Spol").ToList();


            if (studenti != null)
            {

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }

        }
        private void UcitajStudente()
        {
            // combobox iz baze --> ne moze baciti null

            var spol = cbSpol.SelectedItem.ToString();

            // dtp --> ne moze baciti null

            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;


            studenti = db.Studenti
                .Include("Spol")
                .Where(x => (x.Spol.Naziv == spol) &&
                (x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo))
                .ToList();


            if (studenti != null)
            {

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }
        }




        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniStudent = studenti[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                frmUvjerenjaIB180079 frmUvjerenje = new frmUvjerenjaIB180079(odabraniStudent);
                frmUvjerenje.ShowDialog();
            }
            else
            {
                frmStudentInfoIB180079 frmInfo = new frmStudentInfoIB180079(odabraniStudent);
                frmInfo.ShowDialog();
            }
        }
    }
}
