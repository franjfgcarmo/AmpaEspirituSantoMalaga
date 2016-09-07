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
                    var frm = new FrmAlumnosReport();
                    frm.Show();                    
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
                    var grupo = panel1.Controls.OfType<RadioButton>()
                   .Select(control => control as RadioButton)
                   .Count(radio => radio.Checked);
                    if (grupo == 0)
                    {
                        MessageBox.Show(@"Debe seleccionar un informe a imprimir",
                            @"Informes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var radioSelected = panel1.Controls.OfType<RadioButton>()
                       .Select(control => control as RadioButton)
                       .FirstOrDefault(radio => radio.Checked);
                        var frm = new FrmTutoresReport("WHERE GrupoId = " + int.Parse(radioSelected.Tag.ToString()), true);
                        frm.Show();
                    }
                }
                if (rdbSociosBanco.Checked)
                {
                    var frm = new FrmTutoresReport("AND cs.PagoPorBanco = true");
                    frm.Show();
                }
                if (rdbSociosObservaciones.Checked)
                {
                    var frm = new FrmTutoresReport("AND cs.Observaciones IS NOT NULL");
                    frm.Show();
                }
                if (rdbCorreos.Checked)
                {
                    var frm = new FrmTutoresReport("AND cs.Email IS NOT NULL");
                    frm.Show();
                }

            }
        }
    }
}