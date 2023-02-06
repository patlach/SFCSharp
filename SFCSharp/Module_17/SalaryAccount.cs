using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class SalaryAccount : IAccounttype
    {
        public double CalculateInterest(Account account)
        {
            return account.Interest = account.Balance * 0.5;
        }
    }
}
