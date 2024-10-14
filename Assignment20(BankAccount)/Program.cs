using System;
namespace Assignment20_BankAccount_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account(); 
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter the account number: ");
            account.AccountNumber = Console.ReadLine();
            Console.Write("Enter the balance: ");
            account.Balance = decimal.Parse(Console.ReadLine());

            if (choice == 1) 
            {
                Console.Write("Enter the amount to be deposited: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                decimal newBalance = account.Deposit(depositAmount); 
                Console.WriteLine($"Balance amount {newBalance}");
            }
            else if (choice == 2) 
            {
                Console.Write("Enter the amount to be withdrawn: ");
                decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                decimal newBalance = account.Withdraw(withdrawAmount); 
                Console.WriteLine($"Balance amount {newBalance}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

}
