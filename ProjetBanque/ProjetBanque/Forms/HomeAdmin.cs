using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBanque.Forms
{
    public partial class frmHomeAdmin : Form
    {
        private AdminUser userInformations;

        public frmHomeAdmin(AdminUser userInfos, JsonData inheritStorage)
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

            if (txtSearchUserIban.Text.Trim() != "")
            {
                foreach (Transaction transaction in userInformations.Transactions)
                {
                    string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                    datHistory.Rows.Add(row);
                }
                foreach (BankUser user in userInformations.Users)
                {
                    string[] row = { user.Email + " \n" + user.Iban, $"{user.Money.ToString("0.00")} CHF" };
                    datAllUsers.Rows.Add(row);
                }
            }
            else
            {
                foreach (Transaction transaction in userInformations.Transactions)
                {
                    string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                    datHistory.Rows.Add(row);
                }
                foreach (BankUser user in userInformations.Users)
                {
                    string[] row = { user.Email + " \n" + user.Iban, $"{user.Money.ToString("0.00")} CHF"};
                    datAllUsers.Rows.Add(row);
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
