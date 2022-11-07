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

        /*
        public static void Menu(int i)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if(i == 1)
            {
                Console.WriteLine("Enter your product. To exit write 'Q'.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Type 'A' to add more products, 'Q' to quit");
            }
            Console.ResetColor();
        }

        public static List<Product> EnterItems()
        {
            string input;
            List<Product> products = new List<Product>();

            while (true)
            {
                Console.ResetColor(); // Always start with resetting console textcolor

                string category = "";
                string productName = "";
                int price = 0;

                // do-while loops: preventing fields from being left empty
                do
                {
                    Console.ResetColor();
                    Console.Write("Category: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ResetColor();
                    break;
                }

                do
                {
                    Console.ResetColor();
                    Console.Write("Product name: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ResetColor();
                    break;
                }

                // do-while preventing price from being 0 or a non-integer
                do 
                {
                    Console.ResetColor();
                    Console.Write("Price: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ResetColor();
                    break;
                }


                products.Add(new Product(category, productName, price));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product successfully added");
            }
            return products;
        }

        public static void PrintList(List<Product> products)
        {
            int totalSum = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List of products:");
            Console.WriteLine();
            Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
            Console.WriteLine("------------------------------------------------------------");
            foreach (Product product in products)
            {
                Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price);
                totalSum += product.Price;
            }
            Console.WriteLine();
            Console.WriteLine("".PadRight(20) + "Total price: ".PadRight(20) + totalSum);
        }
        */



        /*  
         *  --------------------------------------------
         *  ---              Level 4                 ---
         *  --------------------------------------------
        */
        public static void Menu(int i)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (i == 1)
            {
                Console.WriteLine("Enter your product. To exit write 'Q'.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Type 'A' to add more products, 'S' so search in products or 'Q' to quit");
            }
            Console.ResetColor();
        }

        public static List<Product> EnterItems()
        {
            string input;
            List<Product> products = new List<Product>();

            while (true)
            {
                Console.ResetColor(); // Always start with resetting console textcolor

                string category = "";
                string productName = "";
                int price = 0;

                // do-while loops: preventing fields from being left empty
                do
                {
                    Console.ResetColor();
                    Console.Write("Category: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ResetColor();
                    break;
                }

                do
                {
                    Console.ResetColor();
                    Console.Write("Product name: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ResetColor();
                    break;
                }

                // do-while preventing price from being 0 or a non-integer
                do
                {
                    Console.ResetColor();
                    Console.Write("Price: ");
                    input = Console.ReadLine();
                    input.Trim(); // Always removes starting or ending whitespaces

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ResetColor();
                    break;
                }


                products.Add(new Product(category, productName, price));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product successfully added");
            }
            return products;
        }

        public static void PrintList(List<Product> products, string search = "none")
        {
            int totalSum = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List of products:");
            Console.WriteLine();
            Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
            Console.WriteLine("------------------------------------------------------------");
            foreach (Product product in products)
            {
                if (product.Name.Contains(search))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price);
                totalSum += product.Price;
                
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("".PadRight(20) + "Total price: ".PadRight(20) + totalSum);
        }

        public static void SearchProduct(List<Product> products)
        {
            string input;
            Console.Write("Search product: ");
            input = Console.ReadLine();
            input.Trim();

            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Matcing items are highlighted.");
            Console.ResetColor();
            PrintList(products, input);
        }
    }
}
