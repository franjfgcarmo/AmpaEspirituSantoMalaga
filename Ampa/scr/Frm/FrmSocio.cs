using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ampa.Helper;
using Ampa.Modelo;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmSocio : FrmBase
    {
        //todo:Deshabilitar el botón de imprimir cuando es un usuario nuevo.
        //Cuando se importe el usuario, llamar al método load, en modo edición e iniciar el usuarioId
        public int? BaseSocioId { get;set; }
        private TipoEdicion _tipoEdicion;
        private bool _suppressAutoSelection;
        private readonly int _cursoId = Program.ActualCurso.Id;
        #region [Eventos de formulario]        
        public FrmSocio(TipoEdicion tipoEdicion, int? socioId=null)
        {
            _tipoEdicion = tipoEdicion;
            if (socioId == null)
            {
                using (var service = SocioService.GetInstance())
                {
                    BaseSocioId =
                        service.InsertSocioCurso(new CursosSociosModel
                        {
                            Observaciones = string.Empty,
                            PagoPorBanco = false,
                            SocioId = 0,
                            CursoId = _cursoId
                        });
                }
            }
            else
            {
              BaseSocioId = socioId;  
            }

            
            InitializeComponent();
            pnlImportarSocio.Visible = false;
            pnlTutores.Location.Offset(pnlTutores.Location.X, pnlTutores.Location.Y - pnlImportarSocio.Height);
            pnlAlumnos.Location.Offset(pnlAlumnos.Location.X, pnlAlumnos.Location.Y - pnlImportarSocio.Height);
            pnlPie.Location.Offset(pnlPie.Location.X, pnlPie.Location.Y - pnlImportarSocio.Height);
            Height = Height - pnlImportarSocio.Height;
        }

        private void FrmSocio_Load(object sender, EventArgs e)
        {
            CargaGrupo();
            using (var cursoService = CursoService.GetInstance())
            {
                btnImportarSocio.Enabled = cursoService.HayMasDeUnCurso();
            }
            BtnCancelarCambiosAlumnos.Enabled = false;
            btnCancelarCambiosTutor.Enabled = false;
            dgvAlumno.DefaultCellStyle.ForeColor = Color.Black;
            grdTutor.DefaultCellStyle.ForeColor = Color.Black;
            btnGuardarAlumno.Enabled = false;
            var socio = new SocioModel();
            switch (_tipoEdicion)
            {
                case TipoEdicion.Edicion:
                    using (var socioService = SocioService.GetInstance())
                    {
                        socio = socioService.ObtenerSocioPorAnyoSocioId(_cursoId, BaseSocioId.Value);
                    }
                    _suppressAutoSelection = true;
                    dgvAlumno.DataSource = socio.Alumnos;
                    dgvAlumno.Refresh();
                    grdTutor.DataSource = socio.Tutores;
                    grdTutor.Refresh();
                    txtObservaciones.Text = socio.Observaciones;
                    chkPagaPorBanco.Checked = socio.PagoPorBanco;
                    CambiaEstadoCamposTutor(false);
                    CambiaEstadoCamposAlumno(false);
                    _suppressAutoSelection = false;
                    if (dgvAlumno.Rows.Count > 0)
                    {
                        dgvAlumno.Rows[0].Selected = true;
                        dgvAlumno_SelectionChanged(dgvAlumno, null);
                    }
                    
                    grdTutor.Rows[0].Selected = true;
                    grdTutor_SelectionChanged_1(grdTutor, null);
                    CambiaEstadoCamposSocios(false);
                    BtnEditarSocio.Enabled = true;
                    BtnGuardarSocio.Enabled = false;
                    btnImportarSocio.Enabled = false;
                    btnImprimir.Enabled = true;                    
                    break;
                case TipoEdicion.Nuevo:
                    CambiaEstadoCamposTutor(true);
                    CambiaEstadoCamposAlumno(true);
                    CambiaEstadoCamposSocios(true);
                    btnNuevoAlumno.Enabled = false;
                    btnEditarAlumno.Enabled = false;
                    btnGuardarAlumno.Enabled = true;
                    btnNuevoTutor.Enabled = false;
                    btnEditarTutor.Enabled = false;
                    BtnGuardarSocio.Enabled = true;
                    BtnEditarSocio.Enabled = false;
                    BtnGuardarSocio.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnEliminarSocio.Enabled = false;
                    BtnEliminarTutor.Enabled = false;
                    BtnEliminarAlumno.Enabled = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void FrmSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: NO SE PUEDE CERRAR SI ESTÁ EN ESTADO NUEVO
            using (var service = TutorService.GetInstance())
            {
                service.ComprobarTutorPrincipal(BaseSocioId.Value, _cursoId);
            }
        }

        #endregion

        #region [Eventos de socios]
        private void btnBorrarSocio_Click(object sender, EventArgs e)
        {
            var resultMessage = MessageBox.Show(@"Va a eliminar todos los datos del socio, ¿Está seguro?",
                @"Eliminar socio",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultMessage != DialogResult.Yes) return;
            bool result;
            using (var service = SocioService.GetInstance())
            {
                result = service.EliminarSocio(BaseSocioId.Value, _cursoId);
            }
            if (result)
            {
                MessageBox.Show(@"El socio ha sido eliminado correctamente",
                    @"Eliminar socio",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(@"Ha ocurrido un error al eliminar el socio",
                  @"Eliminar socio",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grdImportarSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_suppressAutoSelection) return;
            var dvg = (DataGridView)sender;
            var socioId = 0;
            var cursoId = 0;
            if (dvg.CurrentRow != null)
            {
                var row = dvg.CurrentRow;
                socioId = int.Parse(row.Cells["SocioIdTutorAImportar"].Value.ToString());
                cursoId = int.Parse(row.Cells["CursoIdTutorAImportar"].Value.ToString());
            }
            if (socioId == 0 || cursoId == 0) return;


            bool result;
            using (var socioService = SocioService.GetInstance())
            {
                result = socioService.ImportarSocio(BaseSocioId.Value, _cursoId, socioId, cursoId);
            }
            if (result)
                MessageBox.Show(@"Socio importado correctamente", @"Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            pnlImportarSocio.Visible = false;
            pnlTutores.Location.Offset(pnlTutores.Location.X, pnlTutores.Location.Y - pnlImportarSocio.Height);
            pnlAlumnos.Location.Offset(pnlAlumnos.Location.X, pnlAlumnos.Location.Y - pnlImportarSocio.Height);
            pnlPie.Location.Offset(pnlPie.Location.X, pnlPie.Location.Y - pnlImportarSocio.Height);
            Height = Height - pnlImportarSocio.Height;
            _tipoEdicion = TipoEdicion.Edicion;
            FrmSocio_Load(null, null);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var txt = ((TextBox)sender).Text;
            if (string.IsNullOrWhiteSpace(txt)) return;
            List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.BusquedaTutoresPorNombre(txt.RemoveDiacritics(), _cursoId - 1);
            }
            _suppressAutoSelection = true;
            grdImportarSocios.DataSource = tutores;
            grdImportarSocios.Refresh();
            _suppressAutoSelection = false;
        }


        private void CambiaEstadoCamposSocios(bool estado)
        {
            txtObservaciones.Enabled = estado;
            chkPagaPorBanco.Enabled = estado;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var frmReport = new FrmReport(BaseSocioId.Value);
            frmReport.Show();
        }

        private void btnImportarSocio_Click(object sender, EventArgs e)
        {
            pnlImportarSocio.Visible = true;
            pnlTutores.Location.Offset(pnlTutores.Location.X, pnlTutores.Location.Y + pnlImportarSocio.Height);
            pnlAlumnos.Location.Offset(pnlAlumnos.Location.X, pnlAlumnos.Location.Y + pnlImportarSocio.Height);
            pnlPie.Location.Offset(pnlPie.Location.X, pnlPie.Location.Y + pnlImportarSocio.Height);
            Height = Height + pnlImportarSocio.Height;
            List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPrincipales(_cursoId-1);
            }
            _suppressAutoSelection = true;
            if (tutores.Count == 0) return;
            grdImportarSocios.DataSource = tutores;
            grdImportarSocios.Refresh();
            _suppressAutoSelection = false;
            textBox2.Focus();
        }

        private void BtnEditarSocio_Click(object sender, EventArgs e)
        {
            CambiaEstadoCamposSocios(true);
            BtnEditarSocio.Enabled = false;
            BtnGuardarSocio.Enabled = true;
        }

        private void BtnGuardarSocio_Click(object sender, EventArgs e)
        {
            using (var service = SocioService.GetInstance())
            {
                service.UpdateSocioCurso(new CursosSociosModel
                {
                    CursoId = _cursoId,
                    SocioId = BaseSocioId.Value,
                    PagoPorBanco = chkPagaPorBanco.Checked,
                    Observaciones = txtObservaciones.Text
                });
            }
            BtnEditarSocio.Enabled = true;
            BtnGuardarSocio.Enabled = false;
            CambiaEstadoCamposSocios(false);
            Close();
        }
        #endregion

        #region [Eventos de Alumnos]

        private void dgvAlumno_SelectionChanged(object sender, EventArgs e)
        {
            if (_suppressAutoSelection) return;
            LimpiarCamposAlumno();
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
            cmbGrupo.SelectedValue =alumno.GrupoId ?? 0;            
            CambiaEstadoCamposAlumno(false);
            btnEditarAlumno.Enabled = true;
            btnNuevoAlumno.Enabled = true;
            btnGuardarAlumno.Enabled = false;
        }

        private void BtnEliminarAlumno_Click(object sender, EventArgs e)
        {
            var resultMessage = MessageBox.Show(@"Va a eliminar el Alumno ¿Está seguro?",
                @"Eliminar Alumno",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultMessage != DialogResult.Yes) return;
            bool result;
            int alumnoId;
            var resultId = int.TryParse(TxtAlumnoId.Text, out alumnoId);
            using (var service = AlumnoService.GetInstance())
            {
                result = service.EliminarAlumno(alumnoId);
            }
            if (result)
            {
                MessageBox.Show(@"El Alumno ha sido eliminado correctamente",
                    @"Eliminar Alumno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Ha ocurrido un error al intentar eliminar el Alumno",
               @"Eliminar Alumno",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefrescarGridAlumno();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            txtNombreAlumno.Focus();
            LimpiarCamposAlumno();
            CambiaEstadoCamposAlumno(true);
            btnEditarAlumno.Enabled = false;
            btnNuevoAlumno.Enabled = false;
            BtnEliminarAlumno.Enabled = false;
            btnGuardarAlumno.Enabled = true;
            BtnCancelarCambiosAlumnos.Enabled = true;
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            txtNombreAlumno.Focus();
            CambiaEstadoCamposAlumno(true);
            btnEditarAlumno.Enabled = false;
            btnNuevoAlumno.Enabled = false;
            BtnEliminarAlumno.Enabled = false;
            btnGuardarAlumno.Enabled = true;
            BtnCancelarCambiosAlumnos.Enabled = true;
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
                    SocioId = BaseSocioId.Value,
                    GrupoId = string.IsNullOrWhiteSpace(cmbGrupo.SelectedValue.ToString()) ? (int?)null :int.Parse(cmbGrupo.SelectedValue.ToString()),
                    CursoId=_cursoId
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
            RefrescarGridAlumno();
        }

        #endregion

        #region [Métodos Privados de Alumnos]

        private void RefrescarGridAlumno()
        {
            List<AlumnoModel> alumnos;
            using (var service = AlumnoService.GetInstance())
            {
                alumnos = service.ObtenerAlumnosPorSocioId(BaseSocioId.Value,_cursoId);
            }
            _suppressAutoSelection = true;
            dgvAlumno.DataSource = alumnos;
            dgvAlumno.Refresh();
            _suppressAutoSelection = false;
            if (dgvAlumno.Rows.Count > 0)
            {
             dgvAlumno.Rows[0].Selected = true;   
            }
            
            dgvAlumno_SelectionChanged(dgvAlumno, null);
            CambiaEstadoCamposTutor(false);
            btnEditarAlumno.Enabled = true;
            btnNuevoAlumno.Enabled = true;
            btnGuardarAlumno.Enabled = false;
            BtnEliminarAlumno.Enabled = true;
            BtnCancelarCambiosAlumnos.Enabled = false;
        }

        private void LimpiarCamposAlumno()
        {
            txtNombreAlumno.Text = string.Empty;
            txtApellidoAlumno.Text = string.Empty;
            txtCursoAlumno.Text = string.Empty;
            TxtAlumnoId.Text = string.Empty;
            cmbGrupo.DataSource = null;
            CargaGrupo();
        }

        private void CargaGrupo()
        {
              using (var grupoService = GrupoService.GetInstance())
            {
                cmbGrupo.DataSource = new BindingSource(grupoService.ObtenerGrupos(), null);
                cmbGrupo.DisplayMember = "Name";
                cmbGrupo.ValueMember = "Id";
            }
         
        }

        private void CambiaEstadoCamposAlumno(bool estado)
        {
            txtNombreAlumno.Enabled = estado;
            txtApellidoAlumno.Enabled = estado;
            txtCursoAlumno.Enabled = estado;
            cmbGrupo.Enabled = estado;
        }

        #endregion

        #region [Eventos Tutor]

        private void grdTutor_SelectionChanged_1(object sender, EventArgs e)
        {
            if (_suppressAutoSelection) return;
            LimpiarCamposTutor();
            var dvg = (DataGridView) sender;
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
            chkPrincipal.Checked = tutor.EsPrincipal;
            CambiaEstadoCamposTutor(false);
            btnEditarTutor.Enabled = true;
            btnNuevoTutor.Enabled = true;
            btnGuardarTutor.Enabled = false;
        }
        private void BtnEliminarTutor_Click(object sender, EventArgs e)
        {
            var resultMessage = MessageBox.Show(@"Va a eliminar el tutor ¿Está seguro?",
                           @"Eliminar tutor",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultMessage != DialogResult.Yes) return;
            bool result;
            int tutorId;
            var resultId = int.TryParse(txtTutorId.Text, out tutorId);
            using (var service = TutorService.GetInstance())
            {
                result = service.EliminarTutor(tutorId);
            }
            if (result)
            {
                MessageBox.Show(@"El tutor ha sido eliminado correctamente",
                    @"Eliminar tutor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Ha ocurrido un error al intentar eliminar el tutor",
               @"Eliminar tutor",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefrescarGridTutor();
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
                    EsPrincipal = chkPrincipal.Checked,
                    Movil = txtMovilTutor.Text,
                    Telefono = txtTelefonoTutor.Text,
                    SocioId = BaseSocioId.Value,
                    CursoId = _cursoId
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
            RefrescarGridTutor();
        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            txtNombreTutor.Focus();
            LimpiarCamposTutor();
            CambiaEstadoCamposTutor(true);
            btnEditarTutor.Enabled = false;
            btnNuevoTutor.Enabled = false;
            BtnEliminarTutor.Enabled = false;
            btnGuardarTutor.Enabled = true;
            btnCancelarCambiosTutor.Enabled = true;
        }

        private void btnEditarTutor_Click_1(object sender, EventArgs e)
        {
            txtNombreTutor.Focus();
            btnEditarTutor.Enabled = false;
            btnNuevoTutor.Enabled = false;
            BtnEliminarTutor.Enabled = false;
            btnGuardarTutor.Enabled = true;
            CambiaEstadoCamposTutor(true);
            btnCancelarCambiosTutor.Enabled = true;
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
            chkPrincipal.Enabled = estado;
        }

        private void LimpiarCamposTutor()
        {
            txtNombreTutor.Text = string.Empty;
            txtApellidoTutor.Text = string.Empty;
            txtTelefonoTutor.Text = string.Empty;
            txtMovilTutor.Text = string.Empty;
            txtEmailTutor.Text = string.Empty;
            txtTutorId.Text = string.Empty;
            chkPrincipal.Checked = false;
        }

        private void RefrescarGridTutor()
        {
            List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPorSocioId(_cursoId, BaseSocioId.Value);
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
            BtnEliminarTutor.Enabled = true;
            btnCancelarCambiosTutor.Enabled = false;
        }

        #endregion        

        private void btnCancelarCambiosTutor_Click(object sender, EventArgs e)
        {
            btnGuardarTutor.Enabled = false;
            btnEditarTutor.Enabled = true;
            btnNuevoTutor.Enabled = true;
            btnCancelarCambiosTutor.Enabled = false;
            BtnEliminarTutor.Enabled = true;
        }

        private void BtnCancelarCambiosAlumnos_Click(object sender, EventArgs e)
        {
            btnGuardarAlumno.Enabled = false;
            btnEditarAlumno.Enabled = true;
            btnNuevoAlumno.Enabled = true;
            BtnCancelarCambiosAlumnos.Enabled = false;
            BtnEliminarAlumno.Enabled = true;
        }

       
      
    }
}