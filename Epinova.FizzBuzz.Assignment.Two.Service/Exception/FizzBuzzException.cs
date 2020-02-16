using System;

namespace Epinova.FizzBuzz.Assignment.Two.Service.CustomException
{
    public class FizzBuzzException : Exception
    {
        public FizzBuzzException()
        {
        }

        public FizzBuzzException(string message) : base(message)
        {
        }

        public FizzBuzzException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}