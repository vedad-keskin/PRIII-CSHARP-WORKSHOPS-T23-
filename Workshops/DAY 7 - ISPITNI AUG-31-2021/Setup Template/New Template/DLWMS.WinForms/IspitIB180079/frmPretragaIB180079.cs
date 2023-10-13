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
using System.Transactions;
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
            UcitajSve();
        }

        private void UcitajSve()
        {
            studenti = db.Studenti.Include("Spol").ToList();

            if( studenti!= null)
            {
                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("Polozeni");
                tblStudenti.Columns.Add("Broj");
                tblStudenti.Columns.Add("Prosjek");

                int suma = 0;
                float brojac = 0;

                Student NajveciStudent = null;
                float NajveciProsjek = int.MinValue; // isto kao INT_MIN u c++ 

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var student = studenti[i];
                    string info = "";
                    var SveOcjene = db.StudentiPredmeti.Include("Predmet").Include("Student").ToList();

                    int sumaJednogStudenta = 0;
                    float brojacJednogStudenta = 0;

                    for (int j = 0; j < SveOcjene.Count(); j++)
                    {
                        if (SveOcjene[j].StudentId == student.Id)
                        {
                            info += $"{SveOcjene[j].Predmet.Naziv};";
                            suma += SveOcjene[j].Ocjena;
                            brojac++;

                            sumaJednogStudenta += SveOcjene[j].Ocjena;
                            brojacJednogStudenta++;
                        }
                    }

                float prosjek = brojacJednogStudenta == 0 ? 0 : sumaJednogStudenta / brojacJednogStudenta; // 

                    if(prosjek > NajveciProsjek) // 9 > 8
                    {
                        NajveciProsjek = prosjek; // 9
                        NajveciStudent = student; // benjamin
                    }


                    var Red = tblStudenti.NewRow();
                    Red["ImePrezime"] = student.ToString();
                    Red["Polozeni"] = info;
                    Red["Broj"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Count().ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x=>x.Ocjena).ToString();
                    tblStudenti.Rows.Add(Red);
                }



                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;

                lblNajveciStudent.Text = NajveciStudent == null ? "NOT SET" : NajveciStudent.ToString();
                lblProsjek.Text = brojac == 0 ? "0" : (suma / brojac).ToString();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();

            studenti = db.Studenti.Include("Spol").Where(x=> x.Ime.ToLower().Contains(filter)|| x.Prezime.ToLower().Contains(filter) || filter == "")   .ToList();

            if (studenti != null)
            {
                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("Polozeni");
                tblStudenti.Columns.Add("Broj");
                tblStudenti.Columns.Add("Prosjek");

                int suma = 0;
                float brojac = 0;

                Student NajveciStudent = null;
                float NajveciProsjek = int.MinValue; // isto kao INT_MIN u c++ 

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var student = studenti[i];
                    string info = "";
                    var SveOcjene = db.StudentiPredmeti.Include("Predmet").Include("Student").ToList();

                    int sumaJednogStudenta = 0;
                    float brojacJednogStudenta = 0;

                    for (int j = 0; j < SveOcjene.Count(); j++)
                    {
                        if (SveOcjene[j].StudentId == student.Id)
                        {
                            info += $"{SveOcjene[j].Predmet.Naziv};";
                            suma += SveOcjene[j].Ocjena;
                            brojac++;

                            sumaJednogStudenta += SveOcjene[j].Ocjena;
                            brojacJednogStudenta++;
                        }
                    }

                    float prosjek = brojacJednogStudenta == 0 ? 0 : sumaJednogStudenta / brojacJednogStudenta; 

                    if (prosjek > NajveciProsjek) 
                    {
                        NajveciProsjek = prosjek; 
                        NajveciStudent = student; 
                    }


                    var Red = tblStudenti.NewRow();
                    Red["ImePrezime"] = student.ToString();
                    Red["Polozeni"] = info;
                    Red["Broj"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Count().ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                    tblStudenti.Rows.Add(Red);
                }



                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;

                lblNajveciStudent.Text = NajveciStudent == null ? "NOT SET" : NajveciStudent.ToString();
                lblProsjek.Text = brojac == 0 ? "0" : (suma / brojac).ToString();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                List<string> samoglasnici = new List<string> { "u", "o", "i", "e", "a" }; 
                List<string> suglasnici = new List<string> { "q", "w", "r", "t", "z", "p", "š", "đ", "s", "d", "f", "g", "h", "j", "k", "l", "č", "ć", "ž", "y", "x", "c", "v", "b", "n","m" }; 
                List<string> znakovi = new List<string> { "?", "!", ">", "<", "*" }; 


                await Task.Run(() =>
                {
                    string info = txtInfo.Text.ToLower();
                    long brojacSamoglasnika = info.Where(x => samoglasnici.Contains(x.ToString())).Count();
                    long brojacSuglasnika = info.Where(x => suglasnici.Contains(x.ToString())).Count();
                    long brojacZnakova = info.Where(x => znakovi.Contains(x.ToString())).Count();


                    Action action = () =>
                    {
                        lblSamoglasnici.Text = brojacSamoglasnika.ToString();
                        lblSuglasnici.Text = brojacSuglasnika.ToString();
                        lblZnakovi.Text = brojacZnakova.ToString();
                    };
                    BeginInvoke(action);

                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtInfo, err, Kljucevi.ObaveznaVrijednost);
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = studenti[e.RowIndex];

            frmScanIspitaIB180079 frmScan = new frmScanIspitaIB180079(student);
            frmScan.ShowDialog();
        }
    }
}
