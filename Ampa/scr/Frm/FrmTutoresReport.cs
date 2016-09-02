using Microsoft.Reporting.WinForms;

namespace Ampa.Frm
{
    public partial class FrmTutoresReport : FrmBase
    {
        public FrmTutoresReport()
        {
            InitializeComponent();
        }

        private void FrmTutoresReport_Load(object sender, System.EventArgs e)
        {
            var dsTutores = Program.DbConnection.InitDataAdapter("Select Id,Nombre, Apellidos, Telefono, Movil,Email From Tutores ");            
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"Report\Tutores.rdlc";
            var rdsTutores = new ReportDataSource("DataSetTutores", dsTutores.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdsTutores);

            reportViewer1.RefreshReport();
        }
    }
}