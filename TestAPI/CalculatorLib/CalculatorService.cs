using System;

namespace CalculatorLib
{
    public class CalculatorService
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return x / y;
        }

        public int Modulus(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Modulus by zero is not allowed.");
            return x % y;
        }
    }
}
