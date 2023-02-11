using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Prototype
{
    class Place : Point
    {
        string Address;

        public Place(string address)
        {
            Address = address;
        }

        public ILocation Clone()
        {
            return new Place(Address);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новый объект по адресу {Address}. ");
        }
    }
}
