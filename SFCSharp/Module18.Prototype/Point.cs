using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Prototype
{
    class Point : ILocation
    {

        double Latitude;
        double Longitude;

        public Point(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public ILocation Clone()
        {
            return new Point(Latitude, Longitude);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новая точка на карте с координатами {Longitude}, {Latitude}");
        }
    }
}
