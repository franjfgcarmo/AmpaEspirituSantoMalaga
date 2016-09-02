using System.Linq;
using System.Windows.Forms;

namespace Ampa.Frm
{
    public partial class FrmInformes : FrmBase
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, System.EventArgs e)
        {
            var result =
                panel2.Controls.OfType<RadioButton>()
                    .Select(control => control as RadioButton)
                    .Count(radio => radio.Checked);
            if (result == 0)
            {
                MessageBox.Show(@"Debe seleccionar un informe a imprimir",
                    @"Informes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rdbTodosSocios.Checked)
                {
                    var frm = new FrmTutoresReport();
                    frm.Show();
                }
                if (rdbTodosAlumnos.Checked)
                {

                }
                if (rdbAlumnoPorClase.Checked)
                {

                }
                if (rdbAlumnoPorGrupo.Checked)
                {

                }
                if (rdbSociosPorClase.Checked)
                {

                }
                if (rdbSocioPorGrupo.Checked)
                {

                }
                if (rdbSociosBanco.Checked)
                {

                }
                if (rdbSociosObservaciones.Checked)
                {

                }
                if (rdbCorreos.Checked)
                {

                }

            }
        }
    }
}