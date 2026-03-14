using AccountApp.Exceptions;

namespace AccountApp.Model
{
    internal class Account
    {
        public int Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }


        // Public API

        /// <summary>
        /// Deposits the specified amount to the account. 
        /// The amount must be positive.
        /// </summary>
        /// <param name="amount">The specified amount of money.</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new NegativeAmountException("Amount cannot be negative.");
                }
                Balance += amount;
            }
            catch (NegativeAmountException ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;          // rethrow
            }
        }

        public void Withdraw(decimal amount, string? ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException("Ssn must not be empty.");
                if (ssn != Ssn) throw new InvalidSsnException("Ssn does not match account holder's ssn.");
                if (amount < 0) throw new NegativeAmountException("Amount cannot be negative.");
                if (amount > Balance) throw new InsufficientBalanceException("Insufficient funds for withdrawal.");

                Balance -= amount;
            }
            catch (Exception ex) when (ex is NegativeAmountException
                                    or InsufficientBalanceException
                                    or InvalidSsnException)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }

        public decimal GetBalance(string? ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException("Ssn must not be empty.");
                if (ssn != Ssn) throw new InvalidSsnException("Ssn does not match account holder's ssn.");
                return Balance;
            }
            catch (InvalidSsnException ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }


    }
}