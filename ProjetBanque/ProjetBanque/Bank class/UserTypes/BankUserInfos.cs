using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store user's primary databases informations to display them
    /// </summary>
    public class BankUserInfos : BankUser
    {
        private bool activeAccount;
        private AccountType userType;

        /// <summary>
        /// Create a displayable user for admins
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        /// <param name="activeAccount">Show if the eaccount is active or not</param>
        /// <param name="userType">Show the user's account type</param>
        public BankUserInfos(string iban, string email, double money, bool activeAccount, AccountType userType) : base(iban, email, money)
        {
            this.activeAccount = activeAccount;
            this.userType = userType;
        }

        /// <summary>
        /// User's account active state
        /// </summary>
        public bool ActiveAccount
        {
            get { return activeAccount; }
        }

        /// <summary>
        /// User's account type
        /// </summary>
        public AccountType UserType
        {
            get { return userType; }
        }
    }
}
