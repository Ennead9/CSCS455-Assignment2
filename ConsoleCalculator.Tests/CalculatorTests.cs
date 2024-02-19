using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using ConsoleCalculator;


namespace ConsoleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            double num1 = 1, num2 = 2;
            var calc = new Calculator(num1, num2);
            Assert.IsNotNull(calc);

        }
        /*
        [TestMethod()]
        public void AddTest()
        {
            double num1 = 2, num2 = 3;
            var calc = new Calculator(num1, num2);
            Assert.IsTrue(calc.Add() == num1 + num2);
        }*/

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(4, 5, 9)]
        [TestMethod()]
        public void AddTest(double num1, double num2, double expected)
        {
            // Arrange (& Act?)
            double result = Calculator.Add(num1, num2);
            // Assert
            // Non-fluent: Assert.AreEqual(3, result);

            // Fluent Assertion
            result.Should().Be(expected);
        }
        [DataTestMethod]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        [DataRow(9, 5, 4)]
        [TestMethod()]
        public void SubtractTest(double num1, double num2, double expected)
        {
            // Arrange & Act
            double result = Calculator.Subtract(num1, num2);
            // Assert
            // Non-fluent: Assert.AreEqual(2, result);

            // Fluent Assertion
            result.Should().Be(expected);
        }
        [DataTestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 3, 6)]
        [DataRow(4, 5, 20)]
        [TestMethod()]
        public void MultiplyTest(double num1, double num2, double expected)
        {
            // Arrange & Act
            double result = Calculator.Multiply(num1, num2);
            // Assert
            // Non-fluent: Assert.AreEqual(2, result);

            // Fluent Assertion
            result.Should().Be(expected);
        }
        [DataTestMethod]
        [DataRow(2, 2, 1)]
        [DataRow(6, 3, 2)]
        [DataRow(20, 4, 5)]
        [TestMethod()]
        public void DivideTest(double num1, double num2, double expected)
        {
            // Arrange & Act
            double result = Calculator.Divide(num1, num2);
            // Assert
            // Non-fluent: Assert.AreEqual(2, result);

            // Fluent Assertion
            result.Should().Be(expected);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            // Arrange & Act
            double result = Calculator.Divide(4, 0);
            // Assert
        }
    }
}