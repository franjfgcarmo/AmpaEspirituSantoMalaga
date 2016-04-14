﻿using System;
using System.Threading;
using System.Windows.Forms;
using Ampa.Services;

namespace Ampa.Frm
{
    public partial class FrmAcceso : FrmBase
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
            if (string.IsNullOrWhiteSpace(txtUser.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return;
            }
            using (var userService = UserService.GetInstance())
            {
                if (!userService.ExisteUsuario(txtUser.Text, txtPassword.Text))
                    return;
            }
           
            var th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }
    }
}