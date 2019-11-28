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
        private Size windowSize = new Size { Width = 800, Height = 900 };
        private Point windowPosition = new Point { X = 80, Y = 90 };

        /// <summary>
        /// Get/Set json's window size
        /// </summary>
        public Size WindowSize
        {
            get { return windowSize; }
            set { windowSize = value; }
        }

        /// <summary>
        /// Get/Set json's window position
        /// </summary>
        public Point WindowPosition
        {
            get { return windowPosition; }
            set { windowPosition = value; }
        }
    }
}
