using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public double BasicSalary { get; set; }
    public int Experience { get; set; }

    // Read-only property
    public double Bonus
    {
        get
        {
            if (Experience >= 10)
            {
                return BasicSalary * 20 / 100;
            }
            else if (Experience >= 5)
            {
                return BasicSalary * 10 / 100;
            }
            else
            {
                return BasicSalary * 5 / 100;
            }
        }
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        emp.BasicSalary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Experience (in years): ");
        emp.Experience = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine("Name: " + emp.Name);
        Console.WriteLine("Basic Salary: " + emp.BasicSalary);
        Console.WriteLine("Experience: " + emp.Experience + " years");
        Console.WriteLine("Bonus: " + emp.Bonus);
    }
}