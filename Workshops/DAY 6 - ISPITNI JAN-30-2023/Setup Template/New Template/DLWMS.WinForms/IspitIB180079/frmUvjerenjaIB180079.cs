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
    public partial class frmUvjerenjaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student;
        List<StudentiUvjerenjaIB180079> uvjerenja;



        public frmUvjerenjaIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmUvjerenjaIB180079_Load(object sender, EventArgs e)
        {
            dgvUvjerenja.AutoGenerateColumns = false;
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenjaIB180079.Include("Student").Where(x=> x.StudentId == student.Id)   .ToList();

            if(uvjerenja != null)
            {

                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = uvjerenja;
            }
            if(uvjerenja.Count() == 0)
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
            frmNovoUvjerenjeIB180079 frmNova = new frmNovoUvjerenjeIB180079(student);
            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            }
           
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var uvjerenje = uvjerenja[e.RowIndex];

            if(e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabrano uvjerenje", "Pitanje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB180079.Remove(uvjerenje);
                    db.SaveChanges();
                }
            }
            if(e.ColumnIndex == 6)
            {
                frmIzvjestajIB180079 frmIzvjestaj = new frmIzvjestajIB180079(uvjerenje);
                frmIzvjestaj.ShowDialog();

                uvjerenje.Print = true;

                db.Entry(uvjerenje).State = EntityState.Modified;
                db.SaveChanges();
            }

            UcitajUvjerenja();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Validiraj()))
            {
                var vrsta = cbVrsta.SelectedItem.ToString();
                Thread t1 = new Thread(() => PosaljiPoruku(vrsta));
                t1.Start();

            }
        }
        private void PosaljiPoruku(string vrsta)
        {
                    Thread.Sleep(300);
                    var svrha = txtSvrha.Text;
                    var broj = int.Parse(txtBroj.Text);
                    string info = "";
                    for (int i = 0; i < broj; i++)
                    {
                        var NovoUvjerenje = new StudentiUvjerenjaIB180079()
                        {
                            StudentId = student.Id,
                            Svrha = svrha,
                            Vrsta = vrsta,
                            Vrijeme = DateTime.Now,
                            Print = false,
                            Uplatnica = uvjerenja[0].Uplatnica
                        };
                        db.StudentiUvjerenjaIB180079.Add(NovoUvjerenje);
                        db.SaveChanges();
                        info += $"{DateTime.Now.TimeOfDay} -> {vrsta} {student.BrojIndeksa} - {student} u svrhu {svrha} {Environment.NewLine}";
                    }
                    Action action = () =>
                    {
                        txtInfo.Text = info;
                        UcitajUvjerenja();
                        MessageBox.Show($"Generisano je {broj} zahtjeva.", "Informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    };
                    BeginInvoke(action);
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBroj, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cbVrsta, err, Kljucevi.ObaveznaVrijednost);
        }
    }
}
