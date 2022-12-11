namespace VendingMachine.Wallets
{
    /// <summary>
    /// Singleton class of user/buyer's wallet
    /// </summary>
    public class Wallet
    {
        /// <summary>
        /// Contains the wallet instance
        /// </summary>
        public static Wallet UserWallet;

        /// <summary>
        /// Holds the amount of each denomination of value.
        /// Key is the value of a bill or coin, value is the amount.
        /// </summary>
        public Dictionary<int, int> Coins { get; set; }

        /// <summary>
        /// Private constructor, initiates the default values contained in wallet.
        /// </summary>
        private Wallet()
        {
            Coins = new Dictionary<int, int>() { { 1, 10 }, { 5, 10 }, { 10, 10 }, { 20, 0 }, { 50, 0 }, { 100, 0 } };
        }

        /// <summary>
        /// Provides a Wallet instance of none exists.
        /// </summary>
        /// <returns></returns>
        public static Wallet CurrentWallet()
        {
            if (UserWallet == null)
            {
                UserWallet = new Wallet();
            }
            return UserWallet;
        }

        /// <summary>
        /// Displays the total value of the money in the wallet.
        /// </summary>
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

        /// <summary>
        /// Determines if a value is a bill or coin, for display purposes.
        /// </summary>
        /// <param name="value">vakue of a denomination</param>
        /// <returns>the type of denomnination</returns>
        public static string Denomination(int value)
        {
            if (value > 10)
            {
                return "bill(s)";
            }
            return "coin(s)";
        }

        /// <summary>
        /// Displays the amount of each value denomination in the wallet.
        /// </summary>
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