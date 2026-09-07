using System;

class Program10
{
    
    public delegate void CalculatorDelegate(int a, int b);

   
    public static void Addition(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

   
    public static void Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    
    public static void Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    
    public static void Division(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("Division = " + (a / b));
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed!");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

   
        CalculatorDelegate calculator = Addition;

        calculator += Subtraction;
        calculator += Multiplication;
        calculator += Division;

        Console.WriteLine("\n--- Calculator Results ---");
        calculator(num1, num2);
    }
}