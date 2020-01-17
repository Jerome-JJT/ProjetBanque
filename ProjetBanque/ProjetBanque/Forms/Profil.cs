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
    public partial class frmProfil : Form
    {
        User userInfos;

        public frmProfil(User userInformations)
        {
            InitializeComponent();

            userInfos = userInformations;
        }

        private void cmdDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir effacer votre compte ?\nVotre argent ne sera plus accessible.", 
                "Effacer votre compte", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DatabaseManagement database = new DatabaseManagement();
                database.OpenConnection();

                database.DisableAccount(userInfos.Email);

                database.CloseConnection();

                MessageBox.Show("Au revoir", "Merci");
                Application.Exit();
            }
        }
    }
}
