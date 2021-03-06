﻿using System;
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
    /// Admin money changer form's class
    /// </summary>
    public partial class FrmAdminMoneyChanger : Form
    {
        User userInfos;

        /// <summary>
        /// Admin money changer form constructor
        /// </summary>
        /// <param name="userInformations">Inherit user informations to display from parent form</param>
        public FrmAdminMoneyChanger(User userInformations)
        {
            InitializeComponent();

            userInfos = userInformations;
        }

        private void cmdChangeAmount_Click(object sender, EventArgs e)
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

                    if (database.ChangeMoney(txtUserEmail.Text.Trim(), (double)updAmount.Value))
                    {
                        lblError.Text = "Le solde a été changé";
                        txtUserEmail.Text = "";
                        updAmount.Value = 0;
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
