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
    /// This windows is design for register the user in the database 
    /// </summary>
    public partial class frmRegister : Form
    {
        private JsonData inheritJsonStorage;

        private string password = "";
        private string oldTextPassword = "";

        private string passwordVerify = "";
        private string oldTextPasswordVerify = "";

        /// <summary>
        /// This is the constructor of the register
        /// </summary>
        /// <param name="inheritStorage">This is all the information of the Json</param>
        public frmRegister(JsonData inheritStorage)
        {
            InitializeComponent();
            lblError.Text = "";

            inheritJsonStorage = inheritStorage;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            Location = inheritJsonStorage.RegisterWindowLocation;
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            txtEmail.BackColor = Color.FromArgb(255, 255, 255);
            txtPassword.BackColor = Color.FromArgb(255, 255, 255);
            txtPasswordVerify.BackColor = Color.FromArgb(255, 255, 255);

            if (password.Trim() != passwordVerify.Trim())
            {
                lblError.Text = "Les mots de passes sont différents";
                txtPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                if (txtEmail.Text.ToLower().Trim() == "")
                {
                    txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                    lblError.Text = "Champ(s) incomplet(s)";
                    //lblError.Text = "Erreur lors de la création du compte";                    
                }
                if (password.Trim() == "")
                {
                    txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                    lblError.Text = "Champ(s) incomplet(s)";
                    //lblError.Text = "Erreur lors de la création du compte";
                }
                if (passwordVerify.Trim() == "")
                {
                    txtPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
                    lblError.Text = "Champ(s) incomplet(s)";
                    //lblError.Text = "Erreur lors de la création du compte";
                }
                else if(password.Count() < 8)
                {
                    lblError.Text = "Votre mot de passe est trop court, 8 caractères minimum";
                    txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                    txtPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
                }
                    else
                {
                    try
                    {
                        DatabaseManagement database = new DatabaseManagement();
                        database.OpenConnection();

                        bool successCreation = database.AddUser(txtEmail.Text.ToLower().Trim(), password.Trim(), "Public");

                        database.CloseConnection();

                        if (successCreation)
                        {
                            formRegisterOk formOK = new formRegisterOk();

                            formOK.lblEmail.Text = $"{txtEmail.Text.ToLower().Trim()}, vous êtes bien incrit-e";

                            formOK.ShowDialog();

                            Close();
                        }

                        
                        lblError.Text = "Erreur lors de la création du compte";
                        txtEmail.BackColor = Color.FromArgb(255, 128, 128);

                    }
                    catch (UnableToJoinDatabase)
                    {
                        lblError.Text = "La base de données est injoignable";
                        txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                        txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                    }
                    catch (UserAlreadyExistsException)
                    {
                        //lblError.Text = "Oups.. Cette email est deja utilisée par une autre personne";
                        lblError.Text = "Erreur lors de la création du compte";
                    }
                    catch (WrongEmailFormatException)
                    {
                        lblError.Text = "Format d'email invalide ex. exemple@exemple";
                        txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                    }
                    catch (WrongAccountTypeException)
                    {
                        lblError.Text = "Erreur lors de la création du compte";
                    }
                }                  
            }
        }


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
            else if (txtPassword.Text.Length < oldTextPassword.Length)
            {
                //Get changed informations
                int deleteStart = txtPassword.SelectionStart;
                int deleteLength = oldTextPassword.Length - txtPassword.Text.Length;

                //Update oldTextPassword to prevent repetition
                oldTextPassword = txtPassword.Text;

                //Concatenate text before and after delete
                password = $"{password.Substring(0, deleteStart)}{password.Substring(deleteStart + deleteLength, txtPassword.Text.Length - deleteStart)}";
            }
        }

        private void txtPasswordVerify_TextChanged(object sender, EventArgs e)
        {
            //If text is added
            if (txtPasswordVerify.Text.Length > oldTextPasswordVerify.Length)
            {
                //Get new informations
                int newCharIndex = txtPasswordVerify.SelectionStart - 1;
                string newChar = txtPasswordVerify.Text.Substring(newCharIndex, 1);

                //Add new char to password
                passwordVerify = passwordVerify.Insert(newCharIndex, newChar);

                //Update oldTextPassword to prevent repetition
                oldTextPasswordVerify = txtPasswordVerify.Text;

                //Write wildcards and add new char at the right place
                txtPasswordVerify.Text = new string('*', txtPasswordVerify.Text.Length - 1).Insert(newCharIndex, newChar);

                //Replace user's cursor after writing wildcards
                txtPasswordVerify.SelectionStart = newCharIndex + 1;

                //Start/Restart timer
                tmrPasswordVerify.Enabled = true;
                tmrPasswordVerify.Stop();
                tmrPasswordVerify.Start();
            }
            else if (txtPasswordVerify.Text.Length < oldTextPasswordVerify.Length)
            {
                //Get changed informations
                int deleteStart = txtPasswordVerify.SelectionStart;
                int deleteLength = oldTextPasswordVerify.Length - txtPasswordVerify.Text.Length;

                //Update oldTextPassword to prevent repetition
                oldTextPasswordVerify = txtPasswordVerify.Text;

                //Concatenate text before and after delete
                passwordVerify = $"{passwordVerify.Substring(0, deleteStart)}{passwordVerify.Substring(deleteStart + deleteLength, txtPasswordVerify.Text.Length - deleteStart)}";
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

        private void tmrPasswordVerify_Tick(object sender, EventArgs e)
        {
            //Timer is necessary only when adding letter
            tmrPasswordVerify.Enabled = false;

            //Keep cursor position
            int backupVerifySelection = txtPasswordVerify.SelectionStart;

            //Write wildcards and add new char at the right place
            txtPasswordVerify.Text = new string('*', txtPasswordVerify.Text.Length);

            //Replace user's cursor after writing wildcards
            txtPasswordVerify.SelectionStart = backupVerifySelection;
        }

    }
}
