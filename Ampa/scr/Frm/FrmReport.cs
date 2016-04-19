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
            var ds=Program.DbConnection.InitDataAdapter(
                "Select Nombre, Apellidos, Telefono, Movil,Email From Tutores Where  SocioId =2 ");
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            //reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = @"Report\Ficha.rdlc";
            //reportViewer1.LocalReport.ReportPath = Server.MapPath("Report.rdlc");
            ReportDataSource rds = new ReportDataSource("DataSetTutores", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.DataBindings();
            //reportViewer1.LocalReport.Refresh();

            //    SqlCommand command =
            //    new SqlCommand(sqlSalesOrder, connection);

            //command.Parameters.Add(
            //    new SqlParameter("SalesOrderNumber",
            //    salesOrderNumber));

            //var salesOrderAdapter = new Con
            //    SqlDataAdapter(command);

            //salesOrderAdapter.Fill(dsSalesOrder, "SalesOrder");
            //    DataSet tutores
            this.reportViewer1.RefreshReport();
        }
    }
}
