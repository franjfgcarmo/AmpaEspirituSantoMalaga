using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ampa.Entities;

namespace Ampa.Frm
{
    public partial class FrmAcceso : Ampa.Frm.FrmBase
    {
        private readonly AmpaEntities _ampaEntities= new AmpaEntities();

        public FrmAcceso()
        {
            InitializeComponent();
        }

        private  void ctlButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) && string.IsNullOrWhiteSpace(txtPassword.Text)) { return;}

            var user =  _ampaEntities.Usuario.FirstOrDefaultAsync(w => w.Nombre.ToLower().Trim() == txtUser.Text.ToLower().Trim() && w.password.ToLower().Trim() == txtPassword.Text.ToLower().Trim());
            if (user == null) return;
            var frmSocios = new FrmSocios();
            frmSocios.Show();
            Close();
        }

        private  void FrmAcceso_Load(object sender, EventArgs e)
        {
           

        }
    }
}
