using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.СonveyorBuilder
{
    class CarConveyor : Conveyor
    {
        public CarConveyor()
        {
            _product = new Product("Автомобиль");
        }
        public override void BuildDoors()
        {
            _product["doors"] = "4";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "150 л.c.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама автомобиля";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "4";
        }
    }
}
