using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Products
{
    public abstract class Product
    {
        public string Name { get; set; }

        public string TextDescription { get; set; }

        public int Price { get; set; }

        public int ProductID { get; set; }


    }
}
