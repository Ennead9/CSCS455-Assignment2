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
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(4, 5, 9)]
        [TestMethod()]
        public void SubtractTest(double num1, double num2, double expected)
        {
            // Arrange & Act
            double result = Calculator.Subtract(3, 1);
            // Assert
            // Non-fluent: Assert.AreEqual(2, result);

            // Fluent Assertion
            result.Should().Be(2);
        }
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(4, 5, 9)]
        [TestMethod()]
        public void MultiplyTest(double num1, double num2, double expected)
        {
            // Arrange & Act
            double result = Calculator.Multiply(1, 2);
            // Assert
            // Non-fluent: Assert.AreEqual(2, result);

            // Fluent Assertion
            result.Should().Be(2);
        }
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(4, 5, 9)]
        [TestMethod()]
        public void DivideTest(double num1, double num2, double expected)
        {
            // Arrange & Act
            double result = Calculator.Divide(8, 4);
            // Assert
            // Non-fluent: Assert.AreEqual(2, result);

            // Fluent Assertion
            result.Should().Be(2);
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