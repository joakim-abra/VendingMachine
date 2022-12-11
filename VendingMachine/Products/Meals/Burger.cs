using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Wallets;

namespace VendingMachine.Products.Meals
{
    public class Burger : Product, IProduct
    {
        public Burger()
        {
            this.ProductID = 4;
            this.Price = 35;
            this.TextDescription = "It's a Cheeseburger.";
            this.Name = "Burger";
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
            Console.WriteLine($"Description: { this.TextDescription}");
        }

        public void Use()
        {
            Console.Clear();
            Console.WriteLine("You eat the hamburger. It's not very good.");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
