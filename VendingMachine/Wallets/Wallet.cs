namespace VendingMachine.Wallets
{
    public class Wallet
    {
        public static Wallet UserWallet;
        public Dictionary<int, int> Coins { get; set; }

        private Wallet()
        {
            Coins = new Dictionary<int, int>() { { 1, 10 }, { 5, 10 }, { 10, 10 }, { 20, 0 }, { 50, 0 }, { 100, 0 } };
        }
        public static Wallet CurrentWallet()
        {
            if (UserWallet == null)
            {
                UserWallet = new Wallet();
            }
            return UserWallet;
        }

        public void CurrentTotal()
        {
            int totalSum = 0;
            foreach (var coin in Coins)
            {
                totalSum += coin.Key * coin.Value;
            }
            Console.WriteLine($"Total amount of money in wallet is {totalSum} SEK");
            Console.WriteLine("-------------------------------------------------");
        }

        public static string Denomination(int value)
        {
            if (value > 10)
            {
                return "bill(s)";
            }
            return "coin(s)";

        }
        public void DisplayWallet()
        {
            Console.WriteLine("----------------------------------------------------");
            CurrentTotal();
            Console.WriteLine("You have the following denominations in your wallet:\n");
            foreach (var item in UserWallet.Coins)
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key} SEK: {item.Value} {Denomination(item.Key)}.\n");
                }
            }

        }

    }
}