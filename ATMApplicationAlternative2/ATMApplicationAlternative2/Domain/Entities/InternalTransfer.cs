﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplicationAlternative2.Domain.Entities
{
    public class InternalTransfer
    {
        public decimal TransferAmount { get; set; }
        public long RecipientBankAccountNumber { get; set; }
        public string RecipientBankAccountName { get; set; }
    }
}
