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
    /// Admin home form's class
    /// </summary>
    public partial class FrmHomeAdmin : Form
    {
        private AdminUser userInformations;

        /// <summary>
        /// Admin home form constructor
        /// </summary>
        /// <param name="userInfos">Inherit user informations to display from parent form</param>
        /// <param name="inheritStorage">Inherit json informations to use from parent form</param>
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

        private void cmdModifyMonney_Click(object sender, EventArgs e)
        {
            FrmAdminMoneyChanger form = new FrmAdminMoneyChanger(userInformations);

            form.ShowDialog();
        }
    }
}
