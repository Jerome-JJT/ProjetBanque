using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public class AdminUser : EnterpriseUser
    {
        private List<UsersList> users;

        /// <summary>
        /// Create a displayable admin user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        public AdminUser(string iban, string email) : base(iban, email, 0)
        {
            users = new List<UsersList>();
        }

        /// <summary>
        /// Lists linked to enterprise user
        /// </summary>
        public List<UsersList> Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}
