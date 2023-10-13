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
        private StudentiUvjerenjaIB180079 uvjerenje;
        DLWMSDbContext db = new DLWMSDbContext();
      

        public frmIzvjestajIB180079(StudentiUvjerenjaIB180079 uvjerenje)
        {
            InitializeComponent();
            this.uvjerenje = uvjerenje;
        }

        private void frmIzvjestajIB180079_Load(object sender, EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("student",uvjerenje.Student.ToString()));
            rpc.Add(new ReportParameter("indeks",uvjerenje.Student.BrojIndeksa));
            rpc.Add(new ReportParameter("svrha",uvjerenje.Svrha));
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();

        }
    }
}
