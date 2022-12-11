using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Menus;
using VendingMachine.ProductFactories;
using VendingMachine.Products;
using VendingMachine.Wallets;

namespace VendingMachine
{
    /// <summary>
    /// Manager class for running the program
    /// </summary>
    public class VendingManager
    {
        /// <summary>
        /// Instantiates a new MachineWallet
        /// </summary>
        private MachineWallet MachineWallet = new MachineWallet();

        /// <summary>
        /// Instantiates a new Menu
        /// </summary>
        private Menu Menu = new Menu();

        /// <summary>
        /// Instantiates a user wallet
        /// </summary>
        public Wallet Wallet = Wallet.CurrentWallet();

        /// <summary>
        /// Holds a generic product class 
        /// </summary>
        private IProduct product = null;

        /// <summary>
        /// Generic factory property.
        /// </summary>
        private ProductFactory productFactory = null;


        /// <summary>
        /// Runs the main logic of the program.
        /// </summary>
        public void RunVendingMachine()
        {
            bool run = true;
            while(run)
            {
                Console.Clear();
            int selection = Menu.RunMenu();
            switch(selection)
            {
                case 0:
                        Console.Clear();
                        MachineWallet.InsertMoney(Wallet);
                    break;
                case 1: 
                case 2:
                case 3:
                case 4: 
                case 5:
                case 6:         
                case 7:
                case 8: 
                case 9:
                    Console.Clear();
                    productFactory = ProductFactory.CreateProductFactory(selection);
                    product = productFactory.GetProduct(selection);
                    product.Description();
                    string purchase = Menu.PurchasePrompt();
                    if(purchase=="y")
                    {
                        product.Buy();
                    }
                        product = null;
                        productFactory = null;
                        break;
                case 10:
                    MachineWallet.Refund(Wallet);
                        run = false;
                    break;
            }
        }

            }

    }
}
