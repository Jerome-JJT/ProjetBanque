using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store one payment list with owner list
    /// </summary>
    public class AdminUsersList : UsersList
    {
        private string owner;

        /// <summary>
        /// Construct admin payment list
        /// </summary>
        public AdminUsersList(string name, string owner) : base(name)
        {
            this.owner = owner;
        }

        /// <summary>
        /// List's owner
        /// </summary>
        public string Owner
        {
            get { return owner; }
        }
    }
}
