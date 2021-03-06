﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjetBanque
{
    //Source code https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129
    /// <summary>
    /// Hashing and salting management with verification
    /// </summary>
    public class CryptoPassword
    {
        /// <summary>
        /// Size of salt.
        /// </summary>
        private const int saltSize = 16;

        /// <summary>
        /// Size of hash.
        /// </summary>
        private const int hashSize = 20;

        /// <summary>
        /// Numbre of iterations.
        /// </summary>
        private const int iterations = 10000;

        /// <summary>
        /// Hash and salt a password
        /// </summary>
        /// <param name="password">Password to hash/salt</param>
        /// <returns>Hashed/Salted string</returns>
        public string Hash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[saltSize]);

            // Create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(hashSize);

            // Combine salt and hash
            var hashBytes = new byte[saltSize + hashSize];
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hash, 0, hashBytes, saltSize, hashSize);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("$BANQUEHASH$V1${0}${1}", iterations, base64Hash);
        }


        /// <summary>
        /// Verifiy a password with a hashed/salted password
        /// /// </summary>
        /// <param name="password">The password to verify</param>
        /// <param name="hashedPassword">Hashed password</param>
        /// <returns>True if password matchs, else false</returns>
        public bool Verify(string password, string hashedPassword)
        {
            // Extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$BANQUEHASH$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // Get hash bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            // Get salt
            var salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            // Create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(hashSize);

            // Get result
            for (var i = 0; i < hashSize; i++)
            {
                if (hashBytes[i + saltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
