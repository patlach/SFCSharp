using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();

            account1.Type = new SimpleAccount();
            account1.Balance = 5000;

            account1.Type.CalculateInterest(account1);

            Account account2 = new Account();
            
            account2.Type = new SalaryAccount();
            account2.Balance = 50001;

            account1.Type.CalculateInterest(account2);

            Console.WriteLine(account1.Interest);
            Console.WriteLine(account2.Interest);

            Console.ReadLine();
        }
    }
}
