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
    public partial class frmPorukeIB180079 : Form
    {
        private Student student; // Vedad -> 3 
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
            lblStudent.Text = student.ToString();
            cbPredmet.DataSource = db.Predmeti.ToList();
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB180079.Include("Predmet").Include("Student").Where(x=> 
            x.StudentId == student.Id  && x.Validnost > DateTime.Now)  
                
                .ToList(); 


            if(poruke != null)
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }

            this.Text = $"Ukupno poruka : {poruke.Count()}";
            if(poruke.Count() == 0)
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;

            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB180079 frmNova = new frmNovaPorukaIB180079(student);


            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajPoruke();
            }

        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var poruka = poruke[e.RowIndex];

            if(e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabranu poruku","Pitanje",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiPorukeIB180079.Remove(poruka);
                    db.SaveChanges();
                }
            }
            UcitajPoruke();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;


                Thread thread = new Thread(() => DodajPoruku(predmet));
                thread.Start();
            }
        }
        private void DodajPoruku(PredmetiIB180079 predmet)
        {
           
                    //threading / kalkulacije
                    Thread.Sleep(300);
                    string info = "";
                    var broj = int.Parse(txtBroj.Text); // 5

                    for (int i = 0; i < broj; i++)
                    {
                        var NovaPoruka = new StudentiPorukeIB180079
                        {
                            PredmetId = predmet.Id,
                            StudentId = student.Id,
                            Sadrzaj = $"{i + 1} GENERISANA PORUKA",
                            Validnost = dtpValidnost.Value,
                            Slika = poruke[0].Slika
                        };
                        db.StudentiPorukeIB180079.Add(NovaPoruka);
                        db.SaveChanges();
                        info += $"{dtpValidnost.Value} -> generisana poruka za {student} na predmetu {predmet} {Environment.NewLine}";
                    }
                    Action action = () =>
                    {
                        // ispis
                        UcitajPoruke();
                        MessageBox.Show($"Generisano je {broj} poruka studentu {student}", "Informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        txtInfo.Text = info;
                    };
                    BeginInvoke(action);
            
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBroj, err, Kljucevi.ObaveznaVrijednost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(poruke.Count() != 0)
            {
                frmIzvjestajIB180079 frmIzvjestaj = new frmIzvjestajIB180079(poruke);
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}
