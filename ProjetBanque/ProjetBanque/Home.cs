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
    public partial class frmHome : Form
    {
        private JsonData inheritJsonStorage;

        public frmHome(JsonData inheritStorage)
        {
            InitializeComponent();

            inheritJsonStorage = inheritStorage;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Location = inheritJsonStorage.HomeWindowLocation;
            Size = inheritJsonStorage.HomeWindowSize;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
