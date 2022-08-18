using System;
using System.Linq;

namespace Module_14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            var a = people.Where(p => p.StartsWith("А")).OrderBy(p => p).ToList();

            foreach (string s in a)
                Console.WriteLine(s);
        }
    }
}
