using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Group all bank errors
    /// </summary>
    public class BankException : Exception
    {
        
    }

    /// <summary>
    /// Exception raised when database is unjoinable
    /// </summary>
    public class UnableToJoinDatabase : BankException
    {


    }

    /// <summary>
    /// Exception raised when trying to create a user who already exists
    /// </summary>
    public class UserAlreadyExistsException : BankException
    {

    }

    /// <summary>
    /// Exception raised when trying to login with a user who doesn't exists
    /// </summary>
    public class UserDoesNotExistsException : BankException
    {

    }

    /// <summary>
    /// Exception raised when an email isn't a valid format
    /// </summary>
    public class WrongEmailFormatException : BankException
    {

    }

    /// <summary>
    /// Exception raised when trying to create an account without a valid account type
    /// </summary>
    public class WrongAccountTypeException : BankException
    {

    }
}
