using SFCS_10._5_ICalcWithLogger.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFCS_10._5_ICalcWithLogger.Logics
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}
