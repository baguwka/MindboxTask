using System;

namespace MindboxTaskLib.Exceptions
{
    public class ShapeIsIncorrectExcception : Exception
    {
        public ShapeIsIncorrectExcception()
        {
        }

        public ShapeIsIncorrectExcception(string message) : base(message)
        {
        }

        public ShapeIsIncorrectExcception(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}