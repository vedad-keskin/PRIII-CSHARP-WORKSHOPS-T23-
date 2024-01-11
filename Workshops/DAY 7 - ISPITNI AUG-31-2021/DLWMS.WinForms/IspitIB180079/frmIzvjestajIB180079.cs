using DLWMS.Data.IspitIB180079;
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
        private List<KorisniciIspitiScanIB180079> ispiti;

  

        public frmIzvjestajIB180079(List<KorisniciIspitiScanIB180079> ispiti)
        {
            InitializeComponent();
            this.ispiti = ispiti;
        }

        private void frmIzvjestajIB180079_Load(object sender, EventArgs e)
        {
            var tblIspiti = new dsIzvjestajIB180079.dsIspitiDataTable();
            for (int i = 0; i < ispiti.Count(); i++)
            {
                var Red = tblIspiti.NewdsIspitiRow();
                Red.Predmet = ispiti[i].Predmet.ToString();
                Red.Napomena = ispiti[i].Napomena.ToString();
                Red.Varanje = ispiti[i].Varanje == true ? "Da" : "Ne";
                tblIspiti.Rows.Add(Red);
            }

            var rds = new ReportDataSource();
            rds.Value = tblIspiti;
            rds.Name = "dsIspiti";
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();


        }
    }
}
