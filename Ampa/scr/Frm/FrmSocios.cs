using System.Collections.Generic;
using System.Windows.Forms;
using Ampa.Classes;
using Ampa.Helper;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmSocios : FrmBase
    {
        private bool SuppressAutoSelection=false;
        public FrmSocios()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void FrmSocios_Load(object sender, System.EventArgs e)
        {
            List<Tutores> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.ObtenerTutoresPrincipales(2015);
            }
            SuppressAutoSelection = true;
            dgvSocios.DataSource = tutores;
            dgvSocios.Refresh();
            SuppressAutoSelection = false;
            dgvSocios.Rows[0].Selected = true;
        }

        private void dgvSocios_SelectionChanged(object sender, System.EventArgs e)
        {
            if (SuppressAutoSelection) return;
            var dvg = ((DataGridView) sender);
            var socioId = 0;
            if (dvg.CurrentRow!=null)
            {
                var row = dvg.CurrentRow;
                socioId = int.Parse(row.Cells["SocioId"].Value.ToString());
            }
            //if (dvg.CurrentCell.Selected)
            //{
            //    var row = dvg.cell[dvg.CurrentCell.RowIndex];
            //    socioId = int.Parse(row.Cells["SocioId"].Value.ToString());
            //}
            if (socioId == 0) return;
            List<Alumnos> alumnos;
            using (var service = AlumnosService.GetInstance())
            {
                alumnos = service.ObtenerAlumnosPorSocioId(socioId);
            }
            dgvAlumnos.DataSource = alumnos;
            dgvAlumnos.Refresh();
        }

        private void txtBusqueda_TextChanged(object sender, System.EventArgs e)
        {
            var txt = ((TextBox) sender).Text;
            if (string.IsNullOrWhiteSpace(txt)) return;
            List<Tutores> tutores;
            using (var service = TutorService.GetInstance())
            {
                tutores = service.BusquedaTutoresPorNombre(txt.RemoveDiacritics(), 2015);
            }
            SuppressAutoSelection = true;
            dgvSocios.DataSource = tutores;
            dgvSocios.Refresh();
            SuppressAutoSelection = false;
            //dgvSocios.Rows[0].Selected = true;
        }
    }
}
