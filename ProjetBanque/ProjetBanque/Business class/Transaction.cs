using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque.Business_class
{
    /// <summary>
    /// Store unique transaction between two users
    /// </summary>
    public class Transaction
    {
        private string date;
        private double amount;
        private string reason;

        private string senderDefine;
        private string receiverDefine;
    }
}
