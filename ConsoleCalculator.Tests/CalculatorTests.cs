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
    }
}