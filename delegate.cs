using System;

class Program8
{
    public delegate void SumDelegate(int a, int b);
    public static void CalculateSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }
    static void Main(string[] args)
    {
        SumDelegate del = CalculateSum;
        del(10, 20);
    }
}