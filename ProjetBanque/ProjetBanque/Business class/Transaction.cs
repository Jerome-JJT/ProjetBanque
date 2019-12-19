using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
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

        /// <summary>
        /// Create a displayable transaction
        /// </summary>
        /// <param name="date">Transaction's date</param>
        /// <param name="amount">Transaction's amount</param>
        /// <param name="reason">Transaction's reason</param>
        /// <param name="senderDefine">Text to display about money sender</param>
        /// <param name="receiverDefine">Text to display about money receiver</param>
        public Transaction(string date, double amount, string reason, string senderDefine, string receiverDefine)
        {
            this.date = date;
            this.amount = amount;
            this.reason = reason;

            this.senderDefine = senderDefine;
            this.receiverDefine = receiverDefine;
        }

        /// <summary>
        /// Transaction's date
        /// </summary>
        public string Date
        {
            get { return date; }
        }

        /// <summary>
        /// Transaction's amount
        /// </summary>
        public double Amount
        {
            get { return amount; }
        }

        /// <summary>
        /// Transaction's reason
        /// </summary>
        public string Reason
        {
            get { return reason; }
        }

        /// <summary>
        /// Text to display about money sender
        /// </summary>
        public string SenderDefine
        {
            get { return senderDefine; }
        }

        /// <summary>
        /// Text to display about money receiver
        /// </summary>
        public string ReceiverDefine
        {
            get { return receiverDefine; }
        }
    }
}
