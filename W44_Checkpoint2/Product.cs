using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W44_Checkpoint2
{
    internal class Product
    {
        public Product(string category, string productName, int price)
        {
            this.Category = category;
            this.Name = productName;
            this.Price = price;
        }

        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
