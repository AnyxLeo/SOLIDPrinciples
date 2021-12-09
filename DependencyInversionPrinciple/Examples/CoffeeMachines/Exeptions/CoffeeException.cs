using System;
using System.Runtime.Serialization;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Exeptions
{
    [Serializable]
    internal class CoffeeException : Exception
    {
        public CoffeeException()
        {
        }

        public CoffeeException(string message) : base(message)
        {
        }

        public CoffeeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CoffeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
