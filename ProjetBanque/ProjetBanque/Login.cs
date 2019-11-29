using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace ProjetBanque
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            this.lblError.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();

            database.OpenConnection();

            if (database.VerifyUser(this.txtEmail.Text, this.txtPassword.Text))
            {
                this.lblError.Text = "";
                this.Visible = false;
                Home home = new Home();

                home.lblEmail.Text = this.txtEmail.Text;
                home.ShowDialog();

                this.Close();
            }

            else
            {
                this.lblError.Text = "Oups... Une erreur dans l'email ou le mot de passe a été détectée";
            }

            database.CloseConnection();
        }

        private void cmdGoRegister_Click(object sender, EventArgs e)
        {
            formRegister form = new formRegister();

            form.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            tmrPassword.Enabled = true;

            tmrPassword.Start();
            txtPassword.Text.Substring(txtPassword.Text.Length - 1, 1);

            tmrPassword.Stop();
        }
    }
}
