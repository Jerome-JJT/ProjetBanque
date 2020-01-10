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
    public class EnterpriseUser : User
    {
        private List<UsersList> lists;

        /// <summary>
        /// Create a displayable enterprise user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="type">User's account type</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        /// <param name="lists">Enterprise payment lists</param>
        public EnterpriseUser(string iban, AccountType type, string email, double money, List<UsersList> lists) : base(iban, type, email, money)
        {
            this.iban = iban;
            this.type = type;
            this.email = email;
            this.money = money;

            this.lists = lists;
        }
    }
}