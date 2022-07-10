using System;
using System.Collections.Generic;
using System.Text;

namespace SFCS_10._5_ICalc
{
    public class Summ : ISum
    {
        public void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
