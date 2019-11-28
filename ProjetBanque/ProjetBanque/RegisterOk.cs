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
    public partial class formRegisterOk : Form
    {
        public formRegisterOk()
        {
            InitializeComponent();
        }

        private void buttonRegisterOk_Click(object sender, EventArgs e)
        {
            formRegister formRegister = new formRegister();
            formRegister.Close();
            this.Close();
            formLogin form = new formLogin();
        }
    }
}
