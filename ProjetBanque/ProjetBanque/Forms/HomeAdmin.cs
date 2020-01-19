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
        private PublicUser userInformations;

        public frmHomeAdmin(PublicUser userInfos, JsonData inheritStorage)
        {
            InitializeComponent();

            userInformations = userInfos;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdProfil_Click(object sender, EventArgs e)
        {
            FrmProfil profilForm = new FrmProfil(userInformations);

            profilForm.ShowDialog();
        }

        private void cmdModifyPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
