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
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPredmetiIB180079> studentiPredmeti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiPredmeti.AutoGenerateColumns = false;
            UcitajSve();
        }

        private void UcitajSve()
        {
            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();


            if (studentiPredmeti != null)
            {
                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }
        }
        private void UcitajStudente()
        {

            // checkbox ne vraca null --> dft false
            var aktivan = chbAktivan.Checked;

            // datetimepickeri ne mogu vratiti null --> zato sto je dft uvijek danasnji datum
            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;

            // rucni combobox koji moze baciti null -->
            var ocjenaOd = cbOcjenaOd.SelectedItem == null ? 6 : int.Parse(cbOcjenaOd.SelectedItem.ToString());
            var ocjenaDo = cbOcjenaDo.SelectedItem == null ? 10 : int.Parse(cbOcjenaDo.SelectedItem.ToString());

            studentiPredmeti = db.StudentiPredmeti.Include("Predmet").Include("Student")
                .Where(x => (x.Student.Aktivan == aktivan) &&
                (x.Datum >= datumOd && x.Datum <= datumDo) &&
                (x.Ocjena >= ocjenaOd && x.Ocjena <= ocjenaDo))
                .ToList();

            if (studentiPredmeti != null)
            {
                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }

            if (studentiPredmeti.Count() == 0)
            {
                if (aktivan == true)
                {
                    MessageBox.Show($"U periodu od {datumOd} - {datumDo} godine ne postoje evidentirane ocjene u opsegu {ocjenaOd} do {ocjenaDo} za bilo kojeg aktivnog studenta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"U periodu od {datumOd} - {datumDo} godine ne postoje evidentirane ocjene u opsegu {ocjenaOd} do {ocjenaDo} za bilo kojeg neaktivnog studenta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }


        private void cbOcjenaDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OdabraniStudentPredmet = studentiPredmeti[e.RowIndex];

            if(e.ColumnIndex == 6)
            {
                frmPorukeIB180079 frmPoruke = new frmPorukeIB180079(OdabraniStudentPredmet.Student);
                frmPoruke.ShowDialog();
            }

        }
    }
}
