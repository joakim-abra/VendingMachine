using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;

namespace VendingMachine.ProductFactories
{
    public abstract class ProductFactory
    {
        public abstract IProduct GetProduct(int productID);

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
