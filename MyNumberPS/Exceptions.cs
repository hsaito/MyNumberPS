using System;
using System.Runtime.Serialization;

namespace MyNumberPS
{
    public class MyNumberPSException : Exception
    {
        public MyNumberPSException()
        {
        }

        protected MyNumberPSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public MyNumberPSException(string message) : base(message)
        {
        }

        public MyNumberPSException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class MyNumberPSNegativeMyNumberException : MyNumberPSException
    {
        public MyNumberPSNegativeMyNumberException()
        {
        }

        protected MyNumberPSNegativeMyNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public MyNumberPSNegativeMyNumberException(string message) : base(message)
        {
        }

        public MyNumberPSNegativeMyNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}