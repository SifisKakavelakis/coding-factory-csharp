using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions
{
    // Standard exception pattern for custom exceptions in C#.
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException()
            : base("Insufficient balance")
        { }

        public InsufficientBalanceException(string message)
            : base(message)
        { }

        public InsufficientBalanceException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}