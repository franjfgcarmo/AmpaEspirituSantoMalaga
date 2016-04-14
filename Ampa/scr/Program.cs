using System;
using System.Linq;
using System.Windows.Forms;
using Ampa.Entities;
using Ampa.Frm;

namespace Ampa
{
    static class Program
    {
        public static AmpaEntities AmpaEntities= new AmpaEntities();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            AmpaEntities = new AmpaEntities();
            try
            {
                //Evita que el servicio esté parado.
                var user = AmpaEntities.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                
                
            }
            Application.Run(new FrmAcceso());
            
        }
    }
}
