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
    public partial class frmUvjerenjaIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB180079> uvjerenja;


        public frmUvjerenjaIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmUvjerenjaIB180079_Load(object sender, EventArgs e)
        {
            dgvUvjerenja.AutoGenerateColumns = false;
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenjaIB180079
                .Include("Student")
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();

            if (uvjerenja != null)
            {

                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = uvjerenja;
            }
            this.Text = $"Broj uvjerenja -> {uvjerenja.Count()}";

            if (uvjerenja.Count() == 0)
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovoUvjerenjeIB180079 frmNova = new frmNovoUvjerenjeIB180079(odabraniStudent);
            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                // comboboxovi i thread

                var vrsta = cbVrsta.SelectedItem.ToString();



                Thread t1 = new Thread(() => GenerisiUvjerenja(vrsta));
                t1.Start();

            }
        }

        private void GenerisiUvjerenja(string vrsta)
        {
            var svrha = txtSvrha.Text;
            var broj = int.Parse(txtBroj.Text);
            var info = "";

            for (int i = 0; i < broj; i++)
            {

                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    DatumVrijeme = DateTime.Now,
                    StudentId = odabraniStudent.Id,
                    Print = false,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Uplatnica = uvjerenja[0].Uplatnica
                };

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();

                info += $"{DateTime.Now.TimeOfDay} -> {vrsta} ({odabraniStudent.BrojIndeksa}) - {odabraniStudent} u {svrha} {Environment.NewLine}";

            }





            Action action = () =>
            {
                txtInfo.Text = info;
                UcitajUvjerenja();
                MessageBox.Show($"Generisali ste {broj} uvjerenja", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            BeginInvoke(action);



        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBroj, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cbVrsta, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost);
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranoUvjerenje = uvjerenja[e.RowIndex];

            if(e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati uvjerenje ? ","Pitanje",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiUvjerenjaIB180079.Remove(odabranoUvjerenje);
                    db.SaveChanges();
                }
            }

            if(e.ColumnIndex == 6)
            {
                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(odabranoUvjerenje);
                frmIzvjestaj.ShowDialog();

                odabranoUvjerenje.Print = true;

                db.Entry(odabranoUvjerenje).State = EntityState.Modified;
                db.SaveChanges();
            }

            UcitajUvjerenja();
        }
    }
}
