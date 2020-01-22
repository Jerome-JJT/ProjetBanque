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
    /// Admin password changer form's class
    /// </summary>
    public partial class FrmAdminPasswordChanger : Form
    {
        User userInfos;

        /// <summary>
        /// Admin password changer form constructor
        /// </summary>
        /// <param name="userInformations">Inherit user informations to display from parent form</param>
        public FrmAdminPasswordChanger(User userInformations)
        {
            InitializeComponent();

            userInfos = userInformations;
        }

        private void cmdChangePassword_Click(object sender, EventArgs e)
        {
            int flag = 0;

            lblError.Text = "";

            txtUserEmail.BackColor = Color.FromArgb(255, 255, 255);
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
            if (txtUserEmail.Text.Trim() == "")
            {
                txtUserEmail.BackColor = Color.FromArgb(255, 128, 128);
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
                txtUserEmail.BackColor = Color.FromArgb(255, 255, 255);
                txtNewPassword.BackColor = Color.FromArgb(255, 255, 255);

                try
                {
                    DatabaseManagement database = new DatabaseManagement();

                    database = new DatabaseManagement();

                    database.OpenConnection();

                    if (database.ChangePassword(txtUserEmail.Text.Trim(), txtNewPassword.Text.Trim()))
                    {
                        lblError.Text = "Le mot de passe a été changé";
                        txtUserEmail.Text = "";
                        txtNewPassword.Text = "";
                        txtNewPasswordVerify.Text = "";
                    }
                    else
                    {
                        lblError.Text = "Utilisateur introuvable";
                        txtUserEmail.BackColor = Color.FromArgb(255, 128, 128);
                    }                  

                    database.CloseConnection();
                }
                catch (UnableToJoinDatabase)
                {
                    lblError.Text = "La base de données est injoignable";
                    txtUserEmail.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
        }
    }
}
