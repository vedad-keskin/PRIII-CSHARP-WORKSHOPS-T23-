using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
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
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPredmetiIB180079> studentiPredmeti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiPredmeti.AutoGenerateColumns = false;
            cbStudent.DataSource = db.Studenti.ToList();
            UcitajSve();
        }

        private void UcitajSve()
        {
            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();


            if(studentiPredmeti != null)
            {
                var tblStudentiPredmeti = new DataTable();
                tblStudentiPredmeti.Columns.Add("Rb");
                tblStudentiPredmeti.Columns.Add("ImePrezime");
                tblStudentiPredmeti.Columns.Add("Predmet");
                tblStudentiPredmeti.Columns.Add("Datum");
                tblStudentiPredmeti.Columns.Add("Ocjena");


                for (int i = 0; i < studentiPredmeti.Count(); i++)
                {
                    var studentPredmet = studentiPredmeti[i];

                    var Red = tblStudentiPredmeti.NewRow();
                    Red["Rb"] = (i + 1).ToString();
                    Red["ImePrezime"] = studentPredmet.Student.ToString();
                    Red["Predmet"] = studentPredmet.Predmet.ToString();
                    Red["Datum"] = studentPredmet.Datum.ToString();
                    Red["Ocjena"] = studentPredmet.Ocjena.ToString();
                    tblStudentiPredmeti.Rows.Add(Red);

                }


                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = tblStudentiPredmeti;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcitajStudente();

        
            
        }

        private void UcitajStudente()
        {
        var ocjena = cbOcjena.SelectedItem == null ? 6 : int.Parse(cbOcjena.SelectedItem.ToString());


        studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").Where(x =>
        x.Ocjena >= ocjena).ToList();


        if (studentiPredmeti != null)
        {
            var tblStudentiPredmeti = new DataTable();
            tblStudentiPredmeti.Columns.Add("Rb");
            tblStudentiPredmeti.Columns.Add("ImePrezime");
            tblStudentiPredmeti.Columns.Add("Predmet");
            tblStudentiPredmeti.Columns.Add("Datum");
            tblStudentiPredmeti.Columns.Add("Ocjena");


            for (int i = 0; i < studentiPredmeti.Count(); i++)
            {
                var studentPredmet = studentiPredmeti[i];

                var Red = tblStudentiPredmeti.NewRow();
                Red["Rb"] = (i + 1).ToString();
                Red["ImePrezime"] = studentPredmet.Student.ToString();
                Red["Predmet"] = studentPredmet.Predmet.ToString();
                Red["Datum"] = studentPredmet.Datum.ToString();
                Red["Ocjena"] = studentPredmet.Ocjena.ToString();
                tblStudentiPredmeti.Rows.Add(Red);

            }


            dgvStudentiPredmeti.DataSource = null;
            dgvStudentiPredmeti.DataSource = tblStudentiPredmeti;
            }
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentPredmet = studentiPredmeti[e.RowIndex];

            if(e.ColumnIndex == 5)
            {
               frmStudentSeminarskiIB180079 frmSeminarski = new frmStudentSeminarskiIB180079(studentPredmet);
                frmSeminarski.ShowDialog();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var student = cbStudent.SelectedItem as Student;
                Thread t1 = new Thread(() => PokreniMultithreading(student));
                t1.Start();

            }
        }

        private void PokreniMultithreading(Student student)
        {
            Thread.Sleep(500);
      
            string info = "";
            var broj = int.Parse(txtBroj.Text);
            var random = new Random();
        
            for (int i = 0; i < broj; i++)
            {
        
                var NoviStudentPredmet = new StudentiPredmetiIB180079()
                {
                    StudentId = student.Id,
                    Datum = DateTime.Now,
                    Ocjena = random.Next(6, 11), // odakle kreces --> do jedan vise 
                    PredmetId = random.Next(1, db.Predmeti.Count() + 1)
                };
        
                var SviPredmeti = db.Predmeti.ToList();
        
                info += $"Za {student} dodat polozeni -> {SviPredmeti[NoviStudentPredmet.PredmetId - 1]}       ({NoviStudentPredmet.Ocjena})  {Environment.NewLine}";
        
        
        
                db.StudentiPredmeti.Add(NoviStudentPredmet);
                db.SaveChanges();
        
            }
        
            Action action = () =>
            {
                UcitajStudente();
                txtInfo.Text = info;
                MessageBox.Show($"Generisano {broj} zapisa", "Informacija",     MessageBoxButtons.OK,MessageBoxIcon.Information);
            };
            BeginInvoke(action);
        
        
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBroj, err, Kljucevi.ObaveznaVrijednost);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(studentiPredmeti.Count() != 0)
            {
                frmIzvjestajIB180079 frmIzvjestaj = new frmIzvjestajIB180079(studentiPredmeti);
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}
