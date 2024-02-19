using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestMethod()]
        public void AddTest()
        {
            double num1 = 2, num2 = 3;
            var calc = new Calculator(num1, num2);
            Assert.IsTrue(calc.Add() == num1 + num2);
        }

        [TestMethod()]
        public void TutorialAddTest()
        {
            // Arrange (& Act?)
            double result = Calculator.Add(1, 2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            // Arrange & Act
            double result = Calculator.Subtract(3, 1);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // Arrange & Act
            double result = Calculator.Multiply(1, 2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            // Arrange & Act
            double result = Calculator.Divide(8, 4);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}