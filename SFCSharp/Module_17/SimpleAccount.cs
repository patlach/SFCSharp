using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class SimpleAccount : IAccounttype
    {
        public double CalculateInterest(Account account)
        {
            switch (account.Balance)
            {
                case double n when n < 1000:
                    account.Interest -= account.Balance * 0.2;
                    break;
                case double n when n < 50000:
                    account.Interest -= account.Balance * 0.4;
                    break;
                default :
                    account.Interest -= account.Balance * 0.4;
                    break;
            }

            return account.Interest;
        }
    }
}
