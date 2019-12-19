using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store user's informations and transactions to display them
    /// </summary>
    public class User
    {
        /// <summary>
        /// Possibles user's accounts types
        /// </summary>
        public enum AccountType
        {
            /// <summary>
            /// Normal user account
            /// </summary>
            Public = 1,
            /// <summary>
            /// Entreprise account, can use list
            /// </summary>
            Entreprise = 2,
            /// <summary>
            /// Admin account, can see every account
            /// </summary>
            Admin = 3
        }

        
        private string iban;
        private AccountType type;
        private string email;
        private double money;

        private List<Transaction> transactions = new List<Transaction>();

        /// <summary>
        /// Create a displayable user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="type">User's account type</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        public User(string iban, AccountType type, string email, double money)
        {
            this.iban = iban;
            this.type = type;
            this.email = email;
            this.money = money;
        }

        /// <summary>
        /// User's IBAN
        /// </summary>
        public string Iban
        {
            get { return iban; }
        }

        /// <summary>
        /// User's account type
        /// </summary>
        public AccountType Type
        {
            get { return type; }
        }

        /// <summary>
        /// User's email
        /// </summary>
        public string Email
        {
            get { return email; }
        }

        /// <summary>
        /// User's money amount
        /// </summary>
        public double Money
        {
            get { return money; }
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
