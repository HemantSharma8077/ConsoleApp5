using System;

class Temperature
{
    private double celsius;

    // Celsius Property
    public double Celsius
    {
        get
        {
            return celsius;
        }
        set
        {
            // Absolute zero से कम value accept नहीं होगी
            if (value < -273.15)
            {
                Console.WriteLine("Invalid Temperature! Celsius cannot be below -273.15.");
            }
            else
            {
                celsius = value;
            }
        }
    }

    // Read-only Property
    public double Fahrenheit
    {
        get
        {
            return (Celsius * 9 / 5) + 32;
        }
    }
}

class Program4
{
    static void Main(string[] args)
    {
        Temperature temp = new Temperature();

        Console.Write("Enter temperature in Celsius: ");
        temp.Celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n--- Temperature Details ---");
        Console.WriteLine("Celsius: " + temp.Celsius);
        Console.WriteLine("Fahrenheit: " + temp.Fahrenheit);
    }
}