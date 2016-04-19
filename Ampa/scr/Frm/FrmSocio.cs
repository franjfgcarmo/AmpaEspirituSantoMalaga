using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ampa.Modelo;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmSocio : FrmBase
    {
        private readonly int _socioId;
        private bool _suppressAutoSelection;
        private readonly TipoEdicion _tipoEdicion;

        public FrmSocio(TipoEdicion tipoEdicion, int socioId)
        {
            _tipoEdicion = tipoEdicion;
            _socioId = socioId;
            InitializeComponent();
        }

        private void FrmSocio_Load(object sender, EventArgs e)
        {
            dgvAlumno.DefaultCellStyle.ForeColor = Color.Black;
            grdTutor.DefaultCellStyle.ForeColor = Color.Black;
            btnGuardarAlumno.Enabled = false;
            btnEditarAlumno.Enabled = false;
            var socio = new SocioModel();
            switch (_tipoEdicion)
            {
                case TipoEdicion.Edicion:
                    using (var socioService = SocioService.GetInstance())
                    {
                        socio = socioService.ObtenerSocioPorAnyoSocioId(Program.ActualCurso.Id, _socioId);
                    }
                    _suppressAutoSelection = true;
                    dgvAlumno.DataSource = socio.Alumnos;
                    dgvAlumno.Refresh();
                    grdTutor.DataSource = socio.Tutores;
                    grdTutor.Refresh();
                    txtObservaciones.Text = socio.Observaciones;
                    chckPagaPorBanco.Checked = socio.PagoPorBanco;
                    CambiaEstadoCamposTutor(false);
                    CambiaEstadoCamposAlumno(false);
                    _suppressAutoSelection = false;
                    dgvAlumno.Rows[0].Selected = true;
                    dgvAlumno_SelectionChanged(dgvAlumno, null);
                    grdTutor.Rows[0].Selected = true;
                    grdTutor_SelectionChanged_1(grdTutor, null);
                    break;
                case TipoEdicion.Nuevo:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    #region [Eventos Tutor]
        private void grdTutor_SelectionChanged_1(object sender, EventArgs e)
        {
            if (_suppressAutoSelection) return;
            var dvg = (DataGridView)sender;
            var tutorId = 0;
            if (dvg.CurrentRow != null)
            {
                var row = dvg.CurrentRow;
                tutorId = int.Parse(row.Cells["Id"].Value.ToString());
            }
            if (tutorId == 0) return;
            TutorModel tutor;
            using (var service = TutorService.GetInstance())
            {
                tutor = service.ObtenerTutorById(tutorId);
            }
            LimpiarCamposTutor();
            txtNombreTutor.Text = tutor.Nombre;
            txtApellidoTutor.Text = tutor.Apellidos;
            txtTelefonoTutor.Text = tutor.Telefono;
            txtMovilTutor.Text = tutor.Movil;
            txtEmailTutor.Text = tutor.Email;
            txtTutorId.Text = tutor.Id.ToString();
        }
        private void btnGuardarTutor_Click(object sender, EventArgs e)
        {
            int tutorId;
            var result = int.TryParse(txtTutorId.Text, out tutorId);
            using (var service = TutorService.GetInstance())
            {
                var tutor = new TutorModel
                {
                    Nombre = txtNombreTutor.Text,
                    Id = tutorId,
                    Apellidos = txtApellidoTutor.Text,
                    Email = txtEmailTutor.Text,
                    EsPrincipal = false,
                    Movil = txtMovilTutor.Text,
                    Telefono = txtTelefonoTutor.Text,
                    SocioId = _socioId
                };
                if (result)
                {
                    service.Update(tutor);
                }
                else
                {
                    service.Insert(tutor);
                }
            }
            RefrescarGridTutor(tutorId);
        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            LimpiarCamposTutor();
            btnEditarTutor.Enabled = false;
            btnNuevoTutor.Enabled = false;
            btnGuardarTutor.Enabled = true;
        }

        private void btnEditarTutor_Click_1(object sender, EventArgs e)
        {
            btnEditarTutor.Enabled = false;
            btnNuevoTutor.Enabled = false;
            btnGuardarTutor.Enabled = true;
            CambiaEstadoCamposTutor(true);
        }

        #endregion

    #region [Métodos privados Tutor]

        private void CambiaEstadoCamposTutor(bool estado)
        {
            txtNombreTutor.Enabled = estado;
            txtApellidoTutor.Enabled = estado;
            txtTelefonoTutor.Enabled = estado;
            txtMovilTutor.Enabled = estado;
            txtEmailTutor.Enabled = estado;
        }
        private void LimpiarCamposTutor()
        {
            txtNombreTutor.Text = string.Empty;
            txtApellidoTutor.Text = string.Empty;
            txtTelefonoTutor.Text = string.Empty;
            txtMovilTutor.Text = string.Empty;
            txtEmailTutor.Text = string.Empty;
            txtTutorId.Text = string.Empty;
        }
        private void RefrescarGridTutor(int socioId)
        {
            List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPorSocioId(Program.ActualCurso.Id, socioId);
            }
            _suppressAutoSelection = true;
            grdTutor.DataSource = tutores;
            grdTutor.Refresh();
            _suppressAutoSelection = false;
            grdTutor.Rows[0].Selected = true;
            grdTutor_SelectionChanged_1(grdTutor, null);
            CambiaEstadoCamposTutor(false);
            btnEditarTutor.Enabled = true;
            btnNuevoTutor.Enabled = true;
            btnGuardarTutor.Enabled = false;
        }

        #endregion
        
        private void CambiaEstadoCamposAlumno(bool estado)
        {
            txtNombreAlumno.Enabled = estado;
            txtApellidoAlumno.Enabled = estado;
            txtCursoAlumno.Enabled = estado;
        }
        
        private void dgvAlumno_SelectionChanged(object sender, EventArgs e)
        {
            if (_suppressAutoSelection) return;
            var dvg = (DataGridView) sender;
            var alumnoId = 0;
            if (dvg.CurrentRow != null)
            {
                var row = dvg.CurrentRow;
                alumnoId = int.Parse(row.Cells["IdAlumno"].Value.ToString());
            }
            if (alumnoId == 0) return;
            AlumnoModel alumno;
            using (var service = AlumnoService.GetInstance())
            {
                alumno = service.ObtenerAlumnosPorId(alumnoId);
            }
            LimpiarCamposAlumno();
            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoAlumno.Text = alumno.Apellidos;
            txtCursoAlumno.Text = alumno.Curso;
            TxtAlumnoId.Text = alumno.Id.ToString();
        }
        private void LimpiarCamposAlumno()
        {
            txtNombreAlumno.Text = string.Empty;
            txtApellidoAlumno.Text = string.Empty;
            txtCursoAlumno.Text = string.Empty;
            TxtAlumnoId.Text = string.Empty;
        }
        private void RefrescarGridAlumno(int socioId)
        {
            List<AlumnoModel> alumnos;
            using (var service = AlumnoService.GetInstance())
            {
                alumnos = service.ObtenerAlumnosPorSocioId(socioId);
            }
            _suppressAutoSelection = true;
            dgvAlumno.DataSource = alumnos;
            dgvAlumno.Refresh();
            _suppressAutoSelection = false;
            dgvAlumno.Rows[0].Selected = true;
            dgvAlumno_SelectionChanged(grdTutor, null);
            CambiaEstadoCamposTutor(false);
            btnEditarAlumno.Enabled = true;
            btnNuevoAlumno.Enabled = true;
            btnGuardarAlumno.Enabled = false;
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCamposAlumno();
            btnEditarAlumno.Enabled = false;
            btnNuevoAlumno.Enabled = false;
            btnGuardarAlumno.Enabled = true;
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            CambiaEstadoCamposAlumno(true);
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            int alumnoId;
            var result = int.TryParse(TxtAlumnoId.Text, out alumnoId);
            using (var service = AlumnoService.GetInstance())
            {
                var alumno = new AlumnoModel
                {
                    Nombre = txtNombreAlumno.Text,
                    Id = alumnoId,
                    Apellidos = txtApellidoAlumno.Text,
                    Curso = txtCursoAlumno.Text,
                    SocioId = _socioId
                };
                if (result)
                {
                    service.Update(alumno);
                }
                else
                {
                    service.Insert(alumno);
                }
            }
            RefrescarGridAlumno(alumnoId);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var frmReport = new FrmReport();
            frmReport.Show();
        }    
    }
}