using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Wallets
{
    public class MachineWallet
    {
        public static int InsertedAmount { get; set; } = 0;


        public static void CurrentAmountInserted()
        {
            Console.WriteLine($"There is currently {InsertedAmount} SEK inserted in the machine.");
        }
        public void InsertMoney(Wallet wallet)
        {
            CurrentAmountInserted();
            wallet.DisplayWallet();
            SelectMoneyValue(wallet);

        }



        private void SelectMoneyValue(Wallet wallet)
        {
            while (true)
            {
                Console.Clear();
                CurrentAmountInserted();
                wallet.DisplayWallet();
                Console.WriteLine("Select value of currency to enter (0 to cancel): ");
                string choice = Console.ReadLine();
                int amount = 0;
                wallet.Coins.TryGetValue(int.Parse(choice), out amount);
                if (choice == "0")
                {
                    break;
                }
                if (amount != 0)
                {
                    SelectAmountOfValue(wallet, int.Parse(choice));
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                }
            }
        }
        //Inserts coins or bills of selected value
        private void SelectAmountOfValue(Wallet wallet, int value)
        {
            bool run = true;
            int convertedAmount = 0;
            while (run)
            {
                Console.WriteLine("Enter how many coins or bills to enter: ");
                string amount = Console.ReadLine();
                try
                {
                    convertedAmount = int.Parse(amount);
                    if (convertedAmount < 0)
                    {
                        Console.WriteLine("Invalid selection\n");
                    }
                    else
                    {
                        break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid selection\n");
                }
            }
            if (convertedAmount != 0)
            {

                if (wallet.Coins[value] < convertedAmount)
                {
                    Console.WriteLine($"Insufficient amount in wallet, inserting {wallet.Coins[value]} !\n");
                    InsertedAmount = value * convertedAmount;
                    wallet.Coins[value] = 0;

                }
                else
                {
                    InsertedAmount += value * convertedAmount;
                    wallet.Coins[value] -= convertedAmount;
                }

            }

        }

        //produces change to consumer and empties inserted amount
        public void Refund(Wallet wallet)
        {

            List<int> values = wallet.Coins.Keys.ToList();
            for (int i = values.Count - 1; i >= 0; i--)
            {
                if (InsertedAmount - values[i] >= 0)
                {
                    int numberReturned = 0;
                    while (InsertedAmount - values[i] >= 0)
                    {
                        InsertedAmount -= values[i];
                        wallet.Coins[values[i]]++;
                        numberReturned++;
                    }
                    Console.WriteLine($"You receive {numberReturned} {Wallet.Denomination(values[i])} of {values[i]} SEK back in change");
                }
            }
            wallet.DisplayWallet();
        }


    }
}
