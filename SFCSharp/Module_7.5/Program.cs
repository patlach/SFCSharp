using System;

namespace Module_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1,ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
