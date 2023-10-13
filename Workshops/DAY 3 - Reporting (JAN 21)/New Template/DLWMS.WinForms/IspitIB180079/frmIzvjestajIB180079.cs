using DLWMS.Data;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajIB180079 : Form
    {
        private List<Student> _studenti;


        public frmIzvjestajIB180079(List<Student> studenti)
        {
            InitializeComponent();
            this._studenti = studenti;
        }

        private void frmIzvjestajIB180079_Load(object sender, EventArgs e)
        {
            var tblStudenti = new dsStudentiIB180079.dsStudentiDataTable();
            for (int i = 0; i < _studenti.Count(); i++)
            {
                var Red = tblStudenti.NewdsStudentiRow();
                Red.RB = (i + 1).ToString();
                Red.Indeks = _studenti[i].BrojIndeksa;
                Red.Ime = _studenti[i].Ime;
                Red.Prezime = _studenti[i].Prezime;
                Red.Godina = _studenti[i].GodinaStudija.ToString();
                Red.Spol = _studenti[i].Spol.Naziv;
                Red.Aktivan = _studenti[i].Aktivan == false ? "Ne" : "Da";
                tblStudenti.AdddsStudentiRow(Red);
                
            }
            var rpc = new ReportDataSource();
            rpc.Name = "dsStudent";
            rpc.Value = tblStudenti;
            reportViewer1.LocalReport.DataSources.Add(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
