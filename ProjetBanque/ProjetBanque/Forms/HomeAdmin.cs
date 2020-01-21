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
            datAllUsers.Rows.Clear();

            if (txtSearch.Text.Trim() == "")
            {
                foreach (Transaction transaction in userInformations.Transactions)
                {
                    string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                    datHistory.Rows.Add(row);
                }
                foreach (BankUser user in userInformations.Users)
                {
                    string[] row = { user.Email, user.Iban, $"{user.Money.ToString("0.00")} CHF" };
                    datAllUsers.Rows.Add(row);
                }
            }
            else
            {
                foreach (Transaction transaction in userInformations.Transactions)
                {
                    if(transaction.SenderDefine.Contains(txtSearch.Text.Trim()) || transaction.ReceiverDefine.Contains(txtSearch.Text.Trim()))
                    {
                        string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                        datHistory.Rows.Add(row);
                    }                    
                }
                foreach (BankUser user in userInformations.Users)
                {
                    if (user.Email.Contains(txtSearch.Text.Trim()))
                    {
                        string[] row = { user.Email, user.Iban, $"{user.Money.ToString("0.00")} CHF" };
                        datAllUsers.Rows.Add(row);
                    }                         
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateInfos();
        }
    }
}
