using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovaPorukaIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmNovaPorukaIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNovaPorukaIB180079_Load(object sender, EventArgs e)
        {
            cbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var hitnost = cbHitnost.SelectedItem.ToString();
                var predmet = cbPredmet.SelectedItem as PredmetiIB180079; // 1.Matematika, 2.PR, 3.OS 
                var validnost = dtpValidnost.Value;
                var sadrzaj = txtSadrzaj.Text;
                var slika = ImageHelper.FromImageToByte(pbSlika.Image);

                var NovaPoruka = new StudentiPorukeIB180079()
                {
                    Hitnost = hitnost,
                    Validnost = validnost,
                    Sadrzaj = sadrzaj,
                    Slika = slika,
                    PredmetId = predmet.Id,
                    StudentId = student.Id
                };

                db.StudentiPorukeIB180079.Add(NovaPoruka);
                db.SaveChanges();

                DialogResult = DialogResult.OK;


            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cbHitnost, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(cbPredmet, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(txtSadrzaj, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(pbSlika, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(dtpValidnost, err, Kljucevi.ObaveznaVrijednost);
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //               C://Desktop/Pictures/1297663.jpg
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
