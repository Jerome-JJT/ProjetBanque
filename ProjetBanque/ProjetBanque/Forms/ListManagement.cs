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
    /// List management form's class
    /// </summary>
    public partial class FrmListManagement : Form
    {
        private EnterpriseUser userInfo;

        /// <summary>
        /// List management form constructor
        /// </summary>
        /// <param name="userInfos">Inherit user informations to display from parent form</param>
        public FrmListManagement(EnterpriseUser userInfos)
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
            
            try
            {
                database.CreateList(txtNameList.Text.Trim(), userInfo.Iban);
                userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);
            
                database.CloseConnection();
            }
            catch (ListAlreadyExistsException)
            {
                MessageBox.Show("Ce nom de liste existe déjà");
            }
            
            displayEnterpriseLists();
            lstList.Items.Clear();
            txtNameList.Text = "";
        }

        private void cmdAddToList_Click(object sender, EventArgs e)
        {
            cmdAddToListMethod();
        }
            private void cmdAddToListMethod()
            {
                if (((UsersList)cboList.SelectedItem).Users.All(item => item.Iban != txtIban.Text.ToUpper()))
                {
                    DatabaseManagement database = new DatabaseManagement();
                    database.OpenConnection();


                    database.AddUserList(((UsersList)cboList.SelectedItem).Name, txtIban.Text.Trim());
                    userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);

                    database.CloseConnection();

                    int selectedList = cboList.SelectedIndex;
                    
                    displayEnterpriseLists();
                    cboList.SelectedIndex = selectedList;
                    displayUsersLists();
                    
                    txtIban.Text = "";
                    lblNameUser.Text = "L'utilisateur a bien été ajouté";
                    cmdAddToList.Enabled = false;
            }
                else
                {
                    MessageBox.Show("Cet utilisateur est déjà dans cette liste");
                }
            }                            

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            if (txtIban.Text.Count() == 8 && cboList.SelectedIndex != -1)
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
                if (txtIban.Text.ToUpper() == userInfo.Iban)
                {
                    lblNameUser.Text = "Vous ne pouvez vous ajouter à la liste";
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
            lstList.Items.Clear();
            cmdListToDelete.Enabled = false;
            cmdDeleteList.Enabled = false;
            cmdAddToList.Enabled = false;
            txtIban.Enabled = false;
        }

        private void cmdListToDelete_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();

            database.DeleteUserList(((UsersList)cboList.SelectedItem).Name, ((User)lstList.SelectedItem).Iban);

            userInfo = (EnterpriseUser)database.GetUser(userInfo.Email);

            database.CloseConnection();

            int selectedList = cboList.SelectedIndex;

            displayEnterpriseLists();
            cboList.SelectedIndex = selectedList;
            displayUsersLists();           

            cmdListToDelete.Enabled = false;
        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayUsersLists();
            if (cboList.SelectedIndex != -1)
            {
                cmdDeleteList.Enabled = true;
                txtIban.Enabled = true;
                cmdListToDelete.Enabled = true;
                cmdAddToList.Enabled = true;
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
            if(lstList.SelectedIndex != -1)
            {
                cmdListToDelete.Enabled = true;
            }             
        }

        private void txtIban_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
             {
                if(cmdAddToList.Enabled == true)
                {
                    cmdAddToListMethod();
                }                
             }           
        }
    }
}
