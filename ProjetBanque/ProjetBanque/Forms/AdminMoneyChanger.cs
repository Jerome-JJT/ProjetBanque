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
    public partial class FrmAdminMoneyChanger : Form
    {
        User userInfos;

        /// <summary>
        /// AdminMoneyChanger form's class
        /// </summary>
        /// <param name="userInformations"></param>
        public FrmAdminMoneyChanger(User userInformations)
        {
            InitializeComponent();

            userInfos = userInformations;
        }

        private void cmdChangePassword_Click(object sender, EventArgs e)
        {
            int flag = 0;

            lblError.Text = "";

            txtUserEmail.BackColor = Color.FromArgb(255, 255, 255);

            if (txtUserEmail.Text.Trim() == "")
            {
                txtUserEmail.BackColor = Color.FromArgb(255, 128, 128);
                lblError.Text = "Champ(s) incomplet(s)";
                flag++;
            }
            if (flag == 0)
            {
                lblError.Text = "";
                txtUserEmail.BackColor = Color.FromArgb(255, 255, 255);

                try
                {
                    DatabaseManagement database = new DatabaseManagement();

                    database.OpenConnection();

                    /*if (database.ChangeAmount(lblUserEmail.Text.Trim(), updAmount.Value))
                    {
                        lblError.Text = "Le solde a été changé";
                        txtUserEmail.Text = "";
                    }
                    else
                    {
                        lblError.Text = "Utilisateur Introuvable";
                        txtUserEmail.BackColor = Color.FromArgb(255, 128, 128);
                    }*/

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
