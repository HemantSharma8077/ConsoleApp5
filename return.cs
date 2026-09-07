using System;

class Program11
{
    public delegate int CalculatorDelegate(int a, int b);   
    public static int Addition(int a, int b)
    {
        return a + b;
    }
    public static int Subtraction(int a, int b)
    {
        return a - b;
    }
    public static int Multiplication(int a, int b)
    {
        return a * b;
    }
    public static int Division(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed!");
            return 0;
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

          foreach (CalculatorDelegate method in calculator.GetInvocationList())
        {
            int result = method(num1, num2);

            Console.WriteLine(
                method.Method.Name + " = " + result
            );
        }
    }
}