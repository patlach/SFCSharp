using System;

namespace Module_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception ex = new Exception("qqqq");

            ex.Data.Add("Exception date: ", DateTime.Now);
            ex.HelpLink = "qq.qq";

            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.HelpLink);
            Console.WriteLine(ex.Data);

        }
    }
}
