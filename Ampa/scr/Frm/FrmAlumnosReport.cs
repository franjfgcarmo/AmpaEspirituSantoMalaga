using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Ampa.Frm
{
    public partial class FrmAlumnosReport : FrmBase
    {
        private string _where;
        public FrmAlumnosReport()
        {
            InitializeComponent();
        }
        public FrmAlumnosReport(string where)
        {
            _where = where;
            InitializeComponent();
        }

        private void FrmAlumnosReport_Load(object sender, EventArgs e)
        {
            var dsTutores =
              Program.DbConnection.InitDataAdapter(
                  string.Format(@"Select *  From Alumnos 
                                        WHERE CursoId = {0} {1} Order by Apellidos",
                      Program.ActualCurso.Id, _where));
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"Report\Alumnos.rdlc";
            var rds = new ReportDataSource("DataSetAlumnos", dsTutores.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

    }
}
