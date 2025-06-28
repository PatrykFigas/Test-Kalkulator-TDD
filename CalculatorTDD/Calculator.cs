namespace CalculatorTDD
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nie można dzielić przez zero.");
            return a / b;
        }
        public double Pow(double a, double b) => Math.Pow(a, b); 
        public double Sqrt(double a) => Math.Sqrt(a);
    }
}
