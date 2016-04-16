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
        private bool _suppressAutoSelection;

        public FrmSocios()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            List<Tutor> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPrincipales(Program.ActualCurso.Id);
            }
            _suppressAutoSelection = true;
            dgvSocios.DataSource = tutores;
            dgvSocios.Refresh();
            _suppressAutoSelection = false;
            dgvSocios.Rows[0].Selected = true;
            dgvSocios_SelectionChanged(dgvSocios, null);
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
            List<Alumno> alumnos;
            using (var service = AlumnoService.GetInstance())
            {
                alumnos = service.ObtenerAlumnosPorSocioId(socioId);
            }
            dgvAlumnos.DataSource = alumnos;
            dgvAlumnos.Refresh();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            var txt = ((TextBox) sender).Text;
            if (string.IsNullOrWhiteSpace(txt)) return;
            List<Tutor> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.BusquedaTutoresPorNombre(txt.RemoveDiacritics(), Program.ActualCurso.Id);
            }
            _suppressAutoSelection = true;
            dgvSocios.DataSource = tutores;
            dgvSocios.Refresh();
            _suppressAutoSelection = false;
            //dgvSocios.Rows[0].Selected = true;
        }

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
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
            var frm = new FrmSocio(TipoEdicion.Edicion,socioId);
            frm.Show();
        }
    }
}