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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            database.OpenConnection();

            formLogin form = new formLogin();

            if (database.VerifyUser(form.txtEmail.Text, form.txtPassword.Text))
            {

            }

            database.CloseConnection();
        }
    }
}
