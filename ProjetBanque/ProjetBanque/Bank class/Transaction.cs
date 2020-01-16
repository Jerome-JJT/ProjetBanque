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
        private string senderIban;
        private string receiverDefine;
        private string receiverIban;

        /// <summary>
        /// Create a displayable transaction
        /// </summary>
        /// <param name="date">Transaction's date</param>
        /// <param name="amount">Transaction's amount</param>
        /// <param name="reason">Transaction's reason</param>
        /// <param name="senderDefine">Text to display about money sender</param>
        /// <param name="senderIban">Sender's iban</param>
        /// <param name="receiverDefine">Text to display about money receiver</param>
        /// <param name="receiverIban">Receiver iban</param>
        public Transaction(string date, double amount, string reason, 
            string senderDefine, string senderIban, string receiverDefine, string receiverIban)
        {
            this.date = date;
            this.amount = amount;
            this.reason = reason;

            this.senderDefine = senderDefine;
            this.senderIban = senderIban;
            this.receiverDefine = receiverDefine;
            this.receiverIban = receiverIban;
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
        /// Iban about money sender
        /// </summary>
        public string SenderIban
        {
            get { return senderIban; }
        }

        /// <summary>
        /// Text to display about money receiver
        /// </summary>
        public string ReceiverDefine
        {
            get { return receiverDefine; }
        }

        /// <summary>
        /// Iban about money receiver
        /// </summary>
        public string ReceiverIban
        {
            get { return receiverIban; }
        }
    }
}
