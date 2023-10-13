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
        public frmPretragaIB180079()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            UcitajSve();
        }

        private void UcitajSve()
        {
            var StudentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();

            if(StudentiPredmeti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = StudentiPredmeti;
            }
            this.Text = $"Ukupno zapisa {StudentiPredmeti.Count()}";
        }

        private void UcitajStudente()
        {
            var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();

            var StudentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").Where(x=> 
            x.Predmet.Naziv.ToLower().Contains(filter) || filter == "")
                .ToList();

            if (StudentiPredmeti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = StudentiPredmeti;
            }
            this.Text = $"Ukupno zapisa {StudentiPredmeti.Count()}";
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(500);
                    var _od = int.Parse(txtOd.Text);
                    var _do = int.Parse(txtDo.Text);
                    long suma = 0;

                    for (int i = _od; i < _do; i++)
                    {
                        suma += i;
                    }


                    Action action = () =>
                    {
                        txtSuma.Text = suma.ToString();
                    };
                    BeginInvoke(action);
                });
                

            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtOd, err, "Obavezno polje") && Validator.ValidirajKontrolu(txtDo, err, "Obavezno polje");
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var predmet = dgvStudenti.SelectedRows[0].DataBoundItem as StudentiPredmetiIB180079;

            if(e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izbrisati ovaj predmet","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.StudentiPredmeti.Remove(predmet);
                    db.SaveChanges();
                }
                    UcitajStudente();
            }
        }
    }
}
