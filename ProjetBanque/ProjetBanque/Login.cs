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
            this.lblError.Text = "";
            this.txtEmail.BackColor = Color.FromArgb(255, 255, 255);
            this.txtPassword.BackColor = Color.FromArgb(255, 255, 255);

            DatabaseManagement database = new DatabaseManagement();

            database.OpenConnection();
            try
            {
                if (database.VerifyUser(this.txtEmail.Text, this.txtPassword.Text))
                {                   
                    this.Visible = false;
                    Home home = new Home();

                    home.lblEmail.Text = this.txtEmail.Text;
                    home.ShowDialog();

                    this.Close();
                }

                else
                {
                    this.lblError.Text = "Oups... Une erreur dans l'email ou le mot de passe a été détectée";
                    this.txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                    this.txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                }

                database.CloseConnection();
            }
            catch (UserDoesNotExistsException)
            {
                this.lblError.Text = "Oups... Une erreur dans l'email ou le mot de passe a été détectée";
                this.txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                this.txtPassword.BackColor = Color.FromArgb(255, 128, 128);
            }
            
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
