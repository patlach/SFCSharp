using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._1
{
    abstract class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }

    class Employe : Person
    {
        // Булевый флаг, сообщающий, находится ли сотрудник на смене
        public bool IsOnShift;

        public Employe(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
    }

    class Guest : Person
    {
        // Дата и время прибытия гостя
        public DateTime ArrivalDate;

        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }

    abstract class AbstractClass
    {
        public string Name;

        public virtual void Display()
        {
            Console.WriteLine("Это неизвестное животное");
        }
    }

    abstract class FourLeggedAnimal
    {
        public virtual void Describe()
        {
            Console.WriteLine("Это неизвестное животное");
        }
    }

    class Dog : FourLeggedAnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - собака");
        }
    }

    class Cat : FourLeggedAnimal
    {
    }

    Dog d = new Dog();
    Cat a = new Cat();

    FourLeggedAnimal animal = dog;
    animal.Describe();


}
