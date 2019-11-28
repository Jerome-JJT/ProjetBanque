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
            try{

            }
            catch (WrongEmailFormatException)
            {

            }
            if (this.txtPassword.Text != this.txtPasswordVerify.Text)
            {
                this.lblError.Text = "Oups.. il y a eu une erreur sur la verification du mot de passe";
            }
            this.lblError.Text = "";

            DatabaseManagement database = new DatabaseManagement();

            database.OpenConnection();           

            database.AddUser(this.txtEmail.Text, this.txtPassword.Text, "Public");           

            database.CloseConnection();

            formRegisterOk formOK = new formRegisterOk();

            formOK.ShowDialog();

            formOK.lblEmail.Text = this.txtEmail.Text + ", vous êtes bien incrit-e";
        }
    }
}
