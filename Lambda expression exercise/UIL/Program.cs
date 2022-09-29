using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace UIL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Category category1 = new Category();

            List<Product> products = new List<Product>
            {
                new Product {Category = category1},
                new Product {Category = category1}
            };

            
            GetProductsDelegate prodDel = (x) => products.FindAll(y => y.Category.CategoryId == x).Count;

            Console.WriteLine(prodDel(1));
        }

        
    }
}
