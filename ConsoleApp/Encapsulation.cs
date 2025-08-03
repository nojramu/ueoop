namespace ConsoleApp
{
    // Represents a simple bank account with encapsulated balance
    public class BankAccount
    {
        // Private field to store the account balance
        private double balance;

        // Deposits a positive amount into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        // Returns the current balance of the account
        public double GetBalance()
        {
            return balance;
        }
    } 
}
