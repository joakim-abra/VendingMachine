using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Products
{
    /// <summary>
    /// Abstract product base class
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Description of Product
        /// </summary>
        public string TextDescription { get; set; }

        /// <summary>
        /// Price of product
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }


    }
}
