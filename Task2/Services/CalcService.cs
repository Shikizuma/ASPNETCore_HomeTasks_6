using Task2.Interfaces;

namespace Task2.Services
{
    public class CalcService : ICalc
    {
        public double Add(double a, double b)
        {
           return a + b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }
    }
}
