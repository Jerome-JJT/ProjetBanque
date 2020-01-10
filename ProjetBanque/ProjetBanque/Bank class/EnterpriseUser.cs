using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store enterprise user's informations, transactions and payment lists to display them
    /// </summary>
    public class EnterpriseUser : PublicUser
    {
        private List<UsersList> lists;

        /// <summary>
        /// Create a displayable enterprise user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        public EnterpriseUser(string iban, string email, double money) : base(iban, email, money)
        {
        }

        /// <summary>
        /// Lists linked to enterprise user
        /// </summary>
        public List<UsersList> Lists
        {
            get { return lists; }
            set { lists = value; }
        }
    }
}