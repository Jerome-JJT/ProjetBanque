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
        private List<BankUserInfos> users;

        /// <summary>
        /// Create a displayable admin user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        public AdminUser(string iban, string email) : base(iban, email, 0)
        {
            users = new List<BankUserInfos>();
        }

        /// <summary>
        /// Lists linked to enterprise user
        /// </summary>
        public List<BankUserInfos> Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}
