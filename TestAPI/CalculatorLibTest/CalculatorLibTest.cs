using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System;

namespace CalculatorLib.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculator = new CalculatorService();

        [TestMethod]
        [DataRow(5, 2, 7)]
        [DataRow(-1, -1, -2)]
        [DataRow(0, 0, 0)]
        [DataRow(-1, 1, 0)]
        public void Addition_ReturnsCorrectValue(int x, int y, int expected)
        {
            var result = _calculator.Addition(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 2, 3)]
        [DataRow(-1, -1, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(1, -1, 2)]
        public void Subtraction_ReturnsCorrectValue(int x, int y, int expected)
        {
            var result = _calculator.Subtraction(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 2, 10)]
        [DataRow(-1, -1, 1)]
        [DataRow(0, 1, 0)]
        [DataRow(-1, 1, -1)]
        [DataRow(100, 0, 0)]
        public void Multiplication_ReturnsCorrectValue(int x, int y, int expected)
        {
            var result = _calculator.Multiplication(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(-1, -1, 1)]
        [DataRow(0, 1, 0)]
        [DataRow(-10, 2, -5)]
        // Note: This DataRow cannot precisely represent the result of 1/3 as an int
        // Consider adjusting the test or using a different type if precision is needed
        public void Division_ReturnsCorrectValue(int x, int y, int expected)
        {
            var result = _calculator.Division(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_ThrowsDivideByZeroException()
        {
            _calculator.Division(10, 0);
        }

        [TestMethod]
        [DataRow(10, 3, 1)]
        [DataRow(-1, 1, 0)]
        [DataRow(0, 1, 0)]
        [DataRow(10, -3, 1)]
        [DataRow(100, 1, 0)]
        public void Modulus_ReturnsCorrectValue(int x, int y, int expected)
        {
            var result = _calculator.Modulus(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Modulus_ThrowsDivideByZeroException()
        {
            _calculator.Modulus(10, 0);
        }
    }
}
