using DLWMS.Data;
using DLWMS.WinForms.Helpers;
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
        List<Student> studenti;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPretragaIB180079()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            cbAktivnost.SelectedIndex = 0;
            cbGodina.SelectedIndex = 0;
            UcitajSve();
        }

        private void UcitajSve()
        {
            studenti = db.Studenti.Include("Spol").ToList();

            if(studenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }

            int suma = 0;
            float brojac = 0;

            var SviPolozeni = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();
            for (int i = 0; i < studenti.Count(); i++)
            {
                for (int j = 0; j < SviPolozeni.Count(); j++)
                {
                    if (SviPolozeni[j].StudentId == studenti[i].Id)
                    {
                        suma += SviPolozeni[j].Ocjena;
                        brojac++;
                    }
                }
            }

            lblBroj.Text = studenti.Count().ToString();
            lblProsjek.Text = brojac == 0 ? "0" : (suma / brojac).ToString();
        }
        private void UcitajStudente()
        {
            
             var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();
             var godina = cbGodina.SelectedItem == null ? "Sve" : cbGodina.SelectedItem.ToString();
            var aktivnost = cbAktivnost.SelectedItem == null ? "Svi" : cbAktivnost.SelectedItem.ToString(); 
             
            studenti = db.Studenti.Include("Spol").Where(x=> (x.Ime.ToLower().Contains(filter) || 
            x.Prezime.ToLower().Contains(filter) || filter == "") && (x.GodinaStudija.ToString() == godina || godina == "Sve")
            && ((x.Aktivan == false && aktivnost == "Neaktivni") || (x.Aktivan == true && aktivnost == "Aktivni") || aktivnost == "Svi")
                )  .ToList();

                if (studenti != null)
                {
                    dgvStudenti.DataSource = null;
                    dgvStudenti.DataSource = studenti;
                }

                int suma = 0;
                float brojac = 0;

                var SviPolozeni = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();
                for (int i = 0; i < studenti.Count(); i++)
                {
                    for (int j = 0; j < SviPolozeni.Count(); j++)
                    {
                        if (SviPolozeni[j].StudentId == studenti[i].Id)
                        {
                            suma += SviPolozeni[j].Ocjena;
                            brojac++;
                        }
                    }
                }
                lblBroj.Text = studenti.Count().ToString();
                lblProsjek.Text = brojac == 0 ? "0" : (suma / brojac).ToString();
               
            
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtPretraga, err, "Obavezno polje");
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }


        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(studenti.Count() != 0)
            {
                frmIzvjestajIB180079 frmIzvjestaj = new frmIzvjestajIB180079(studenti);
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}
