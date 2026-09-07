using System;

class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }

    private double balance;

    public double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            // Balance cannot be negative
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative!");
            }
        }
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance = Balance + amount;
            Console.WriteLine("Money deposited successfully.");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.AccountNumber = "ACC101";
        account.Balance = 5000;

        // Deposit money
        account.Deposit(2000);

        // Display details
        Console.WriteLine("\nAccount Number: " + account.AccountNumber);
        Console.WriteLine("Final Balance: " + account.Balance);
    }
}