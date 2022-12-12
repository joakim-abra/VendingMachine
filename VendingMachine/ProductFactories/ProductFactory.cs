using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;

namespace VendingMachine.ProductFactories
{
    /// <summary>
    /// Abstract Factory class
    /// </summary>
    public abstract class ProductFactory
    {
        /// <summary>
        /// Provides product object from factory
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public abstract IProduct GetProduct(int productID);

        /// <summary>
        /// Creates factory corresponding to category of product in menu selection.
        /// </summary>
        /// <param name="selection"></param>
        /// <returns></returns>
        public static ProductFactory CreateProductFactory(int selection)
        {

            if (selection >0 && selection<=3) {
                return new DrinkFactory(); }
            if (selection >3 && selection < 7)
            {
                return new MealFactory();
            }
            return new RoughWeatherFactory();
        }
    }
}
