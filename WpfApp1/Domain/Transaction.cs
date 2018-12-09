using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Domain
{
    class Transaction
    {
        public int Id { get; set; }
        public TransactionReason Reason { get; set; }
        public TransactionType Type { get; set; }
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


    }
}
