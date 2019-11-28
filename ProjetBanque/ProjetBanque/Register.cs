﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBanque
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            database.OpenConnection();

            formRegister form = new formRegister();

            if(form.txtPassword != form.txtPasswordVerify)
            {
                form.lblError.Text = "Oups.. il y a eu une erreur sur la verification du mot de passe";
            }

            if (database.VerifyUser(form.txtEmail.Text, form.txtPassword.Text))
            {

            }

            database.CloseConnection();
        }
    }
}
