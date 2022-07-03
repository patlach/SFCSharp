using System;

namespace SFCS_9._6_SortLastName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LastNames();

                Console.WriteLine("For sort from A-Z enter 1, from Z-A enter 2");
                int enter = int.Parse(Console.ReadLine());

                Sort(LastNames(), enter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string[] LastNames()
        {
            string[] lastNames = new string[5];

            Console.WriteLine("Enter Last Names: ");
            for (int i = 0; i < lastNames.Length; i++)
            {
                Console.WriteLine("Enter {0} Last Name:", i + 1);

                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("You enter null string");
                }
                else if (int.TryParse(name, out i))
                {
                    throw new Exception("Last name can not contain number");
                }
                else
                {
                    lastNames[i] = name;
                }  
            }

            return lastNames;
        }

        static void Sort(string[] lastNames, int enter)
        {
            if (enter == 1)
            {
                Array.Sort(lastNames);
                Print(lastNames);
            }
            else
            {
                Array.Sort(lastNames);
                Array.Reverse(lastNames);
                Print(lastNames);
            }
        }

        static void Print(string[] array)
        {
            foreach (string lastNames in array)
            {
                Console.WriteLine(lastNames);
            }
        }
    }
}
