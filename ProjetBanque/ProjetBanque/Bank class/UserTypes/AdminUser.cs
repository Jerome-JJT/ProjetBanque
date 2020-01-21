using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Enterprise user can store bank users and can display them
    /// </summary>
    public class AdminUser : EnterpriseUser
    {
        private List<BankUser> users;

        /// <summary>
        /// Create a displayable admin user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        public AdminUser(string iban, string email) : base(iban, email, 0)
        {
            users = new List<BankUser>();
        }

        /// <summary>
        /// Lists linked to enterprise user
        /// </summary>
        public List<BankUser> Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}
