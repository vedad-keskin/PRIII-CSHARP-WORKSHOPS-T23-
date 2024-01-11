using DLWMS.Data.IspitIB180079;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private StudentiUvjerenjaIB180079 odabranoUvjerenje;


        public frmIzvjestaji(StudentiUvjerenjaIB180079 odabranoUvjerenje)
        {
            InitializeComponent();
            this.odabranoUvjerenje = odabranoUvjerenje;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("student", odabranoUvjerenje.Student.ToString()));
            rpc.Add(new ReportParameter("indeks", odabranoUvjerenje.Student.BrojIndeksa));
            rpc.Add(new ReportParameter("svrha", odabranoUvjerenje.Svrha));
            reportViewer1.LocalReport.SetParameters(rpc);



            reportViewer1.RefreshReport();
        }
    }
}
