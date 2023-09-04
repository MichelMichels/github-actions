using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SomeClassLibrary.Tests;

[TestClass()]
public class CalculatorTests
{
    [TestMethod()]
    public void AddTest()
    {
        // Arrange
        ICalculator calculator = new Calculator();

        // Act
        int result = calculator.Add(4, 3);

        // Assert
        Assert.AreEqual(7, result);
    }
}