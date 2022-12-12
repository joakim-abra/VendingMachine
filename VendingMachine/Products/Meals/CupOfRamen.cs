using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.Meals
{
    /// <summary>
    /// Cup of Ramen class
    /// </summary>
    public class CupOfRamen : Product, IProduct
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CupOfRamen()
        {
            this.Name = "Cup of Ramen";
            this.Price = 47;
            this.TextDescription = "Hot box of noodles and chicken";
            this.ProductID = 5;
        }
        /// <inheritdoc/>
        public void Buy()
        {
            if (MachineWallet.InsertedAmount - this.Price > 0)
            {
                MachineWallet.InsertedAmount -= this.Price;
                this.Use();
            }
            else
            {
                Console.WriteLine("\nInsufficient amount of money inserted, please insert more money into the machine.");
                Console.WriteLine("Press any key to return to main menu");
                Console.ReadKey();
            }
        }
        /// <inheritdoc/>
        public void Description()
        {
            Console.WriteLine($"Product: {this.Name}\n");
            Console.WriteLine($"Price: {this.Price}\n");
            Console.WriteLine($"Description: {this.TextDescription}");
        }
        /// <inheritdoc/>
        public void Use()
        {
            Console.Clear();
            Console.WriteLine("You eat the noodles. It's pretty good.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
