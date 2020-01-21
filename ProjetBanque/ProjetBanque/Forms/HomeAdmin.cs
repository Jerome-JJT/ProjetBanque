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
    public partial class FrmHomeAdmin : Form
    {
        private AdminUser userInformations;

        public FrmHomeAdmin(AdminUser userInfos, JsonData inheritStorage)
        {
            InitializeComponent();

            userInformations = userInfos;
            updateInfos();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateInfos()
        {
            lblEmail.Text = userInformations.Email;

            datHistory.Rows.Clear();

            if(txtSearchUserIban.Text.Trim() != "")
            {
                foreach (User user in userInformations.Users)
                {
                    foreach (Transaction transaction in user.Transaction)
                    {
                        string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                        datHistory.Rows.Add(row);
                    }                    
                }
            }
            else
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                EnterpriseUser UserWanted = SearchUser(txtSearchUserIban.Text.Trim());

                database.CloseConnection();

                foreach (Transaction user in UserWanted.Users)
                {
                    string[] row = { user.Define + " \n" + user.Iban, $"{user.Amount.ToString("0.00")} CHF"};
                    datHistory.Rows.Add(row);
                }
            }
            
        }

        private void cmdProfil_Click(object sender, EventArgs e)
        {
            FrmProfil profilForm = new FrmProfil(userInformations);

            profilForm.ShowDialog();
        }

        private void cmdModifyPassword_Click(object sender, EventArgs e)
        {
            FrmAdminPasswordChanger form = new FrmAdminPasswordChanger(userInformations);

            form.ShowDialog();

        }
    }
}
