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
    public partial class frmNoviScanIspitaIB180079 : Form
    {
        private Student student;
        private KorisniciIspitiScanIB180079 ispit;
        DLWMSDbContext db = new DLWMSDbContext();
        bool pregled;



        public frmNoviScanIspitaIB180079(Student student, KorisniciIspitiScanIB180079 ispit = null) 
        {
            InitializeComponent();
            this.student = student;
            this.ispit = ispit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var predmet = cbPredmet.SelectedItem as PredmetiIB180079;

            if (Validiraj())
            {
                if (pregled)
                {
                    Close();
                }
                if (!pregled)
                {
                    var NoviIspit = new KorisniciIspitiScanIB180079()
                    {
                        StudentId = student.Id,
                        PredmetId = predmet.Id,
                        Napomena = txtNapomena.Text,
                        Varanje = chbVaranje.Checked,
                        Slika = ImageHelper.FromImageToByte(pbSlika.Image)
                    };
                    db.KorisniciIspitiScan.Add(NoviIspit);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtNapomena, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(pbSlika, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cbPredmet, err, Kljucevi.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNoviScanIspitaIB180079_Load(object sender, EventArgs e)
        {
            cbPredmet.DataSource = db.Predmeti.ToList();
            pregled = ispit == null ? false : true; // ako pregledamo ispit predled je true 
            // ako prvi put pohranjujemo neki ispit onda pregled je false

            if (pregled)
            {
                cbPredmet.SelectedItem = ispit.Predmet;
                txtNapomena.Text = ispit.Napomena;
                pbSlika.Image = ImageHelper.FromByteToImage(ispit.Slika);
                chbVaranje.Checked = ispit.Varanje;


                cbPredmet.Enabled = false;
                txtNapomena.Enabled = false;
                chbVaranje.Enabled = false;
                pbSlika.Enabled = false;
            }
            if (!pregled)
            {
                cbPredmet.Enabled = true;
                txtNapomena.Enabled = true;
                chbVaranje.Enabled = true;
                pbSlika.Enabled = true;
            }
        }
    }
}
