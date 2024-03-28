using System;
using Module16;
using Xunit;

namespace Modul16.Test.xUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void Subtraction_Two()
        {
            var calculator = new Calculator();
            Assert.Equal(8, calculator.Subtraction(10, 2));
        }

        [Fact]
        public void Division_Two()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Division(25, 5));
        }

        [Fact]
        public void Division_Zero_Two()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>((() => calculator.Division(100, 0)));
        }

        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equal(120, result);
        }
    }
}