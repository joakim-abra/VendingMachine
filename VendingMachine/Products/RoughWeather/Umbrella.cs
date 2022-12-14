using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.RoughWeather
{
    /// <summary>
    /// Umbrella class
    /// </summary>
    public class Umbrella : Product, IProduct
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Umbrella()
        {
            this.Name = "Umbrella";
            this.Price = 99;
            this.TextDescription = "It's a flimsy umbrella.";
            this.ProductID = 9;
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
            Console.WriteLine("You unfold the Umbrella.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
