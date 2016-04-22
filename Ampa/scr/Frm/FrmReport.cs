using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Ampa.Frm
{
    public partial class FrmReport : FrmBase
    {
        private readonly int _socioId;

        public FrmReport(int socioId)
        {
            _socioId = socioId;
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            var dsTutores = Program.DbConnection.InitDataAdapter(
                string.Format("Select Nombre, Apellidos, Telefono, Movil,Email From Tutores Where  SocioId ={0} AND CursoId = {1}",
                    _socioId,Program.ActualCurso.Id));
            var dsAlumnos = Program.DbConnection.InitDataAdapter(
                string.Format("Select Nombre, Apellidos, Curso From Alumnos Where  SocioId ={0}  AND CursoId = {1}", _socioId, Program.ActualCurso.Id));
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"Report\Ficha.rdlc";
            var rdsTutores = new ReportDataSource("DataSetTutores", dsTutores.Tables[0]);
            var rdsAlumnos = new ReportDataSource("DataSetAlumnos", dsAlumnos.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdsTutores);
            reportViewer1.LocalReport.DataSources.Add(rdsAlumnos);

            reportViewer1.RefreshReport();
        }
    }
}