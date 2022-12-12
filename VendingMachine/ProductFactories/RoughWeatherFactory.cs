using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;
using VendingMachine.Products.Meals;
using VendingMachine.Products.RoughWeather;

namespace VendingMachine.ProductFactories
{
    /// <summary>
    /// Factory class for Rough Weather products
    /// </summary>
    public class RoughWeatherFactory : ProductFactory
    {
        /// <inheritdoc/>
        public override IProduct GetProduct(int productID)
        {
            switch (productID)
            {
                case 7: return new Galoshes();
                case 8: return new Sylvester();
                case 9: return new Umbrella();
            }
            return null;
        }
    }
    }

