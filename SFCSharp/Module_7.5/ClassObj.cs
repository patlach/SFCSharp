using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._5
{
    class ClassObj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;
        
        static ClassObj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
}
