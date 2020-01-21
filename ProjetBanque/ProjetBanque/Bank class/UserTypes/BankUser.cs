using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Back user can have money
    /// </summary>
    public class BankUser : User
    {
        /// <summary>
        /// .
        /// </summary>
        protected double money;

        /// <summary>
        /// Create a displayable public user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        /// <param name="money">User's money amount</param>
        public BankUser(string iban, string email, double money) : base(iban, email)
        {
            this.money = money;
        }

        /// <summary>
        /// User's money
        /// </summary>
        public double Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
