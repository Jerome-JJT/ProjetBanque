using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Contains all data readable from banque json
    /// </summary>
    public class JsonData
    {
        private Point loginWindowLocation = new Point { X = 0, Y = 0 };

        private Point registerWindowLocation = new Point { X = 0, Y = 0 };

        private Size homeWindowSize = new Size { Width = 0, Height = 0 };
        private Point homeWindowLocation = new Point { X = 0, Y = 0 };


        /// <summary>
        /// Get/Set json's login window location
        /// </summary>
        public Point LoginWindowLocation
        {
            get { return loginWindowLocation; }
            set { loginWindowLocation = value; }
        }

        /// <summary>
        /// Get/Set json's register window location
        /// </summary>
        public Point RegisterWindowLocation
        {
            get { return registerWindowLocation; }
            set { registerWindowLocation = value; }
        }

        /// <summary>
        /// Get/Set json's home window size
        /// </summary>
        public Size HomeWindowSize
        {
            get { return homeWindowSize; }
            set { homeWindowSize = value; }
        }

        /// <summary>
        /// Get/Set json's home window location
        /// </summary>
        public Point HomeWindowLocation
        {
            get { return homeWindowLocation; }
            set { homeWindowLocation = value; }
        }
    }
}
