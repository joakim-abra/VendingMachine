using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;
using VendingMachine.Products.Meals;

namespace VendingMachine.ProductFactories
{
    /// <summary>
    /// Factory for meal product objects
    /// </summary>
    public class MealFactory : ProductFactory
    {
        /// <inhertitdoc/>
        public override IProduct GetProduct(int productID)
        {
            switch (productID)
            {
                case 4: return new Burger();
                case 5: return new CupOfRamen();
                case 6: return new Haggis();
            }
            return null;
        }
    }
}
