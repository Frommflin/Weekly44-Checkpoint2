/*  
 *  --------------------------------------------
 *  ---     Weekly mini-project, week 44     ---
 *  --------------------------------------------
*/

using W44_Checkpoint2;

/*  
 *  --------------------------------------------
 *  ---              Level 1                 ---
 *  --------------------------------------------
*/

/*
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

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("List of products:");
Console.WriteLine();
Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
Console.WriteLine("------------------------------------------------------------");
foreach (Product product in products)
{
    Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price);
}
*/



/*  
 *  --------------------------------------------
 *  ---              Level 2                 ---
 *  --------------------------------------------
*/
/* 
List<Product> products = new List<Product>();
int totalSum = 0;

Console.WriteLine("Enter your product. To exit write 'Q'.");

products.AddRange(Methods.EnterItems());
List<Product> orderedProducts = products.OrderBy(p => p.Price).ToList();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("List of products:");
Console.WriteLine();
Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
Console.WriteLine("------------------------------------------------------------");
foreach (Product product in orderedProducts)
{
    Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price);
    totalSum += product.Price;
}
Console.WriteLine();
Console.WriteLine("".PadRight(20) + "Total price: ".PadRight(20) + totalSum);
*/



/*  
 *  --------------------------------------------
 *  ---              Level 3                 ---
 *  --------------------------------------------
*/
List<Product> products = new List<Product>();
string input;

Methods.Menu(1);

products.AddRange(Methods.EnterItems());
List<Product> orderedProducts = products.OrderBy(p => p.Price).ToList();

Methods.PrintList(orderedProducts);

while (true)
{
    Methods.Menu(2);
    input = Console.ReadLine();
    input.Trim();

    if (input.ToLower() == "q")
    {
        break;
    } 
    else if(input.ToLower() == "a")
    {
        products.AddRange(Methods.EnterItems());
        orderedProducts = products.OrderBy(p => p.Price).ToList();
        Methods.PrintList(orderedProducts);
    }
}
