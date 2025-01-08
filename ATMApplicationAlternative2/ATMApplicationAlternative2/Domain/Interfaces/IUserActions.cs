using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplicationAlternative2.Domain.Interfaces
{
    public interface IUserActions
    {
        void CheckBalance();
        void PlaceDeposit();
        void MakeWithdrawal();

    }
}
