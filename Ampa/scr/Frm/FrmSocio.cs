using System;
using Ampa.Classes;

namespace Ampa.Frm
{
    public partial class FrmSocio : FrmBase
    {
        private TipoEdicion _tipoEdicion;
        public FrmSocio(TipoEdicion tipoEdicion)
        {
            _tipoEdicion = tipoEdicion;
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
    }
}