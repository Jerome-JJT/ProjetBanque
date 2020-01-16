using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Store user's primary informations to display them
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
            /// Enterprise account, can use list
            /// </summary>
            Enterprise = 2,
            /// <summary>
            /// Admin account, can see every account
            /// </summary>
            Admin = 3
        }


        /// <summary>
        /// .
        /// </summary>
        protected string iban;
        /// <summary>
        /// .
        /// </summary>
        protected string email;


        /// <summary>
        /// Create a displayable user
        /// </summary>
        /// <param name="iban">User's IBAN</param>
        /// <param name="email">User's email</param>
        public User(string iban, string email)
        {
            this.iban = iban;
            this.email = email;
        }

        /// <summary>
        /// User's IBAN
        /// </summary>
        public string Iban
        {
            get { return iban; }
        }

        /// <summary>
        /// User's email
        /// </summary>
        public string Email
        {
            get { return email; }
        }

        /// <summary>
        /// Display user's informations 
        /// </summary>
        /// <returns>User's informations</returns>
        public override string ToString()
        {
            return $"{iban} {email}";
        }
    }
}
