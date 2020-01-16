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
    public partial class ListManagement : Form
    {
        private EnterpriseUser userInfo;

        /// <summary>
        /// List management form constructor
        /// </summary>
        /// <param name="userInfos">Inherit user informations to display from parent form</param>
        public ListManagement(EnterpriseUser userInfos)
        {
            InitializeComponent();
            cmdAddList.Enabled = false;
            userInfo = userInfos;
            cmdAddToList.Enabled = false;
            cmdDeleteList.Enabled = false;
            txtIban.Enabled = false;
            cmdListToDelete.Enabled = false;

            displayEnterpriseLists();           
        }

        private void displayEnterpriseLists()
        {
            cboList.Items.Clear();
            foreach (UsersList eachList in userInfo.Lists)
            {
                cboList.Items.Add(eachList);
            }
        }
        private void displayUsersLists()
        {
            lstList.Items.Clear();
            foreach (User userInfo in ((UsersList)cboList.SelectedItem).Users)
            {
                lstList.Items.Add(userInfo);
            }
        }
        

        private void cmdAddList_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();
            
            try {
                database.CreateList(txtNameList.Text.Trim(), userInfo.Iban);
                userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);
            
                database.CloseConnection();
            }
            catch (ListAlreadyExists)
            {
                MessageBox.Show("Liste deja existante a quelque part");
            }
            
            displayEnterpriseLists();
            lstList.Items.Clear();
        }

        private void cmdAddToList_Click(object sender, EventArgs e)
        {
            if (((UsersList)cboList.SelectedItem).Users.All(item => item.Iban != txtIban.Text))
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();               

                database.AddUserList(((UsersList)cboList.SelectedItem).Name, txtIban.Text.Trim());
                userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);

                database.CloseConnection();              

                displayUsersLists();

                txtIban.Text = "";
                lblNameUser.Text = "L'utilisateur a bien été ajouter";
            }
            else
            {
                MessageBox.Show("Cette utilisateur est deja dans cette liste");
            }
            
        }

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            if (txtIban.Text.Count() == 8)
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                string destEmail = database.EmailFromIban(txtIban.Text.ToUpper());

                database.CloseConnection();

                if (destEmail != null && userInfo.Email != destEmail)
                {
                    lblNameUser.Text = $"Vous allez ajouter :\n{destEmail}";
                    cmdAddToList.Enabled = true;
                }
                else
                {
                    lblNameUser.Text = "";
                    cmdAddToList.Enabled = false;
                }
            }
            else
            {
                lblNameUser.Text = "";
                cmdAddToList.Enabled = false;
            }
        }

        private void cmdDeleteList_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();

            
            database.DeleteList(((UsersList)cboList.SelectedItem).Name);
            userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);

            database.CloseConnection();

            displayEnterpriseLists();
        }

        private void cmdListToDelete_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();

            database.DeleteUserList(((UsersList)cboList.SelectedItem).Name, ((User)lstList.SelectedItem).Iban);
            userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);

            database.CloseConnection();

            displayUsersLists();
        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayUsersLists();
            if (cboList.SelectedIndex != -1)
            {
                cmdDeleteList.Enabled = true;
                txtIban.Enabled = true;
                cmdListToDelete.Enabled = true;
            }
            else
            {
                cmdDeleteList.Enabled = false;
                txtIban.Enabled = false;
                cmdListToDelete.Enabled = false;
            }
            cmdListToDelete.Enabled = false;
        }

        private void txtNameList_TextChanged(object sender, EventArgs e)
        {
            if(txtNameList.Text.Trim() == "")
            {
                cmdAddList.Enabled = false;
            }
            else
            {
                cmdAddList.Enabled = true;
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
             cmdListToDelete.Enabled = true;
        }
    }
}
