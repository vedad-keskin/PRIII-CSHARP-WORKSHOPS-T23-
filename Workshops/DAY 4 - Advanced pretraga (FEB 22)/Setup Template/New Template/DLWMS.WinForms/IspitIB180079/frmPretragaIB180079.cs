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
            UcitajSve();
        }

        private void UcitajSve()
        {
            studenti = db.Studenti.Include("Spol").ToList();

            if(studenti != null)
            {
                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("Student");
                tblStudenti.Columns.Add("GodinaStudija");
                tblStudenti.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var student = studenti[i];


                    var Red = tblStudenti.NewRow();
                    Red["Student"] = student.ToString();
                    Red["GodinaStudija"] = student.GodinaStudija.ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x=>x.StudentId == student.Id).Count() == 0 ? "5" :  db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                    tblStudenti.Rows.Add(Red);
                }



                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;

            }
        }


        private void UcitajStudente()
        {
            var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();
            var godina = cbGodina.SelectedItem == null ? 0 :  int.Parse(cbGodina.SelectedItem.ToString()); 

            studenti = db.Studenti.Include("Spol").Where(x=> (x.Ime.ToLower().Contains(filter) || 
            x.Prezime.ToLower().Contains(filter) || filter =="")  && (x.GodinaStudija == godina || godina == 0)).ToList();

            if (studenti != null)
            {
                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("Student");
                tblStudenti.Columns.Add("GodinaStudija");
                tblStudenti.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var student = studenti[i];


                    var Red = tblStudenti.NewRow();
                    Red["Student"] = student.ToString();
                    Red["GodinaStudija"] = student.GodinaStudija.ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? "5" : db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                    tblStudenti.Rows.Add(Red);
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;

            }
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
    }
}
