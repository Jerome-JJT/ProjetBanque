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
    /// Home form's class
    /// </summary>
    public partial class FrmHome : Form
    {
        private JsonData inheritJsonStorage;
        private PublicUser userInformations;

        /// <summary>
        /// Home form constructor
        /// </summary>
        /// <param name="userInfos">Inherit user informations to display from parent form</param>
        /// <param name="inheritStorage">Inherit json informations to use from parent form</param>
        public FrmHome(PublicUser userInfos, JsonData inheritStorage)
        {
            InitializeComponent();

            cmdPay.Enabled = false;
            txtPayIban.Enabled = true;

            userInformations = userInfos;
            inheritJsonStorage = inheritStorage;

            cboPayList.SelectedIndex = 0;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Location = inheritJsonStorage.HomeWindowLocation;
            Size = inheritJsonStorage.HomeWindowSize;

            responsive();

            if (userInformations.GetType() == typeof(EnterpriseUser))
            { 
                displayEnterpriseLists();
            }
            updateInfos();
        }

        private void FrmHome_SizeChanged(object sender, EventArgs e)
        {
            responsive();
        }

        private void responsive()
        {
            datHistory.Location = new Point(10, 180);
            datHistory.Size = new Size(Convert.ToInt32((Size.Width - 40) / 1.6), Convert.ToInt32(Size.Height - 250));

            grpPayement.Location = new Point(Convert.ToInt32((Size.Width) / 1.6 + 10), 180);
            grpPayement.Size = new Size(Convert.ToInt32((Size.Width - 100) / 2.7), Convert.ToInt32(Size.Height - 300));

            cmdExit.Location = new Point(Convert.ToInt32(Size.Width - 145), Convert.ToInt32(Size.Height - 95));
            cmdExit.Size = new Size(120, 40);
        }


        private void updateInfos()
        {
            lblEmail.Text = userInformations.Email;

            lblIban.Text = userInformations.Iban;

            lblMoney.Text = "Votre solde s'élève a: " + userInformations.Money.ToString() + " CHF";

            datHistory.Rows.Clear();
            foreach (Transaction transaction in userInformations.Transactions)
            {
                string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                datHistory.Rows.Add(row);
            }

            if (userInformations.GetType() == typeof(EnterpriseUser))
            {
                cmdModifyList.Enabled = true;
                cboPayList.Enabled = true;

                if (cboPayList.SelectedIndex == 0 || cboPayList.SelectedIndex == -1)
                {
                    txtPayIban.Enabled = true;
                }
                else
                {
                    txtPayIban.Enabled = false;
                }

            }
        }

        private void displayEnterpriseLists()
        {
            int lastIndex = cboPayList.SelectedIndex;

            cboPayList.Items.Clear();
            cboPayList.Items.Add("Liste(s) de payements");

            foreach (UsersList eachList in ((EnterpriseUser)userInformations).Lists)
            {
                cboPayList.Items.Add(eachList);
            }

            cboPayList.SelectedIndex = lastIndex;
        }

        private void cboPayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateInfos();
            if (cboPayList.SelectedIndex != 0)
            {
                cmdPay.Enabled = true;
                lblListAmount.Text = "Vous allez payer: " + ((UsersList)cboPayList.SelectedItem).Users.Count() * updPayAmount.Value + " CHF";
            }
            else
            {
                cmdPay.Enabled = false;
                lblListAmount.Text = "";
            }
            
        }


        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPayIban_TextChanged(object sender, EventArgs e)
        {
            if (txtPayIban.Text.Count() == 8)
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                string destEmail = database.EmailFromIban(txtPayIban.Text.ToUpper());

                database.CloseConnection();

                if (destEmail != null && userInformations.Email != destEmail)
                {
                    lblEmailReceiver.Text = $"Vous allez faire un payement a :\n{destEmail}";

                    cmdPay.Enabled = true;
                }               
                else if (userInformations.Email == destEmail)
                {
                    lblEmailReceiver.Text = "Opération non possible";

                    cmdPay.Enabled = false;
                }
                else
                {
                    lblEmailReceiver.Text = "L'Iban que vous avez entré ne correspond à personne,\nveuillez vérifiez l'Iban";

                    cmdPay.Enabled = false;
                }
            }
            else
            {
                lblEmailReceiver.Text = "";

                cmdPay.Enabled = false;
            }
        }

        private void cmdPay_Click(object sender, EventArgs e)
        {
            if(cboPayList.SelectedIndex == 0 || cboPayList.SelectedIndex == -1)
            {
                if (userInformations.Money >= Convert.ToDouble(updPayAmount.Value))
                {
                    DatabaseManagement database = new DatabaseManagement();
                    database.OpenConnection();

                    bool success = database.Transact(Convert.ToDouble(updPayAmount.Value), txtPayReason.Text, userInformations.Iban, txtPayIban.Text);

                    if (success)
                    {
                        userInformations = (PublicUser)database.GetUser(userInformations.Email);
                    }

                    database.CloseConnection();

                    updateInfos();

                    txtPayIban.Text = "";
                    updPayAmount.Value = 1;
                    txtPayReason.Text = "";
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas assez d'argent pour effectuer cette transaction", "Erreur");
                }
            }
            else
            {
                if(userInformations.Money >= Convert.ToDouble(((UsersList)cboPayList.SelectedItem).Users.Count() * updPayAmount.Value))
                {
                    foreach (User user in ((UsersList)cboPayList.SelectedItem).Users)
                    {

                         DatabaseManagement database = new DatabaseManagement();
                         database.OpenConnection();

                         bool success = database.Transact(Convert.ToDouble(updPayAmount.Value), txtPayReason.Text, userInformations.Iban, user.Iban);

                         if (success)
                         {
                             userInformations = (PublicUser)database.GetUser(userInformations.Email);
                         }

                         database.CloseConnection();

                         updateInfos();
                    }
                    updPayAmount.Value = 1;
                    txtPayReason.Text = "";
                    cboPayList.SelectedIndex = 0;
                    txtPayIban.Text = "";
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas assez d'argent pour effectuer cette transaction", "Erreur");
                }
            }
        }

        private void cmdModifyList_Click(object sender, EventArgs e)
        {
            FrmListManagement Listform = new FrmListManagement((EnterpriseUser)userInformations);

            Listform.ShowDialog();

            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();

            userInformations = (EnterpriseUser)database.GetUser(userInformations.Email);

            database.CloseConnection();

            displayEnterpriseLists();

        }

        private void cmdProfil_Click(object sender, EventArgs e)
        {
            FrmProfil profilForm = new FrmProfil(userInformations);

            profilForm.ShowDialog();
        }

        private void updPayAmount_ValueChanged(object sender, EventArgs e)
        {
            if (cboPayList.SelectedIndex != 0)
            {
                lblListAmount.Text = "Vous allez payer: " + ((UsersList)cboPayList.SelectedItem).Users.Count() * updPayAmount.Value + " CHF";
            }
            else
            {
                lblListAmount.Text = "";
            }
        }
    }
}
