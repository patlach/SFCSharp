using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7._6
{
	public abstract class Delivery
	{
		public static string Address;


	}

	class HomeDelivery : Delivery { /* ... */ }

	class PickPointDelivery : Delivery { /* ... */ }

	class ShopDelivery : Delivery { /* ... */ }
}
