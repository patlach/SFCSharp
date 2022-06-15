using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6._3
{
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("Есть народ, {0} человек", Load.Value);
            }
            else
            {
                Console.WriteLine("Нет народа");
            }
        }
    }
}
