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
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
            this.lblError.Text = "";

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.txtEmail.BackColor = Color.FromArgb(255, 255, 255);
            this.txtPassword.BackColor = Color.FromArgb(255, 255, 255);
            this.txtPasswordVerify.BackColor = Color.FromArgb(255, 255, 255);

            if (this.txtPassword.Text != this.txtPasswordVerify.Text)
            {
                this.lblError.Text = "Oups.. il y a eu une erreur sur la verification du mot de passe";
                this.txtPasswordVerify.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
               
                if (this.txtEmail.Text == "")
                {
                    this.txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                    this.lblError.Text = "Oups.. Vous avez oubliez de remplir certain champ";
                }
                if (this.txtPassword.Text == "")
                {
                    this.txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                    this.lblError.Text = "Oups.. Vous avez oubliez de remplir certain champ";
                }
                else if (this.txtPassword.Text.Count() < 8)
                {
                    this.lblError.Text = "Oups.. votre mot de passe est un petit peu trop court 8 char";
                    this.txtPassword.BackColor = Color.FromArgb(255, 128, 128);
                }
                
                else
                {
                    try
                    {
                        DatabaseManagement database = new DatabaseManagement();

                        database.OpenConnection();
                        try
                        {
                            if (database.AddUser(this.txtEmail.Text, this.txtPassword.Text, "Public") != 0)
                            {
                                formRegisterOk formOK = new formRegisterOk();

                                formOK.lblEmail.Text = this.txtEmail.Text + ", vous êtes bien incrit-e";

                                formOK.ShowDialog();

                                Close();
                            }

                            database.CloseConnection();
                        }
                        catch (UserAlreadyExistsException)
                        {
                            this.lblError.Text = "Oups.. Cette email est deja utilisée par une autre personne";
                            this.txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                        }

                    }
                    catch (WrongEmailFormatException)
                    {
                        this.lblError.Text = "Oups.. Votre email ne correspond pas a un email valide exemple@exemple";
                        this.txtEmail.BackColor = Color.FromArgb(255, 128, 128);
                    }
                }                  
            }
            

        }
        public void RegisterClose()
        {
            this.Close();
        }

        private void txtPasswordVerify_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
