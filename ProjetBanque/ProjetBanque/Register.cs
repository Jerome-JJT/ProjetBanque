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
            
            if (this.txtPassword.Text != this.txtPasswordVerify.Text)
            {
                this.lblError.Text = "Oups.. il y a eu une erreur sur la verification du mot de passe";
            }
            else
            {
                this.lblError.Text = "";

                try
                {
                    DatabaseManagement database = new DatabaseManagement();

                    database.OpenConnection();

                    if (database.AddUser(this.txtEmail.Text, this.txtPassword.Text, "Public") != 0)
                    {
                        formRegisterOk formOK = new formRegisterOk();

                        formOK.lblEmail.Text = this.txtEmail.Text + ", vous êtes bien incrit-e";

                        formOK.ShowDialog(); 
                    }

                    database.CloseConnection();
                }
                catch (WrongEmailFormatException)
                {
                    this.lblError.Text = "Oups.. Votre email ne correspond pas a un email valide";
                }
            }


        }
        public void RegisterClose()
        {
            this.Close();
        }
    }
}
