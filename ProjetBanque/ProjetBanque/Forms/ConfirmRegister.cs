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
    /// Register confirmation form's class
    /// </summary>
    public partial class FrmConfirmRegister : Form
    {
        private string email;

        /// <summary>
        /// Register confirmation form constructor
        /// </summary>
        public FrmConfirmRegister()
        {
            InitializeComponent();
        }

        private void FrmConfirmRegister_Load(object sender, EventArgs e)
        {
            lblEmail.Text = email;
        }

        /// <summary>
        /// Allow parent form to set the email to display
        /// </summary>
        public string Email
        {
            set { email = value; }
        }


        private void cmdBackLogin_Click(object sender, EventArgs e)
        {            
            Close();             
        }
    }
}
