using System;
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
    /// <summary>
    /// User profil form's class
    /// </summary>
    public partial class FrmProfil : Form
    {
        User userInfos;

        /// <summary>
        /// User profil form constructor
        /// </summary>
        /// <param name="userInformations">Inherit user informations to display from parent form</param>
        public FrmProfil(User userInformations)
        {
            InitializeComponent();

            userInfos = userInformations;
        }

        private void cmdDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir effacer votre compte ?\nVotre argent ne sera plus accessible.", 
                "Effacer votre compte", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                database.DisableAccount(userInfos.Email);

                database.CloseConnection();

                MessageBox.Show("Au revoir", "Merci");
                Application.Exit();
            }
        }

        private void cmdChangePassword_Click(object sender, EventArgs e)
        {
            int flag = 0;

            lblError.Text = "";

            txtOldPassword.BackColor = Color.FromArgb(255, 255, 255);
            txtNewPassword.BackColor = Color.FromArgb(255, 255, 255);
            txtNewPasswordVerify.BackColor = Color.FromArgb(255, 255, 255);

            if (txtNewPassword.Text.Trim() != txtNewPasswordVerify.Text.Trim())
            {
                lblError.Text = "Les mots de passes sont différents";
                txtNewPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
                flag++;
            }
            if (txtNewPassword.Text.Count() < 8)
            {
                lblError.Text = "Votre mot de passe est trop court, 8 caractères minimum";
                txtNewPassword.BackColor = Color.FromArgb(255, 128, 128);
                txtNewPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
                flag++;

            }
            if (txtOldPassword.Text.Trim() == "")
            {
                txtOldPassword.BackColor = Color.FromArgb(255, 128, 128);
                lblError.Text = "Champ(s) incomplet(s)";
                flag++;
            }
            if (txtNewPassword.Text.Trim() == "")
            {
                txtNewPassword.BackColor = Color.FromArgb(255, 128, 128);
                lblError.Text = "Champ(s) incomplet(s)";
                flag++;
            }
            if (txtNewPasswordVerify.Text.Trim() == "")
            {
                txtNewPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
                lblError.Text = "Champ(s) incomplet(s)";
                flag++;
            }
            if (flag == 0)
            {
                lblError.Text = "";
                txtOldPassword.BackColor = Color.FromArgb(255, 255, 255);
                txtNewPassword.BackColor = Color.FromArgb(255, 255, 255);

                try
                {
                    DatabaseManagement database = new DatabaseManagement();
                    database.OpenConnection();

                    bool allowConnection = database.VerifyUser(userInfos.Email, txtOldPassword.Text.Trim());

                    database.CloseConnection();

                    if (allowConnection)
                    {
                        database = new DatabaseManagement();
                        database.OpenConnection();

                        database.ChangePassword(userInfos.Email,txtNewPassword.Text.Trim());

                        database.CloseConnection();


                        lblError.Text = "Votre mot de passe a été changé";
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtNewPasswordVerify.Text = "";
                    }
                    else
                    {
                        //User and password doesn't match case
                        lblError.Text = "Login incorrect";
                        txtOldPassword.BackColor = Color.FromArgb(255, 128, 128);
                    }
                }
                catch (UnableToJoinDatabase)
                {
                    lblError.Text = "La base de données est injoignable";
                    txtOldPassword.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
        }
    }
}
