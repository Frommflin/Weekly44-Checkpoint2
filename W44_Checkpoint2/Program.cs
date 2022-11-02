﻿/*  
 *  --------------------------------------------
 *  ---     Weekly mini-project, week 44     ---
 *  --------------------------------------------
*/


using W44_Checkpoint2;

Console.WriteLine("Enter your product. To exit write 'Q'.");
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
