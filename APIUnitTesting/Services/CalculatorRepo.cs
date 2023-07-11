using CalculatorAPIUnitTesting.Interface;
using System.Runtime.Serialization;

namespace CalculatorAPIUnitTesting.Services
{
    public class CalculatorRepo : IRepo
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new CalculatorException("Cannot divide by zero");
            }
            return (double)a / (double)b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        [Serializable]
        public class CalculatorException : Exception
        {
            public CalculatorException()
            {
            }

            public CalculatorException(string? message) : base(message)
            {
            }

            public CalculatorException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected CalculatorException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
