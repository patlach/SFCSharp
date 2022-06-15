using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._6
{
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public int Number;
        public string Description;


    }
}
