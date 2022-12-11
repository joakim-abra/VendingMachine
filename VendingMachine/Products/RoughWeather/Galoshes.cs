using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.RoughWeather
{
    internal class Galoshes : Product, IProduct
    {
        public Galoshes()
        {
            this.Name = "Galoshes";
            this.Price = 40;
            this.TextDescription = "It's a pair of galoshes, keeps your shoes nice and fresh.";
            this.ProductID = 7;
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

        public void Description()
        {
            Console.WriteLine($"Product: {this.Name}\n");
            Console.WriteLine($"Price: {this.Price}\n");
            Console.WriteLine($"Description: {this.TextDescription}");
        }

        public void Use()
        {
            Console.Clear();
            Console.WriteLine("After much trouble you finally manage to put the galoshes on your shoes.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
