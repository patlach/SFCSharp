using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._6_final
{
    public class GlobalOrder<T> { }
    public class Order<TDelivery, TProducts> : GlobalOrder<Product> 
        where TDelivery : Delivery
        where TProducts : Product
    {
        private int _OrderNumber;
        public int OrderNumber
        {
            get { return _OrderNumber; } 
            set { _OrderNumber = value; }
        }

        public string Description { get; set; }

        public TDelivery Delivery { get; set; }

        public Product Product { get; set; }

        public Order() { }

        public Order(int ordernum, TDelivery delivery, Product product, string description)
        {
            OrderNumber = ordernum;
            Delivery = delivery;
            Product = product;
            Description = description;
        }

        public void OrderInfo()
        {
            Console.WriteLine($"Your order number: {0} \nDescription: {2}", OrderNumber, Description);
            Product.ProductInfo();
            Delivery.DeliveryInfo();
        }

    }
}
