using System;
using System.IO;
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
            try
            {
                var filePath = AppDomain.CurrentDomain.BaseDirectory + @"AppData\Ampa.mdb";
                var compactFile = AppDomain.CurrentDomain.BaseDirectory + @"AppData\db1.mdb";
                if (File.Exists(filePath))
                {
                    var db = new DAO.DBEngine();
                    db.CompactDatabase(filePath, compactFile);
                }
                if (!File.Exists(compactFile)) return;
                File.Delete(filePath);
                File.Move(compactFile, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}