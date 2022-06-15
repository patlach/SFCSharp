using System;
using System.Collections.Generic;
using System.Text;
using Module_7._6_final;

namespace Module_7._6_final_ExMet
{
    static class ExtensionMethod
    {
        public static void ProductPrice(this Product product)
        {
            Console.WriteLine("Product {0}, Price: {1}", product.Name, product.Price);
        }
    }
}
