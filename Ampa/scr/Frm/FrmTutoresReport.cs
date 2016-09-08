using Microsoft.Reporting.WinForms;

namespace Ampa.Frm
{
    public partial class FrmTutoresReport : FrmBase
    {
        private  string _where;
        private readonly bool _inner;
        public FrmTutoresReport(string where)
        {
            _where = where;
            InitializeComponent();
        }
        public FrmTutoresReport(string where, bool inner )
        {
            _where = where;
            _inner = inner;
            InitializeComponent();
        }
        public FrmTutoresReport()
        {
            InitializeComponent();
        }
        private void FrmTutoresReport_Load(object sender, System.EventArgs e)
        {
            var innerJoin = string.Empty;
            var query = @"Select T.SocioId,T.Nombre, T.Apellidos, T.Telefono, T.Movil,T.Email 
                                        From Tutores T 
                                            INNER JOIN (CursosSocios CS {2})ON t.SocioId = cs.SocioId and t.CursoId = cs.CursoId
                                            
                                        WHERE cs.CursoId = {0} {1} Order by 1";
            if (_inner)
            {

                innerJoin = string.Format(@"INNER JOIN( (SELECT SocioID,CursoId FROM Alumnos  {0}) as a) on
                                            a.SocioId = cs.SocioId and a.CursoId = cs.CursoId", _where);               
                _where = string.Empty;
            }
            query = string.Format(query,Program.ActualCurso.Id, _where,innerJoin);
            var dsTutores =Program.DbConnection.InitDataAdapter(query);            
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"Report\Tutores.rdlc";
            var rdsTutores = new ReportDataSource("DataSetTutores", dsTutores.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdsTutores);

            reportViewer1.RefreshReport();
        }
    }
}