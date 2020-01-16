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
    public partial class ListManagement : Form
    {
        private EnterpriseUser userInfo;

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
            cmdDeleteList.Enabled = true;
            txtIban.Enabled = true;
            cmdListToDelete.Enabled = true;
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
    }
}
