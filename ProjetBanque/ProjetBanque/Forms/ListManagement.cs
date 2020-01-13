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

        public ListManagement(EnterpriseUser userInfo)
        {
            InitializeComponent();
        }

        private void cmdAddList_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();

            database.NewUserList();
            database.CloseConnection();
        }

        private void cmdAddToList_Click(object sender, EventArgs e)
        {
            DatabaseManagement database = new DatabaseManagement();
            database.OpenConnection();

            database.AddUserList(txtIban.Text);
            database.CloseConnection();
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
                }
            }
        }

        private void cmdDeleteList_Click(object sender, EventArgs e)
        {

        }

        private void cmdListToDelete_Click(object sender, EventArgs e)
        {
            int indexDelete = lstList.SelectedIndex;


        }
    }
}
