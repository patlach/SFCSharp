using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._5
{
    static class MethodExtensions
    {
        static int GetNegative(this int num)
        {
            if (num > 0)
            {
                return - num;
            }
            else
            {
                return num;
            }
        }

        public static int GetPositive(this int num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
            {
                return num;
            }
        }
    }
}
