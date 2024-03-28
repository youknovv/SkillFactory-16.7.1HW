using System;
using NUnit.Framework;

namespace Module16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Subtraction_Basic()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Subtraction(5, 5) == 0);
        }

        [Test]
        public void Division_Basic()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(100, 10) == 10);
        }

        [Test]
        public void Division_Zero()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void Multiplication_Basic()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Multiplication(9, 9) == 81);
        }

        [Test]
        public void Additional_Basic()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Addition(30, 30) == 60);
        }
    }
}