using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.Drinks
{
    internal class Milk : Product, IProduct
    {

        public Milk()
        {
            this.ProductID = 2;
            this.Name = "Milk";
            this.TextDescription = "A 50cl bottle of milk from Arla. Contains 3% fat.";
            this.Price = 12;
        }
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

        /// <inherit/>
        public void Use()
        {
            Console.Clear();
            Console.WriteLine("You drink the Milk.");
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
