namespace VendingMachine.Products
{
    public interface IProduct
    {
        /// <summary>
        /// Checks if there is enough money in the machine and deducts the price of the product.
        /// </summary>
        void Buy();

        /// <summary>
        /// Displays product information.
        /// </summary>
        void Description();

        /// <summary>
        /// Displays usage text of product.
        /// </summary>
        void Use();
    }
}