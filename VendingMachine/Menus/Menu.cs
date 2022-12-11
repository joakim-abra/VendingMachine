using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VendingMachine.Wallets;

namespace VendingMachine.Menus
{
    internal class Menu
    {
        private void ShowMainMenu()
        {
            Console.WriteLine("\n*Welcome to the Vending Machine!*\n*Please insert coins or select a product to view information*\n");
            MachineWallet.CurrentAmountInserted();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0) Insert Coins");
            Console.WriteLine("\n----------Drinks-------------");
            Console.WriteLine("1) Coffee");
            Console.WriteLine("2) Milk");
            Console.WriteLine("3) Grog");
            Console.WriteLine("\n-----------Meals-------------");
            Console.WriteLine("4) Burger");
            Console.WriteLine("5) Cup of Ramen");
            Console.WriteLine("6) Haggis");
            Console.WriteLine("\n---Rough Weather Products----");
            Console.WriteLine("7) Galoshes");
            Console.WriteLine("8) Sylvester");
            Console.WriteLine("9) Umbrella");
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("10) Cancel purchase and refund any change\n");
        }

        public int RunMenu()
        {
            do
            {
                ShowMainMenu();
                int selection = int.Parse(Console.ReadLine());
                if(selection >= 0 && selection <=9)
                {
                    return selection;
                }
                else if(selection==10)
                {
                    Console.WriteLine("Exiting Program\n");
                    //refund money;
                    return selection;
                }
                else
                {
                    Console.WriteLine("Incorrect selection!\n");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);

        }

        public string PurchasePrompt()
        {
            while(true)
            { 
            Console.WriteLine("Do you wish to purchase this product ? (y/n): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "y" && choice != "n")
            {
                Console.WriteLine("Invalid Choice!\n");
            }
            else
                {
                    return choice;
                }
            }
            

        }

    }

}
