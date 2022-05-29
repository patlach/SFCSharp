using System;
using System.Text.RegularExpressions;

namespace Module_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = NewUser();
            ShowUser(user);
        }

        static (string FirstName, string LastName, int Age, string[] PetsNames, string[] FavColors) NewUser()
        {
            (string FirstName, string LastName, int Age, string[] PetsNames, string[] FavColors) User;

            string pattern = "[0-9!@#$%^&*()_+-={}:;<>?/|,.~`]";
            var regex = new Regex(pattern);
             
            #region First name

            string firstname;
            
            do
            {
                Console.WriteLine("Enter your first name: ");
                firstname = Console.ReadLine();
                if (firstname.Length > 2)
                    if(!regex.IsMatch(firstname))
                    {
                        break;
                    }
                Console.WriteLine("Enter your right first name!");
            } while (true);

            User.FirstName = firstname;

            #endregion

            #region Last name

            string lastname;

            do
            {
                Console.WriteLine("Enter your last name: ");
                lastname = Console.ReadLine();
                if (lastname.Length > 2)
                    if (!regex.IsMatch(lastname))
                    {
                        break;
                    }
                Console.WriteLine("Enter your right last name!");
            } while (true);

            User.LastName = lastname;

            #endregion

            #region Age

            string age;
            int intage;

            do
            {
                Console.WriteLine("Enter your age: ");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));

            User.Age = intage;

            #endregion

            #region Pets

            string havepets;
            string pets;
            int intpets;

            while (true)
            {
                Console.WriteLine("Do you have pets? Enter Yes or No.");
                havepets = Console.ReadLine();

                if (havepets.ToLower() == "yes")
                {
                    do
                    {
                        Console.WriteLine("How many pets do you have?");
                        pets = Console.ReadLine();
                    } while (CheckNum(pets, out intpets));

                    User.PetsNames = PetsNames(intpets);
                    break;
                }
                else if (havepets.ToLower() == "no")
                {
                    User.PetsNames = new string[0];
                    break;
                }
            }

            #endregion

            #region Colors

            string colors;
            int intcolors;

            do
            {
                Console.WriteLine("How many do you have favorite colors? ");
                colors = Console.ReadLine();
            } while (CheckNum(colors, out intcolors));

            User.FavColors = Colors(intcolors);

            #endregion

            return User;
        }

        static void ShowUser((string FirstName, string LastName, int Age, string[] PetsName, string[] Favcolors) user)
        {
            Console.WriteLine("\n\nYou entered next data: ");
            Console.WriteLine("\nFirst name: {0} \nLast Name: {1} \nAge: {2}", user.FirstName, user.LastName, user.Age);

            Console.WriteLine("\nYour pets name:");
            for (int i = 0; i < user.PetsName.Length; i++)
            {
                Console.WriteLine(user.PetsName[i]);
            }

            Console.WriteLine("\nYour favorite color: ");
            for (int i = 0; i < user.Favcolors.Length; i++)
            {
                Console.WriteLine(user.Favcolors[i]);
            }  
        }

        static bool CheckNum(string num, out int corrnumber)
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            Console.WriteLine("Enter more than 0!");
            corrnumber = 0;
            return true;
        }

        static string[] PetsNames(int num)
        {
            string[] names = new string[num];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter name for {0} pet: ", i + 1);
                names[i] = Console.ReadLine();
            }

            return names;
        }

        static string[] Colors(int num)
        {
            string[] colors = new string[num];

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Enter name for {0} color: ", i + 1);
                colors[i] = Console.ReadLine();
            }

            return colors;
        }
    }
}
