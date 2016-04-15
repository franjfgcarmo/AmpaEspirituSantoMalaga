using System;
using Ampa.Modelo;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmSocio : FrmBase
    {
        private TipoEdicion _tipoEdicion;
        private int _socioId;
        public FrmSocio(TipoEdicion tipoEdicion,int socioId)
        {
            _tipoEdicion = tipoEdicion;
            _socioId = socioId;
            InitializeComponent();
        }

        private void grdSocios_DoubleClick(object sender, EventArgs e)
        {
            //Debe cargar todos los datos de un socio de otro año.
        }

        private void grdTutor_SelectionChanged(object sender, EventArgs e)
        {
            //Cada vez que mueva cargará los datos
        }

        private void btnEditarTutor_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSocio_Load(object sender, EventArgs e)
        {
            var socio = new Socio();
            switch (_tipoEdicion)
            {
                case TipoEdicion.Edicion:
                    using (var socioService = SocioService.GetInstance())
                    {
                        socio = socioService.ObtenerSocioPorAnyoSocioId(Program.ActualCurso.Id, _socioId);
                    }
                    dgvAlumno.DataSource = socio.Alumnos;
                    dgvAlumno.Refresh();
                    grdTutor.DataSource = socio.Tutores;
                    grdTutor.Refresh();
                    txtObservaciones.Text = socio.Observaciones;
                    chckPagaPorBanco.Checked = socio.PagoPorBanco;
                    break;
                case TipoEdicion.Nuevo:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCursoAlumno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}