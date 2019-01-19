using System;

namespace MindboxTaskLib.Exceptions
{
    public class CalculatorNotFoundException : Exception
    {
        public CalculatorNotFoundException()
        {
        }

        public CalculatorNotFoundException(string message) : base(message)
        {
        }

        public CalculatorNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}