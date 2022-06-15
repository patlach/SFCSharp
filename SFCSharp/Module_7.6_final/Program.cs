using System;
using System.Collections.Generic;
using Module_7._6_final_ExMet;

namespace Module_7._6_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeDelivery homeDelivery = new HomeDelivery();
            Product product = new Product();

            Order<HomeDelivery, Product> order = new Order<HomeDelivery, Product>(1, homeDelivery, product, "cc");

            order.OrderInfo();
        }
    }
}
