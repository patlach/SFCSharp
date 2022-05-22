using System;
using System.Collections.Generic;
using System.Text;

namespace Module_4._2
{
    internal class Convoy
    {
        public void Anketa()
        {
            (string name, int age) anketa;

            Console.WriteLine("Enter your name: ");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and your age {1}", anketa.name, anketa.age);
        }

        public void ConvoyPet()
        {
            (string name, string type, double age, int nameCount) pet;

            Console.WriteLine("Enter pet name: ");
            pet.name = Console.ReadLine();
            Console.WriteLine("Enter pet type: ");
            pet.type = Console.ReadLine();
            Console.WriteLine("Enter pet age: ");
            pet.age = double.Parse(Console.ReadLine());

            pet.nameCount = pet.name.Length;

            Console.WriteLine("You enter pet info: Name {0}, Type{1}, Age: {2}, Name Lenght: {3}", pet.name, pet.type, pet.age, pet.nameCount);
        }
    }
}
