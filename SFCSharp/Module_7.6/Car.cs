using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._6
{
    abstract class Engine { }

    abstract class CarPart { }

    class ElectricEngine : Engine { }
    
    class GasEngine : Engine { }

    class Battary : CarPart { }

    class Difirential : CarPart { }

    class Wheel : CarPart { }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }
}
