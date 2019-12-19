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
using System.IO;

namespace ProjetBanque
{
    /// <summary>
    /// This windows is design for login the user who is register in the database 
    /// </summary>
    public partial class frmLogin : Form
    {
        JsonManagement jsonFile = new JsonManagement();
        JsonData jsonStorage;

        private string password = "";
        private string oldTextPassword = "";

        /// <summary>
        /// This is the constructor of the login
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Text = "";

            try
            {
                jsonStorage = jsonFile.ExtractData();
                Location = jsonStorage.LoginWindowLocation;
            }
            catch (FileNotFoundException)
            {
                //If file doesn't exist
                jsonStorage = new JsonData();
                jsonFile.InsertData(jsonStorage);
            }
            catch(NullReferenceException)
            {
                //If the json file is empty
                jsonStorage = new JsonData();
                jsonFile.InsertData(jsonStorage);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            jsonStorage.LoginWindowLocation = Location;
            jsonFile.InsertData(jsonStorage);
        }


        private void cmdLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            txtEmail.BackColor = Color.FromArgb(255, 255, 255);
            txtPassword.BackColor = Color.FromArgb(255, 255, 255);

            try
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                bool allowConnection = database.VerifyUser(txtEmail.Text.ToLower().Trim(), password.Trim());

                database.CloseConnection();

                if (allowConnection)
                {                   
                    Visible = false;
                    frmHome homeForm = new frmHome(jsonStorage);

                    homeForm.lblEmail.Text = txtEmail.Text.ToLower().Trim();
                    homeForm.ShowDialog();

                    jsonStorage.HomeWindowLocation = homeForm.Location;
                    jsonStorage.HomeWindowSize = homeForm.Size;
                    jsonFile.InsertData(jsonStorage);

                    Close();
                }
                else
                {
                    //User and password doesn't match case
                    lblError.Text = "Login incorrect";
                    txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                    txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
            catch (UnableToJoinDatabase)
            {
                lblError.Text = "La base de données est injoignable";
                txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                txtPassword.BackColor = Color.FromArgb(255, 128, 128);
            }
            catch (UserDoesNotExistsException)
            {
                lblError.Text = "Login incorrect";
                txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                txtPassword.BackColor = Color.FromArgb(255, 128, 128);
            }
            
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister(jsonStorage);

            registerForm.ShowDialog();

            jsonStorage.RegisterWindowLocation = registerForm.Location;
            jsonFile.InsertData(jsonStorage);
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
