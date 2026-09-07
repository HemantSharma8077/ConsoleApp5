using System;

class Program12s
{
    public delegate void TemperatureDelegate(double celsius);

    
    public static void CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }

    
    public static void CelsiusToKelvin(double celsius)
    {
        double kelvin = celsius + 273.15;

        Console.WriteLine("Temperature in Kelvin: " + kelvin);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        
        TemperatureDelegate temperature = CelsiusToFahrenheit;

        temperature += CelsiusToKelvin;

        Console.WriteLine("\n--- Temperature Conversion ---");

        
        temperature(celsius);
    }
}