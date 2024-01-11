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
    public partial class frmNovoUvjerenjeIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmNovoUvjerenjeIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmNovoUvjerenjeIB180079_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var vrsta = cbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var uplatnica = ImageHelper.FromImageToByte(pbUplatnica.Image);

                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    StudentId = odabraniStudent.Id,
                    DatumVrijeme = DateTime.Now,
                    Print = false,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Uplatnica = uplatnica
                };

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();

                DialogResult = DialogResult.OK;

            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(cbVrsta, err, Kljucevi.ObaveznaVrijednost) && Validator.ValidirajKontrolu(pbUplatnica, err, Kljucevi.ObaveznaVrijednost);
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
