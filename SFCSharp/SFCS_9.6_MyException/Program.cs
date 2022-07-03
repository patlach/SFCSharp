using System;

namespace SFCS_9._6_MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] ex = new Exception[5];

            ex[0] = new Exception("my ex");
            ex[1] = new DivideByZeroException();
            ex[2] = new FormatException();
            ex[3] = new ArgumentOutOfRangeException();
            ex[4] = new ArgumentException();

            foreach (Exception e in ex)
            {
                Console.WriteLine(e);
            }
            
        }

    }
}
