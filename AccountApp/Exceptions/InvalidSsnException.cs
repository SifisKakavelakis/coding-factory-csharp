using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions
{
    internal class InvalidSsnException : Exception
    {
        public InvalidSsnException()
            : base("The provided Social Security Number (SSN) is invalid.")
        { }

        public InvalidSsnException(string message)
            : base(message)
        { }

        public InvalidSsnException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}