using System;

class Program7
{
    
    public delegate void StudentDelegate(string name, int marks);
    public static void DisplayDetails(string name, int marks)
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Marks: " + marks);
    }
    public static void CheckResult(string name, int marks)
    {
        if (marks >= 40)
        {
            Console.WriteLine(name + " has Passed.");
        }
        else
        {
            Console.WriteLine(name + " has Failed.");
        }
    }
    static void Main(string[] args)
    {
        StudentDelegate student = DisplayDetails;
        student += CheckResult;
        student("Hemant", 75);
    }
}