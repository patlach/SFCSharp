using System;
using System.Collections.Generic;
using System.Text;

namespace SFCS_10._5_ICalcWithLogger.Contracts
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
