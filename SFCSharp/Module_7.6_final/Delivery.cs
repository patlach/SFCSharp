using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._6_final
{
	public abstract class Delivery
	{
        public string FullName { get; set; }

		public string Phone { get; set; }

		public virtual void DeliveryInfo()
        {
			Console.WriteLine("Your name: {0}, Phone: {1}", FullName, Phone);
        }

	}

	class HomeDelivery : Delivery
	{
		public string CompanyName { get; set; }
		public string HomeAddress { get; set; }

        public override void DeliveryInfo()
        {
            Console.WriteLine($"You choose home delivery. \nDelivery Info: \nName: {FullName}, \nPhone: {Phone}, \nCompany Name: {CompanyName}, \nHome Address: {HomeAddress}");
        }

    }

	class PickPointDelivery : Delivery
	{	
		public string PickPointAddress { get; set; }

		public override void DeliveryInfo()
		{
			Console.WriteLine($"You choose PickPoint delivery. \nDelivery Info: \nName: {FullName}, \nPhone: {Phone}, \nPickPoint Address: {PickPointAddress}");
		}
	}

	class ShopDelivery : Delivery
	{
		public ShopDelivery(string fullname, string phone)
        {
			FullName = fullname;
			Phone = phone;
        }
	}
}
