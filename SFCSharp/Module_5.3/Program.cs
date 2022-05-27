using System;

namespace Module_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Егор";
            Console.WriteLine(someName);

            GetName(someName);
            Console.WriteLine(someName);

            Console.ReadKey();
        }

        static void GetName(string name)
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
    }
}
