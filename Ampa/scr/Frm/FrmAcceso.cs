using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ampa.Entities;
using System.Threading;
namespace Ampa.Frm
{
    public partial class FrmAcceso : Ampa.Frm.FrmBase
    {
       // private readonly AmpaEntities _ampaEntities= new AmpaEntities();
        //Program.AmpaEntities = new AmpaEntities();
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new FrmSocios());
        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) && string.IsNullOrWhiteSpace(txtPassword.Text)) { return; }

            var user = Program.AmpaEntities.Usuarios.FirstOrDefault(w => w.Nombre.ToLower().Trim() == txtUser.Text.ToLower().Trim() && w.password.ToLower().Trim() == txtPassword.Text.ToLower().Trim());
            if (user == null) return;
            Close();
            var th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();        
        }
    }
}
