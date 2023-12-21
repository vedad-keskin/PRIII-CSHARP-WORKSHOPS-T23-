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

            studentiPredmeti = db.StudentiPredmeti.Include("Predmet").Include("Student").ToList();


            if (studentiPredmeti != null)
            {





                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }

        }


        private void UcitajStudente()
        {
            var OcjenaOd = cbOcjenaOd.SelectedItem == null ? 6 : int.Parse(cbOcjenaOd.SelectedItem.ToString());
            var OcjenaDo = cbOcjenaDo.SelectedItem == null ? 10 : int.Parse(cbOcjenaDo.SelectedItem.ToString());
            var DatumOd = dtpDatumOd.Value;
            var DatumDo = dtpDatumDo.Value;

            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").Where(x =>
            (x.Ocjena >= OcjenaOd && x.Ocjena <= OcjenaDo) && (x.Datum >= DatumOd && x.Datum <= DatumDo)
            ).ToList();

            if (studentiPredmeti != null)
            {




                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }
            //            Ukoliko ne postoji niti jedan student koji zadovoljava uslove pretrage, korisnika je
            //            potrebno obavijestiti adekvatnom porukom npr: U periodu od 17.02.1999 –
            //            17.02.2023.godine ne postoje evidentirane ocjene u opsegu od 6 do 9 za bilo kojeg
            //            studenta.

            if (studentiPredmeti.Count() == 0)
            {
                MessageBox.Show($"U periodu od {dtpDatumOd.Value} - {dtpDatumDo.Value} .godine ne postoje evidentirane ocjene u opsegu od {cbOcjenaOd.SelectedItem} do {cbOcjenaDo.SelectedItem} za bilo kojeg studenta.", "Informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ako je jednostavna pretraga (ovaj sigurno ne radi kad je komplikovana pretraga)
            var studentPredmet = dgvStudentiPredmeti.SelectedRows[0].DataBoundItem as StudentiPredmetiIB180079;

            // ako pravimo custom colone (mislim da ovaj radi za oba )
            var studentP = studentiPredmeti[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                frmPorukeIB180079 frmPoruke = new frmPorukeIB180079(studentP.Student);
                frmPoruke.ShowDialog();
            }
        }
    }
}
