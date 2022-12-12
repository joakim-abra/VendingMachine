using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.Drinks
{
    /// <summary>
    /// Coffe product class
    /// </summary>
    public class Coffee : Product, IProduct
    {

        /// <summary>
        /// Constructor with initializing of properties
        /// </summary>
        public Coffee()
        {
            this.ProductID = 1;
            this.Name = "Coffee";
            this.TextDescription = "A cup of black coffee from a vending machine, what do you expect?";
            this.Price = 10;
        }

        /// <inhertitdoc/>
        public void Buy()
        {
            if(MachineWallet.InsertedAmount-this.Price > 0)
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

        /// <inhertitdoc/>
        public void Use()
        {
            Console.Clear();
            Console.WriteLine("You drink the coffee. It tastes terrible.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }

        /// <inherit/>
        public void Description()
        {
            Console.WriteLine($"Product: {this.Name}\nDescription: {this.TextDescription}\nPrice: {this.Price}");
        }
    }
}
