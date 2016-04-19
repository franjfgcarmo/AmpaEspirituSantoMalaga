using System;
using System.Windows.Forms;
using Ampa.ConnectionProvider;
using Ampa.Frm;
using Ampa.Modelo;

namespace Ampa
{
    internal static class Program
    {
        public static Connection DbConnection = new Connection();
        public static CursoModel ActualCurso;
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAcceso());
        }
    }
}