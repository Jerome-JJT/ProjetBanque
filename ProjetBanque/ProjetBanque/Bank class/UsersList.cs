using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store one payment list
    /// </summary>
    public class UsersList
    {
        private string name;
        private List<User> users = new List<User>();
        
        /// <summary>
        /// Construct payment list
        /// </summary>
        public UsersList(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// List's name
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// List's users
        /// </summary>
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

    }
}
