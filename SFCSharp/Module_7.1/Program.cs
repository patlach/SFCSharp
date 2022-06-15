using System;

namespace Module_7._1
{
        class SmartHelper
        {
            private string name;

            public SmartHelper(string name)
            {
                this.name = name;
            }

            public void Greetings(string name)
            {
                Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
            DerivedClass dc = new DerivedClass();

            dc.Display();

            D d = new D();
            E e = new E();

            d.Display();

            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
                
                SmartHelper helper = new SmartHelper("Олег");
                helper.Greetings("Грег");

                Console.ReadKey();
            }

        }
    }
