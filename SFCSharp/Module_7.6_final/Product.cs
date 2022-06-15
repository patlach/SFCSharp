using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._6_final
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quentity { get; set; }

        protected double Total
        {
            get { return Price * Quentity; }
        }

        public void ProductInfo()
        {
            Console.WriteLine("Product: {0}, Price: {1}, Qty: {2} Total: {3}", Name, Price, Quentity, Total);
        }
    }
}
