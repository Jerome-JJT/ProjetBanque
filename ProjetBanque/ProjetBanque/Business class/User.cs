using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque.Business_class
{
    /// <summary>
    /// Store user's informations and transactions to display them
    /// </summary>
    public class User
    {
        /// <summary>
        /// Possibles user's accounts types
        /// </summary>
        public enum Types
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

        private string email;
        private string iban;
        private double money;

        public User(string email, string iban, double money)
        {
            this.email = email;
            this.iban = iban;
            this.money = money;
        }


    }
}
