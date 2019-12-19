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

            string[] row0 = { "C# 3.0 Pocket Reference", "Albahari", "O'Reilly", "Sebastopol, CA", "2008" };
            string[] row1 = { "CLR via C#", "Richter", "Microsoft", "Redmond, WA", "2006" };
            string[] row2 = { "Mastering Regular Expressions", "Friedl", "O'Reilly", "Sebastopol, CA", "1997" };
            string[] row3 = { "C++ Primer", "Lippman, Lajoie", "Addison-Wesley", "Massachusetts", "1998" };
            string[] row4 = { "C++ Programming Style", "Cargill", "Addison-Wesley", "Massachusetts", "1992" };
            string[] row5 = { "The C Programming Language", "Kernighan, Ritchie", "Bell Labs", "USA", "1988" };

            datHistory.Rows.Add(row0);
            datHistory.Rows.Add(row1);
            datHistory.Rows.Add(row2);
            datHistory.Rows.Add(row3);
            datHistory.Rows.Add(row4);
            datHistory.Rows.Add(row5);
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
