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
        private JsonData inheritJsonStorage;
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
            inheritJsonStorage = inheritStorage;
            updateInfos();
        }
        private void FrmHomeAdmin_Load(object sender, EventArgs e)
        {
            Location = inheritJsonStorage.HomeWindowLocation;
            Size = inheritJsonStorage.HomeWindowSize;
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
            datList.Rows.Clear();

            if (txtSearch.Text.Trim() == "")
            {
                for (int i = 0; i < 30 && i < userInformations.Users.Count; i++)
                {
                    BankUserInfos user = userInformations.Users[i];

                    string[] row = { user.ActiveAccount ? "Actif" : "Inactif", user.UserType.ToString(), user.Email, user.Iban, $"{user.Money.ToString("0.00")} CHF" };
                    datAllUsers.Rows.Add(row);
                }

                for (int i = 0; i < 30 && i < userInformations.Transactions.Count; i++)
                {
                    Transaction transaction = userInformations.Transactions[i];

                    string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                    datHistory.Rows.Add(row);
                }

                int maxCount = 0;
                foreach (AdminUsersList list in userInformations.Lists)
                {
                    if (list.Users.Any())
                    {
                        foreach (User userInList in list.Users)
                        {
                            if (maxCount < 30)
                            {
                                string[] row = { list.Owner, list.ToString(), userInList.Email };
                                datList.Rows.Add(row);
                            }
                            else
                            {
                                break;
                            }

                            maxCount++;
                        }
                    }
                    else if (maxCount < 30)
                    {
                        string[] row = { list.Owner, list.ToString(), "Vide" };
                        datList.Rows.Add(row);

                        maxCount++;
                    }
                }
            }
            else
            {
                foreach (BankUserInfos user in userInformations.Users)
                {
                    if (user.Email.Contains(txtSearch.Text.Trim()) || user.Iban.Contains(txtSearch.Text.Trim()))
                    {
                        string[] row = { user.ActiveAccount ? "Actif" : "Inactif", user.UserType.ToString(), user.Email, user.Iban, $"{user.Money.ToString("0.00")} CHF" };
                        datAllUsers.Rows.Add(row);
                    }
                }

                foreach (Transaction transaction in userInformations.Transactions)
                {
                    if(transaction.SenderDefine.Contains(txtSearch.Text.Trim()) || transaction.ReceiverDefine.Contains(txtSearch.Text.Trim()))
                    {
                        string[] row = { transaction.SenderDefine + " \n" + transaction.SenderIban, transaction.ReceiverDefine + " \n" + transaction.ReceiverIban, $"{transaction.Amount.ToString("0.00")} CHF", transaction.Reason, transaction.Date };
                        datHistory.Rows.Add(row);
                    }                    
                }

                foreach (AdminUsersList list in userInformations.Lists)
                {
                    if (list.Users.Any())
                    {
                        foreach (User userInList in list.Users)
                        {
                            if (userInList.Email.Contains(txtSearch.Text.Trim()) ||
                                list.Owner.Contains(txtSearch.Text.Trim()) || list.Name.Contains(txtSearch.Text.Trim()))
                            {
                                string[] row = { list.Owner, list.ToString(), userInList.Email };
                                datList.Rows.Add(row);
                            }
                        }
                    }
                    else
                    {
                        if (list.Owner.Contains(txtSearch.Text.Trim()) || list.Name.Contains(txtSearch.Text.Trim()))
                        {
                            string[] row = { list.Owner, list.ToString(), "Vide" };
                            datList.Rows.Add(row);
                        }
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

        private void cmdModifyMonney_Click(object sender, EventArgs e)
        {
            FrmAdminMoneyChanger form = new FrmAdminMoneyChanger(userInformations);

            form.ShowDialog();

            updateInfos();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateInfos();
        }
    }
}
