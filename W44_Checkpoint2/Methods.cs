using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W44_Checkpoint2;

/*  
 *  --------------------------------------------
 *  ---         Class for Level 2+           ---
 *  --------------------------------------------
*/

Console.WriteLine("".PadRight(20) + "Total price: ".PadRight(20) + totalSum);
namespace W44_Checkpoint2
{
    internal class Methods
    {
        public static List<Product> EnterItems()
        {
            string input;
            List<Product> products = new List<Product>();

            while (true)
            {
                string category = "";
                string productName = "";
                int price = 0;

                Console.Write("Category: ");
                input = Console.ReadLine();
                category = input.Trim();
                if (input.Trim().ToLower() == "q")
                {
                    break;
                }

                Console.Write("Product name: ");
                input = Console.ReadLine();
                productName = input.Trim();
                if (input.Trim().ToLower() == "q")
                {
                    break;
                }

                Console.Write("Price: ");
                input = Console.ReadLine();

                if (input.Trim().ToLower() == "q")
                {
                    break;
                }
                else if (int.TryParse(input, out int value))
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price has to be a number! Automatically set to 0");
                    price = 0;
                }

                products.Add(new Product(category, productName, price));
            }
            return products;
        }
    }
}
