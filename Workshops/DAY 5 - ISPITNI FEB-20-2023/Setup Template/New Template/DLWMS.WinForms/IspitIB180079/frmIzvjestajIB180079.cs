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
        private List<StudentiPorukeIB180079> poruke;

        public frmIzvjestajIB180079(List<StudentiPorukeIB180079> poruke)
        {
            InitializeComponent();
            this.poruke = poruke;
        }

        private void frmIzvjestajIB180079_Load(object sender, EventArgs e)
        {

            var tblPoruke = new dsIzvjestajIB180079.dsPorukeDataTable();
            for (int i = 0; i < poruke.Count(); i++)
            {
                var Red = tblPoruke.NewdsPorukeRow();
                Red.RB = (i + 1).ToString();
                Red.Predmet = poruke[i].Predmet.ToString();
                Red.Sadrzaj = poruke[i].Sadrzaj;
                Red.BrojZnakova = poruke[i].Sadrzaj.Count().ToString();
                Red.Validnost = poruke[i].Validnost.ToString();
                tblPoruke.Rows.Add(Red);
            }

            var rds = new ReportDataSource();
            rds.Value = tblPoruke;
            rds.Name = "dsPoruke";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Student", poruke[0].Student.ToString()));
            rpc.Add(new ReportParameter("broj", poruke.Count().ToString()));
            rpc.Add(new ReportParameter("prosjek", poruke.Average(x=> x.Sadrzaj.Count()).ToString() ));
            reportViewer1.LocalReport.SetParameters(rpc);


            this.reportViewer1.RefreshReport();

        }
    }
}
