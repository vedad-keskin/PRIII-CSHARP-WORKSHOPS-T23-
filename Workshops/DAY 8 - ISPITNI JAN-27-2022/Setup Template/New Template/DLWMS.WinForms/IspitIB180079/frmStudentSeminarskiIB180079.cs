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
    public partial class frmStudentSeminarskiIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private StudentiPredmetiIB180079 studentPredmet;
        List<PredmetSeminarsi> seminarski;
        int brojac = 0;

       
        public frmStudentSeminarskiIB180079(StudentiPredmetiIB180079 studentPredmet)
        {
            InitializeComponent();
            this.studentPredmet = studentPredmet;
        }

        private void frmStudentSeminarskiIB180079_Load(object sender, EventArgs e)
        {
            lblStudent.Text = studentPredmet.Student.ToString();
            lblPredmet.Text = studentPredmet.Predmet.ToString();
            UcitajSeminarske();

            

            
        }

        private void UcitajSeminarske()
        {
            seminarski = db.PredmetSeminarski.Include("Predmet").Include("Student").Where(x => x.StudentId == studentPredmet.StudentId && x.PredmetId == studentPredmet.PredmetId).ToList();

            if(seminarski.Count() != 0)
            {
                var TrenutniSeminarski = seminarski[brojac];

                pbSlika.Image = ImageHelper.FromByteToImage(TrenutniSeminarski.Slika);
                lblDatum.Text = TrenutniSeminarski.Datum.ToString();
                lblOpis.Text = TrenutniSeminarski.Opis.ToString();



                 lblOd.Text = (brojac+1).ToString();
                 lblDo.Text = seminarski.Count().ToString();


            }
            else
            {
                lblOd.Text = "0";
                lblDo.Text = "0";
            }


        }

        private void pbSlikaNova_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlikaNova.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var NoviSeminarski = new PredmetSeminarsi()
                {
                    StudentId = studentPredmet.StudentId,
                    PredmetId = studentPredmet.PredmetId,
                    Datum = DateTime.Now,
                    Slika = ImageHelper.FromImageToByte(pbSlikaNova.Image),
                    Opis = txtOpisNovi.Text
                };
                db.PredmetSeminarski.Add(NoviSeminarski);
                db.SaveChanges();


                UcitajSeminarske();

                pbSlikaNova.Image = null;
                txtOpisNovi.Clear();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtOpisNovi, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(pbSlikaNova, err, Kljucevi.ObaveznaVrijednost);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(brojac + 1  >= seminarski.Count()) 
            {
                MessageBox.Show("Student nema vise slika","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                btnNext.Enabled = false;
            }
            else
            {
                 brojac++;
                 UcitajSeminarske();
                 btnBack.Enabled = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(brojac == 0)
            {
                MessageBox.Show("Ispred nema zapisa", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBack.Enabled = false;
            }
            else
            {
                brojac--;
                UcitajSeminarske();
                btnNext.Enabled = true;

            }
        }
    }
}
