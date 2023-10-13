using DLWMS.Data;
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
        private List<StudentiPredmetiIB180079> studentiPredmeti;
        DLWMSDbContext db = new DLWMSDbContext();
  

        public frmIzvjestajIB180079(List<StudentiPredmetiIB180079> studentiPredmeti)
        {
            InitializeComponent();
            this.studentiPredmeti = studentiPredmeti;
        }

        private void frmIzvjestajIB180079_Load(object sender, EventArgs e)
        {
            var tblStudentiP = new dsIzvjestajIB180079.dsStudentiPredmetiDataTable();

            for (int i = 0; i < studentiPredmeti.Count(); i++)
            {
                var Red = tblStudentiP.NewdsStudentiPredmetiRow();
                Red.Rb = (i + 1).ToString();
                Red.ImePrezime = studentiPredmeti[i].Student.ToString();
                Red.Predmet = studentiPredmeti[i].Predmet.ToString();
                Red.Datum = studentiPredmeti[i].Datum.ToString();
                Red.Ocjena = studentiPredmeti[i].Ocjena.ToString();
                tblStudentiP.Rows.Add(Red);
            }

            var rds = new ReportDataSource();
            rds.Value = tblStudentiP;
            rds.Name = "dsSP";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("broj", studentiPredmeti.Count().ToString()));
            rpc.Add(new ReportParameter("prosjek", studentiPredmeti.Average(x=>x.Ocjena).ToString() ));
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
