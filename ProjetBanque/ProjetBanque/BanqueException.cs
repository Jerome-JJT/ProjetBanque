using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public class BanqueException : Exception
    {
        
    }

    public class UserAlreadyExist : BanqueException
    {

    }
}
