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
    /// Home form's class
    /// </summary>
    public partial class FrmHome : Form
    {
        private JsonData inheritJsonStorage;
        private User userInformations;


        /// <summary>
        /// Home form constructor
        /// </summary>
        /// <param name="userInfo">Inherit user informations to display from parent form</param>
        /// <param name="inheritStorage">Inherit json informations to use from parent form</param>
        public FrmHome(User userInfo, JsonData inheritStorage)
        {
            InitializeComponent();

            cmdPay.Enabled = false;

            userInformations = userInfo;
            inheritJsonStorage = inheritStorage;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Location = inheritJsonStorage.HomeWindowLocation;
            Size = inheritJsonStorage.HomeWindowSize;

            updateInfos();
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
            if(userInformations.Money >= Convert.ToDouble(updPayAmount.Value))
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                bool success = database.Transact(Convert.ToDouble(updPayAmount.Value), txtPayReason.Text, userInformations.Iban, txtPayIban.Text);

                if (success)
                {
                    userInformations = database.GetUser(userInformations.Email);
                }

                database.CloseConnection();

                updateInfos();

                txtPayIban.Text = "";
                updPayAmount.Value = 0;
                txtPayReason.Text = "";
            }
            else
            {
                MessageBox.Show("Vous n'avez pas assez d'argent pour effectuer cette transaction", "Erreur");
            }
        }
    }
}
