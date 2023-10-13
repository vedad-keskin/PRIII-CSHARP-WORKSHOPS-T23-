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

namespace DLWMS.WinForms.IB180079
{
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();

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
            var SviStudenti = db.Studenti.Include("Spol").ToList();

            if(SviStudenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = SviStudenti;

            }


        }
        private void UcitajStudente()
        {
            var spol = cbSpol.SelectedItem.ToString(); // ***** Muski Zenski
            var aktivan = chbAktivan.Checked; // true / false
            var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();   // vedad    vedad

            var studenti = db.Studenti.Include("Spol").Where(x => (x.Spol.Naziv == spol) && 
            (x.Aktivan == aktivan)  && 
            (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter) || filter =="" ) 
            )
                
                
                .ToList();

            if(studenti != null)
            {

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }


        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
    }
}
