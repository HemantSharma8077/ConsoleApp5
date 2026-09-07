using System;

class BankAccount1
{
    // Properties
    public string AccountNumber { get; set; }
    public string AccountHolder { get; set; }

    // Private variable for balance
    private double balance;

    // Read-only from outside the class
    public double Balance
    {
        get { return balance; }
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit successful!");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount! Amount must be positive.");
        }
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount!");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance! Withdrawal amount exceeds balance.");
        }
        else
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawal successful!");
        }
    }
}

class Program6
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        Console.Write("Enter Account Number: ");
        account.AccountNumber = Console.ReadLine();

        Console.Write("Enter Account Holder Name: ");
        account.AccountHolder = Console.ReadLine();

        Console.Write("Enter Deposit Amount: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        account.Deposit(depositAmount);

        Console.Write("Enter Withdrawal Amount: ");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());

        account.Withdraw(withdrawAmount);

        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Account Holder: " + account.AccountHolder);
        Console.WriteLine("Updated Balance: " + account.Balance);
    }
}