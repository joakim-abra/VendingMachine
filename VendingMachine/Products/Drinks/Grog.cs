using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.Drinks
{
    public class Grog : Product, IProduct
    {
        public Grog()
        {
            this.ProductID = 3;
            this.Name = "Grog";
            this.TextDescription = "A 50cl cup of Moscow Mule, 2 parts Ginger Beer & 1 part Vodka";
            this.Price = 55;
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
            Console.WriteLine("You drink the Grog. You are now drunk.");
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

