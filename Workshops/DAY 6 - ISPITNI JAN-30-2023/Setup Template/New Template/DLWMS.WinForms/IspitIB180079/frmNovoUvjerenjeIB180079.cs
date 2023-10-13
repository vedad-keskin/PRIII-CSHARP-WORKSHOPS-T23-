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
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();

     

        public frmNovoUvjerenjeIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    StudentId = student.Id,
                    Svrha = txtSvrha.Text,
                    Vrijeme = DateTime.Now,
                    Vrsta = cbVrsta.SelectedItem.ToString(),
                    Uplatnica = ImageHelper.FromImageToByte(pbSlika.Image),
                    Print = false
                };
                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;

            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cbVrsta, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(pbSlika, err, Kljucevi.ObaveznaVrijednost);
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
