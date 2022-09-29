using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public delegate int GetProductsDelegate(int x);
    public class Product
    {
        private static int count=1000;

        public Category Category { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }


        public Product()
        {
            ProductId = "P" + count++;
        }
    }
}
