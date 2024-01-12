using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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
    public partial class frmPorukeIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPorukeIB180079> poruke;

        public frmPorukeIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmPorukeIB180079_Load(object sender, EventArgs e)
        {
            dgvPoruke.AutoGenerateColumns = false;
            cbPredmet.DataSource = db.Predmeti.ToList();
            lblStudent.Text = $"{student.Ime} {student.Prezime}";
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB180079.Include("Predmet").Include("Student")
                .Where(x => x.StudentId == student.Id && x.Validnost >= DateTime.Now)
                .ToList();

            if (poruke != null)
            {

                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }

            this.Text = $"Broj poruka: {poruke.Count()}";

            if(poruke.Count() == 0)
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;
            }

        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OdabranaPoruka = poruke[e.RowIndex];

            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabranu poruku ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiPorukeIB180079.Remove(OdabranaPoruka);
                    db.SaveChanges();
                }

            }

            UcitajPoruke();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmNovaPorukaIB180079 frmNova = new frmNovaPorukaIB180079(student);
            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajPoruke();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (poruke.Count() != 0)
            {
                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(poruke);
                frmIzvjestaj.ShowDialog();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                // 1. dio postavljamo thread i radimo sve sto je vezano za combobox

                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;   

                Thread t1 = new Thread(() => GenerisiPoruke(predmet));
                t1.Start();

            }
        }

        private void GenerisiPoruke(PredmetiIB180079 predmet)
        {
            // 2. dio sve kalkulacije i pohranjivanja

            Thread.Sleep(300);

            var brojPoruka = int.Parse(txtBroj.Text);
            var validnost = dtpValidnost.Value;
            var info = "";

            for (int i = 0; i < brojPoruka; i++)
            {

                var NovaPoruka = new StudentiPorukeIB180079()
                {
                    Validnost = validnost,
                    PredmetId = predmet.Id,
                    StudentId = student.Id,
                    Sadrzaj = $"{i+1}. GENERISANA PORUKA",
                    Hitnost = "Srednja",
                    Slika = poruke[0].Slika
                };

                db.StudentiPorukeIB180079.Add(NovaPoruka);
                db.SaveChanges();
                info += $"{validnost} -> generisana poruka za {student.Ime} {student.Prezime} na predmetu {predmet} {Environment.NewLine}";  

            }

            Action action = () =>
            {
                // 3. dio 
                // ispise, ucitavanja, mbox

                UcitajPoruke();
                txtInfo.Text = info;
                MessageBox.Show($"Uspješno ste generisali {brojPoruka} poruka","Infomacija",MessageBoxButtons.OK,MessageBoxIcon.Information);

            };
            BeginInvoke(action);


        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBroj,err,Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(cbPredmet, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(dtpValidnost, err, Kljucevi.ObaveznaVrijednost);
        }
    }
}
