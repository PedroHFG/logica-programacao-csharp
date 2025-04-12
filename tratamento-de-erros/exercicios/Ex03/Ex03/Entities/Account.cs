using Ex03.Exceptions;
using System.Globalization;

namespace Ex03.Entities;

public class Account
{
    public int Number { get; private set; }
    public string Holder { get; set; }
    public double Balance { get; private set; }
    public double WithdrawLimit { get; set; }

    public Account()
    {

    }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        if (number <= 0)
            throw new ArgumentException("Account number must be greater than zero.");

        if (string.IsNullOrWhiteSpace(holder))
            throw new ArgumentException("Holder name cannot be empty.");

        if (balance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        if (withdrawLimit <= 0)
            throw new ArgumentException("Withdraw limit must be greater than zero.");

        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }
        Balance += amount;
    }

    public void Withdraw (double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }
        if (amount > WithdrawLimit)
        {
            throw new LimitExceededException("The amount exceeds withdraw limit.");
        }
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Not enough balance.");
        }
        
        Balance -= amount;
    }

    public override string ToString()
    {
        return $"{Balance.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
