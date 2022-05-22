using System;

namespace Module_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //final exercise by module 4
            (string FirstName, string LastName, string Login, int LoginLength, bool HasPet, string[] Favcolor, double Age) User;

            for (int u = 0; u < 3; u++)
            {
                Console.WriteLine("Enter your first name: ");
                User.FirstName = Console.ReadLine();

                Console.WriteLine("Enter your last name: ");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Enter your login: ");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Do you have pet? Enter yes or no: ");

                var Answer = Console.ReadLine();

                if (Answer == "Yes")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Enter your age: ");
                User.Age = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your 3 favourite color");
                User.Favcolor = new string[3];
                for (int i = 0; i < User.Favcolor.Length; i++)
                {
                    User.Favcolor[i] = Console.ReadLine();
                }
            }

            //Convoy cv = new Convoy();
            //cv.ConvoyPet();

            //Arr arr = new Arr();
            //arr.ArraySort();
        }
    }
}
