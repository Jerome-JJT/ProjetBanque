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
        //private int[] windowPosition = new int[] { 100, 100 };
        //private int[] windowSize = new int[] { 100, 100 };

        public Size winSize = new Size { Width = 800, Height = 800 };

        public int[] windowPosition;
        public int[] windowSize;


    }
}
