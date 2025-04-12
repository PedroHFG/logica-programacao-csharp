using Ex03.Entities;
using Ex03.Exceptions;
using System.Globalization;

namespace Ex03;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("\nEnter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount);

            Console.WriteLine($"New balance: {account}");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Withdraw error: {ex.Message}");
        }
        catch (LimitExceededException ex)
        {
            Console.WriteLine($"Withdraw error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid format. Please enter numeric values only");
        }

    }
}