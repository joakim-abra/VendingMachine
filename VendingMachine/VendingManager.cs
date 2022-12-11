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
    public class VendingManager
    {
        private MachineWallet MachineWallet = new MachineWallet();
        private Menu Menu = new Menu();
        public Wallet Wallet = Wallet.CurrentWallet();
        private IProduct product = null;
        private ProductFactory productFactory = null;


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
                            product = null;
                            productFactory = null;
                        }
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
