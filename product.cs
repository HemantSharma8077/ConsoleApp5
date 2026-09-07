using System;

class Product
{
    // Properties
    public string ProductName { get; set; }

    private double price;

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Read-only property
    public double DiscountPrice
    {
        get
        {
            if (Price >= 10000)
            {
                return Price - (Price * 20 / 100);
            }
            else if (Price >= 5000)
            {
                return Price - (Price * 10 / 100);
            }
            else
            {
                return Price;
            }
        }
    }
}

class Program1
{
    static void Main(string[] args)
    {
        Product p = new Product();

        Console.Write("Enter Product Name: ");
        p.ProductName = Console.ReadLine();

        Console.Write("Enter Product Price: ");
        p.Price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n--- Product Details ---");
        Console.WriteLine("Product Name: " + p.ProductName);
        Console.WriteLine("Original Price: " + p.Price);
        Console.WriteLine("Final Price after Discount: " + p.DiscountPrice);
    }
}