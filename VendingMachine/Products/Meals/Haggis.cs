using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.Meals
{
    /// <summary>
    /// Haggis product class
    /// </summary>
    public class Haggis : Product, IProduct
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Haggis()
        {
            this.Name = "Haggis";
            this.Price = 65;
            this.TextDescription = "It's a meat and vegetables in a sheeps stomach";
            this.ProductID = 6;
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
            Console.WriteLine("You eat the haggis, now you feel sick.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
