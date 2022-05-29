using System;

namespace Module_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Egor";

            Console.WriteLine(someName);

            GetName(out someName, out string oldname);
            Console.WriteLine(someName);
            Console.WriteLine(oldname);

            Console.ReadKey();
        }
        //int SumNumbers(ref int num1, in int num2, out int num3, int num4) { };
        static void GetName(out string name, out string oldname)
        {
            oldname = "Егор";
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }

    }
}
