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

            userInformations = userInfo;
            inheritJsonStorage = inheritStorage;

            lblEmail.Text = userInformations.Email;
            lblIban.Text = userInformations.Iban;
            lblMoney.Text = "Votre solde s'eleve a: " + userInformations.Money.ToString() + " CHF";

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

    }
}
