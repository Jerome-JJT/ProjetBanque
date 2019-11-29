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

        private string password = "";
        private string oldTextPassword = "";

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //If text is added
            if (txtPassword.Text.Length > oldTextPassword.Length)
            {
                //Get new informations
                int newCharIndex = txtPassword.SelectionStart - 1;
                string newChar = txtPassword.Text.Substring(newCharIndex, 1);

                //Add new char to password
                password = password.Insert(newCharIndex, newChar);

                //Update oldTextPassword to prevent repetition
                oldTextPassword = txtPassword.Text;

                //Write wildcards and add new char at the right place
                txtPassword.Text = new string('*', txtPassword.Text.Length - 1).Insert(newCharIndex, newChar);

                //Replace user's cursor after writing wildcards
                txtPassword.SelectionStart = newCharIndex + 1;

                //Start/Restart timer
                tmrPassword.Enabled = true;
                tmrPassword.Stop();
                tmrPassword.Start();
            }
            else if(txtPassword.Text.Length < oldTextPassword.Length)
            {
                //Get changed informations
                int deleteStart = txtPassword.SelectionStart;
                int deleteLength = oldTextPassword.Length - txtPassword.Text.Length;

                //Update oldTextPassword to prevent repetition
                oldTextPassword = txtPassword.Text;

                //Concatenate text before and after delete
                password = $"{password.Substring(0, deleteStart)}{password.Substring(deleteStart+deleteLength, txtPassword.Text.Length-deleteStart)}";
            }
        }

        private void tmrPassword_Tick(object sender, EventArgs e)
        {
            //Timer is necessary only when adding letter
            tmrPassword.Enabled = false;

            //Keep cursor position
            int backupSelection = txtPassword.SelectionStart;

            //Write wildcards and add new char at the right place
            txtPassword.Text = new string('*', txtPassword.Text.Length);

            //Replace user's cursor after writing wildcards
            txtPassword.SelectionStart = backupSelection;
        }
    }
}
