using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ampa.Helper;
using Ampa.Modelo;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmSocios : FrmBase
    {
        private int _countForm;
        private int _cursoId = Program.ActualCurso.Id;
        private bool _suppressAutoSelection;
        private bool cambioCurso;

        public FrmSocios()
        {
            InitializeComponent();
        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            CargaGridSocios();
            CargaCurso();
        }

        private void CargaCurso()
        {
            if (cambioCurso) return;
            cbmCurso.DataSource = null;
            List<CursoModel> cursoList;
            using (var service = CursoService.GetInstance())
            {
                cursoList = service.GetTodosLosCursos();
            }
            label2.Visible = cbmCurso.Visible = false;
            if (cursoList.Count <= 1) return;
            _suppressAutoSelection = true;
            label2.Visible = cbmCurso.Visible = true;

            cbmCurso.DataSource = new BindingSource(cursoList, null);
            cbmCurso.DisplayMember = "Descripcion";
            cbmCurso.ValueMember = "Id";
            _suppressAutoSelection = false;
        }

        private void cbmCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressAutoSelection) return;
            var cbm = (ComboBox) sender;
            cambioCurso = true;
            var curso = (CursoModel) cbm.SelectedItem;
            Program.ActualCurso = curso;
            _cursoId = Program.ActualCurso.Id;
            FrmSocios_Load(null, null);
        }

        #region [Eventos y métodos del Grid Tutor]

        public void CargaGridSocios(int? idRow = null)
        {
            List<TutorModel> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPrincipales(_cursoId);
            }
            _suppressAutoSelection = true;
            lblCurso.Text = Program.ActualCurso.Descripcion;            
            dgvSocios.DataSource = tutores;
            //dgvSocios.Refresh();
            _suppressAutoSelection = false;
            if (tutores.Count == 0) return;
            dgvSocios.CurrentCell = dgvSocios.Rows[(int) (idRow != null ? idRow : 0)].Cells[5];
            dgvSocios_SelectionChanged(dgvSocios, null);
            AnadirBotonEditar();
        }

        private void AnadirBotonEditar()
        {
            try
            {
                foreach (
                    var column in dgvSocios.Columns.Cast<DataGridViewColumn>().Where(column => column.Name == "btn"))
                {
                    dgvSocios.Columns.Remove("btn");
                }
            }
            catch (Exception)
            {
            }

            var btn = new DataGridViewButtonColumn
            {
                HeaderText = @"Editar",
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
                alumnos = service.ObtenerAlumnosPorSocioId(socioId, _cursoId);
            }
            dgvAlumnos.DataSource = alumnos;
            dgvAlumnos.Refresh();            
        }

        private void dgvSocios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dvg = (DataGridView) sender;
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
            if (e.ColumnIndex == 9)
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
           // dgvSocios.Refresh();
            AnadirBotonEditar();
            _suppressAutoSelection = false;
        }

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            var frm = new FrmSocio(TipoEdicion.Nuevo);
            frm.Show();
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            var resultMessage = MessageBox.Show(@"Va a crear un nuevo año académico, ¿Está seguro?",
                @"Crear nuevo años académico",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultMessage != DialogResult.Yes) return;
            using (var cursoServicio = CursoService.GetInstance())
            {
                if (cursoServicio.NuevoCurso())
                {
                    Program.ActualCurso = cursoServicio.ObtenerCursoAcademico();
                    _cursoId = Program.ActualCurso.Id;                    
                    FrmSocios_Load(null, null);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var fc = Application.OpenForms;
            if (_countForm > fc.Count)
            {
                var id = dgvSocios.CurrentRow != null ? dgvSocios.CurrentRow.Index : 0;
                //dgvSocios.Columns.Remove("btn");
                CargaGridSocios(id);
            }
            _countForm = fc.Count;
        }

        #endregion
    }
}