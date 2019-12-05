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
    /// This windows is opened when the user has finish the register
    /// </summary>
    public partial class formRegisterOk : Form
    {
        /// <summary>
        /// This is the constructor for when the Register is end
        /// </summary>
        public formRegisterOk()
        {
            InitializeComponent();
        }

        private void buttonRegisterOk_Click(object sender, EventArgs e)
        {            
            this.Close();             
        }

        private void formRegisterOk_Load(object sender, EventArgs e)
        {

        }
    }
}
