using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.СonveyorBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarPlant carPlant = new CarPlant();

            Conveyor conveyor = new CarConveyor();

            carPlant.Construct(conveyor);

            conveyor.Product.Show();

            Console.ReadLine();
        }
    }
}
