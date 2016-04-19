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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            var dsTutores=Program.DbConnection.InitDataAdapter(
                "Select Nombre, Apellidos, Telefono, Movil,Email From Tutores Where  SocioId =2 ");
            var dsAlumnos = Program.DbConnection.InitDataAdapter(
                "Select Nombre, Apellidos, Curso From Alumnos Where  SocioId =2 ");
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            //reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = @"Report\Ficha.rdlc";
            //reportViewer1.LocalReport.ReportPath = Server.MapPath("Report.rdlc");
            ReportDataSource rdsTutores = new ReportDataSource("DataSetTutores", dsTutores.Tables[0]);
            ReportDataSource rdsAlumnos = new ReportDataSource("DataSetAlumnos", dsAlumnos.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdsTutores);
            reportViewer1.LocalReport.DataSources.Add(rdsAlumnos);
           
            this.reportViewer1.RefreshReport();
        }
    }
}
