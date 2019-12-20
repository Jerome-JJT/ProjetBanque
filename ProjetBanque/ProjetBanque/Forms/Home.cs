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

            lblEmail.Text = userInformations.Email;

            lblIban.Text = userInformations.Iban;
            
            lblMoney.Text = "Votre solde s'élève a: " + userInformations.Money.ToString() + " CHF";

            foreach(Transaction transaction in userInformations.Transactions)
            {
                datHistory.Rows.Add(transaction);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Location = inheritJsonStorage.HomeWindowLocation;
            Size = inheritJsonStorage.HomeWindowSize;

            //string[] row = { "C# 3.0 Pocket Reference", "Albahari", "O'Reilly", "2008" };
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPayIban_TextChanged(object sender, EventArgs e)
        {
            string emailReceiver = "";

            if (txtPayIban.Text.Count() == 8)
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                string destEmail = database.EmailFromIban(txtPayIban.Text.ToUpper());

                database.CloseConnection();

                if (destEmail != null && destEmail != emailReceiver)
                {
                    lblEmailReceiver.Text = "Vous allez faire le payement a cette\npersonne: " + emailReceiver;

                    cmdPay.Enabled = true;
                }
                else if (destEmail == emailReceiver)
                {
                    lblEmailReceiver.Text = "Opération non possible";

                    cmdPay.Enabled = false;
                }
                else
                {
                    lblEmailReceiver.Text = "L'Iban que vous avez entré ne correspond a personne,\nveuillez vérifiez l'Iban";

                    cmdPay.Enabled = false;
                }
            }
            else
            {
                lblEmailReceiver.Text = "";

                cmdPay.Enabled = false;
            }
        }
    }
}
