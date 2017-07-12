using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class StartUp
{
    public static List<BankAccount> accounts = new List<BankAccount>();

    static void Main()
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            var args = input.Split();

            var operation = args[0];

            switch (operation)
            {
                case "Create": Create(int.Parse(args[1]));
                    break;
                case "Deposit": Deposit(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "Withdraw": Withdraw(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "Print": PrintAccount(int.Parse(args[1]));
                    break;
            }

            input = Console.ReadLine();
        }
        Person peter = new Person("Peter", 33, accounts);

        Console.WriteLine(peter.GetBalance());
    }

    public static void Create(int accountId)
    {
        if (accounts.Any(acc => acc.Id == accountId))
        {
            Console.WriteLine($"Account already exists");
        }
        else
        {
            accounts.Add(new BankAccount()
            {
                Id = accountId
            });
        }
    }

    public static void Deposit(int accountId, int amount)
    {
        if (accounts.Any(acc => acc.Id == accountId))
        {
            accounts[GetAccountIndex(accountId)].Balance += amount;
        }
        else
        {
            Console.WriteLine($"Account does not exist");
        }
    }

    public static void Withdraw(int accountId, int amount)
    {
        if (accounts.Any(acc => acc.Id == accountId))
        {
            if (accounts[GetAccountIndex(accountId)].Balance >= amount)
            {
                accounts[GetAccountIndex(accountId)].Balance -= amount;
            }
            else
            {
                Console.WriteLine($"Insufficient balance");
            }
                
        }
        else
        {
            Console.WriteLine($"Account does not exist");
        }
    }

    public static void PrintAccount(int accountId)
    {

        if (accounts.Any(acc => acc.Id == accountId))
        {
            Console.WriteLine(accounts[GetAccountIndex(accountId)].ToString());
        }
        else
        {
            Console.WriteLine($"Account does not exist");
        }

    }

    public static int GetAccountIndex(int accountId)
    {
        return accounts.FindIndex(acc => acc.Id == accountId);
    }


}

