using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Category
    {
        private static int count =1;

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {
            this.CategoryId = count++;
        }
    }
}
