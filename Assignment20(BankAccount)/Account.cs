namespace Assignment20_BankAccount_
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Method to deposit an amount into the account
        public decimal Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }
                Balance += amount; // Add amount to balance
                return Balance; // Return the updated balance
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Display error message
                return Balance; // Return the current balance
            }
        }

        // Method to withdraw an amount from the account
        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                Balance -= amount; // Deduct amount from balance
                return Balance; // Return the updated balance
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Display error message for invalid amount
                return Balance; // Return the current balance
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message); // Display error message for insufficient funds
                return Balance; // Return the current balance
            }
        }
    }

}
