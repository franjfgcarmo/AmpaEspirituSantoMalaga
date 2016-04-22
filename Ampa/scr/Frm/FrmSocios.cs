using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ampa.Helper;
using Ampa.Modelo;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmSocios : FrmBase
    {
        //todo: mostrar un combo con los cursos académicos.
        //todo: corregir error cuando se importa un usuario y no exite todaví ninguno. 
        private bool _suppressAutoSelection;
        int _countForm = 0;
        private int  _cursoId= Program.ActualCurso.Id ;
        public FrmSocios()
        {
            InitializeComponent();
        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            CargaGridSocios();
        }

        #region [Eventos y métodos del Grid Tutor]
         public void CargaGridSocios(int? idRow=null)
        {
             List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPrincipales(_cursoId);
            }
            _suppressAutoSelection = true;
            lblCurso.Text = Program.ActualCurso.Descripcion;
            if (tutores.Count == 0) return;
            dgvSocios.DataSource = tutores;
            dgvSocios.Refresh();
            _suppressAutoSelection = false;
            dgvSocios.CurrentCell = dgvSocios.Rows[(int)(idRow != null ? idRow : 0)].Cells[5];
            dgvSocios_SelectionChanged(dgvSocios, null);
            var btn = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                Name = "btn",
                Width = 50,
                UseColumnTextForButtonValue = true
            };
            dgvSocios.Columns.Insert(dgvSocios.Columns.Count, btn);
        }
        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (_suppressAutoSelection) return;
            var dvg = (DataGridView) sender;
            var socioId = 0;
            if (dvg.CurrentRow != null)
            {
                var row = dvg.CurrentRow;
                socioId = int.Parse(row.Cells["SocioId"].Value.ToString());
            }
            if (socioId == 0) return;
            List<AlumnoModel> alumnos;
            using (var service = AlumnoService.GetInstance())
            {
                alumnos = service.ObtenerAlumnosPorSocioId(socioId,_cursoId);
            }
            dgvAlumnos.DataSource = alumnos;
            dgvAlumnos.Refresh();
        }
        private void dgvSocios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dvg = (DataGridView)sender;
            var socioId = 0;
            if (dvg.CurrentRow != null)
            {
                var row = dvg.CurrentRow;
                socioId = int.Parse(row.Cells["SocioId"].Value.ToString());
            }
            if (socioId == 0) return;
            var frm = new FrmSocio(TipoEdicion.Edicion, socioId);
            frm.Show();
        }
        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                dgvSocios_MouseDoubleClick(dgvSocios, null);
            }
        }
        #endregion

        #region [Eventos del Formulario]
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            var txt = ((TextBox) sender).Text;
            if (string.IsNullOrWhiteSpace(txt)) return;
            List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.BusquedaTutoresPorNombre(txt.RemoveDiacritics(), _cursoId);
            }
            _suppressAutoSelection = true;
            dgvSocios.DataSource = tutores;
            dgvSocios.Refresh();
            _suppressAutoSelection = false;
        }
        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            var frm = new FrmSocio(TipoEdicion.Nuevo);
            frm.Show();
        }
        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            var  resultMessage = MessageBox.Show(@"Va a crear un nuevo año académico, ¿Está seguro?", @"Crear nuevo años académico",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultMessage != System.Windows.Forms.DialogResult.Yes) return;
            using (var cursoServicio = CursoService.GetInstance())
            {
                if (cursoServicio.NuevoCurso())
                {
                    Program.ActualCurso = cursoServicio.ObtenerCursoAcademico();
                    _cursoId = Program.ActualCurso.Id;
                    dgvSocios.DataSource = null;
                    FrmSocios_Load(null, null);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var fc = Application.OpenForms;
            if (_countForm > fc.Count)
            {
                var id = dgvSocios.CurrentRow.Index;
                dgvSocios.Columns.Remove("btn");
                CargaGridSocios(id);
            }
            _countForm = fc.Count;
        }
        #endregion
    }
}