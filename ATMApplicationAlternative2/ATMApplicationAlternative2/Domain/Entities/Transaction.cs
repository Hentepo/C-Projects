﻿using ATMApplicationAlternative2.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplicationAlternative2.Domain.Entities
{
    internal class Transaction
    {
        public long TransactionId { get; set; }
        public long UserBankAccountId { get; set; }

        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Description { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
