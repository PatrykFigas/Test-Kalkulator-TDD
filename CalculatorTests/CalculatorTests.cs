using Xunit;
using CalculatorTDD;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(4, 3);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
        [Fact]
        public void Power_OneNumber_ReturnResult()
        {
            var calculator = new Calculator();
            var result = calculator.Pow(2, 3);
            Assert.Equal(8, result);
        }
        [Fact]
        public void Sqrt_OneNumber_ReturnResult()
        {

            var calculator = new Calculator();
            var result = calculator.Sqrt(4);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Fraction_Addition_WorksCorrectly()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 3);
            var result = a + b; // 1/2 + 1/3 = 5/6

            Assert.Equal(5, result.Licznik);
            Assert.Equal(6, result.Mianownik);
        }
    }
}