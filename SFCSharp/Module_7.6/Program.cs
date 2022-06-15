using System;

namespace Module_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order<HomeDelivery> o1;
            Order<int> o;
        }
    }

    class BaseClass<T> where T : struct
    {
        public T Field;
    }

    internal class DerivedClass<T> : BaseClass<T> where T : struct
    {
        public DerivedClass(T property)
        {
            Property = property;
        }

        public T Property { get; set; }
    }
}
