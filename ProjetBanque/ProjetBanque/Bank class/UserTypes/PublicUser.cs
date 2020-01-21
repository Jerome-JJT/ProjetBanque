using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Public user can have transactions and can display them
    /// </summary>
    public class PublicUser : BankUser
    {
        /// <summary>
        /// .
        /// </summary>
        protected List<Transaction> transactions;

        /// <summary>
        /// Create a displayable public user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        public PublicUser(string iban, string email, double money) : base(iban, email, money)
        {
            transactions = new List<Transaction>();
        }

        /// <summary>
        /// Transactions linked to user
        /// </summary>
        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }
    }
}
