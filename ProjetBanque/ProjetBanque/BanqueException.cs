using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Group all banque errors
    /// </summary>
    public class BanqueException : Exception
    {
        
    }

    /// <summary>
    /// Exception raised when database is unjoinable
    /// </summary>
    public class UnableToJoinDatabase : BanqueException
    {


    }

    /// <summary>
    /// Exception raised when trying to create a user who already exists
    /// </summary>
    public class UserAlreadyExistsException : BanqueException
    {

    }

    /// <summary>
    /// Exception raised when trying to login with a user who doesn't exists
    /// </summary>
    public class UserDoesNotExistsException : BanqueException
    {

    }

    /// <summary>
    /// Exception raised when an email isn't a valid format
    /// </summary>
    public class WrongEmailFormatException : BanqueException
    {

    }

    /// <summary>
    /// Exception raised when trying to create an account without a valid account type
    /// </summary>
    public class WrongAccountTypeException : BanqueException
    {

    }
}
