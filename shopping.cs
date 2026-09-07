using System;

class Product
{
    // Properties
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Read-only Property: Total Price
    public double TotalPrice
    {
        get
        {
            return Price * Quantity;
        }
    }

    // Read-only Property: Discount Amount
    public double Discount
    {
        get
        {
            if (TotalPrice >= 10000)
            {
                return TotalPrice * 15 / 100;
            }
            else if (TotalPrice >= 5000)
            {
                return TotalPrice * 10 / 100;
            }
            else
            {
                return 0;
            }
        }
    }

    // Read-only Property: Final Price
    public double FinalPrice
    {
        get
        {
            return TotalPrice - Discount;
        }
    }
}

class Program5
{
    static void Main(string[] args)
    {
        Product p = new Product();

        Console.Write("Enter Product Name: ");
        p.ProductName = Console.ReadLine();

        Console.Write("Enter Price: ");
        p.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        p.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- Shopping Cart Details ---");

        Console.WriteLine("Product Name: " + p.ProductName);
        Console.WriteLine("Price: " + p.Price);
        Console.WriteLine("Quantity: " + p.Quantity);
        Console.WriteLine("Total Price: " + p.TotalPrice);
        Console.WriteLine("Discount: " + p.Discount);
        Console.WriteLine("Final Price: " + p.FinalPrice);
    }
}