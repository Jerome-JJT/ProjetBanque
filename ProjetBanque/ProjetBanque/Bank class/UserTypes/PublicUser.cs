using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store user's primary informations, money and transactions to display them
    /// </summary>
    public class PublicUser : User
    {
        /// <summary>
        /// .
        /// </summary>
        protected double money;

        /// <summary>
        /// .
        /// </summary>
        protected List<Transaction> transactions = new List<Transaction>();

        /// <summary>
        /// Create a displayable public user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        public PublicUser(string iban, string email, double money) : base(iban, email)
        {
            this.iban = iban;
            this.email = email;
            this.money = money;
        }

        /// <summary>
        /// USer's money
        /// </summary>
        public double Money
        {
            get { return money; }
            set { money = value; }
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
