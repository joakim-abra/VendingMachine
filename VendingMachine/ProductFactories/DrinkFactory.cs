using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;
using VendingMachine.Products.Drinks;

namespace VendingMachine.ProductFactories
{
    /// <summary>
    /// Factory for drink products
    /// </summary>
    public class DrinkFactory : ProductFactory
    {
        /// <inhertitdoc/>
        public override IProduct GetProduct(int productID)
        {
            switch(productID)
            { case 1: return new Coffee();
                case 2: return new Milk();
                case 3: return new Grog();
            }
            return null;
        }
    }
}
