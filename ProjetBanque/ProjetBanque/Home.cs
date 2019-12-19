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
    /// This windows is the home page of our application
    /// </summary>
    public partial class frmHome : Form
    {
        private JsonData inheritJsonStorage;

        /// <summary>
        /// This is the constructor of the home page
        /// </summary>
        /// <param name="inheritStorage"></param>
        public frmHome(JsonData inheritStorage)
        {
            InitializeComponent();

            inheritJsonStorage = inheritStorage;

            string[] row0 = { "C# 3.0 Pocket Reference", "Albahari", "O'Reilly", "2008" };

            datHistory.Rows.Add(row0);

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
