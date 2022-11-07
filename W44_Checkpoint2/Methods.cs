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


namespace W44_Checkpoint2
{
    internal class Methods
    {
        /*  
         *  --------------------------------------------
         *  ---              Level 2                 ---
         *  --------------------------------------------
        */

        /*
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
        */


        /*  
         *  --------------------------------------------
         *  ---              Level 3                 ---
         *  --------------------------------------------
        */

        public static List<Product> EnterItems()
        {
            string input;
            List<Product> products = new List<Product>();

            while (true)
            {
                string category = "";
                string productName = "";
                int price = 0;

                // do-while loops: preventing fields from being left empty
                do
                {
                    Console.Write("Category: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    if (String.IsNullOrEmpty(input) || input == " ")
                    {
                        Console.WriteLine("Field can't be left empty!");
                        category = "";
                    }
                    else if (input.Any(char.IsDigit))
                    {
                        Console.WriteLine("Category can't contain numbers!");
                        category = "";
                    }
                    else
                    {
                        category = input;
                    }
                } while (category == ""); 
                if (input.ToLower() == "q")
                {
                    break;
                }

                do
                {
                    Console.Write("Product name: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces
                    if (String.IsNullOrEmpty(input) || input == " ")
                    {
                        Console.WriteLine("Field can't be left empty!");
                        productName = "";
                    }
                    else if (input.All(char.IsDigit))
                    {
                        Console.WriteLine("Product can't consist of only numbers!");
                        category = "";
                    }
                    else
                    {
                        productName = input;
                    }
                } while (productName == "");
                if (input.ToLower() == "q")
                {
                    break;
                }

                // do-while preventing price from being 0 or a non-integer
                do 
                {
                    Console.Write("Price: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    if (input.ToLower() == "q")
                    {
                        break;
                    }
                    else if (String.IsNullOrEmpty(input) || input == " ")
                    {
                        Console.WriteLine("Field can't be left empty!");
                        price = 0;
                    }
                    else if (int.TryParse(input, out int value))
                    {
                        if (value == 0)
                        {
                            Console.WriteLine("Price cannot be 0!");
                        }
                        price = value;
                    }
                    else
                    {
                        Console.WriteLine("Price has to be a number!");
                        price = 0;
                    }

                } while (price == 0);
                if (input.ToLower() == "q")
                {
                    break;
                }


                products.Add(new Product(category, productName, price));
            }
            return products;
        }
    }
}
