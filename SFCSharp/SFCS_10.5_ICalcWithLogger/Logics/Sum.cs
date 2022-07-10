using SFCS_10._5_ICalcWithLogger.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SFCS_10._5_ICalcWithLogger
{
    public class Summ : ISum
    {
        ILogger Logger { get; }

        public Summ(ILogger logger)
        {
            Logger = logger;
        }
        public void Sum(int a, int b)
        {
            Logger.Event("Считаем");
            Thread.Sleep(1000);
            Logger.Event("Посчитали. Ответ:");

            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
