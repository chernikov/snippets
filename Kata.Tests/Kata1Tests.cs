using System;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
  public class CalculatorTest
  {
    [TestCase(6, 2, '+', 8)]
    [TestCase(4, 3, '-', 1)]
    [TestCase(5, 5, '*', 25)]
    [TestCase(5, 7, '*', 35)]
    [TestCase(5, 4, '/', 1.25)]
    public void Test(double a, double b, char op, double expect)
    {
        //Assign
        //Act
        var result = Kata.Calculator(a, b, op);
        //Assert
        Assert.AreEqual(expect, result, "should calculate the result of valid inputs");
    }
    
    [Test, Description("should throw ArgumentException with invalid inputs")]
    public void ErrorTest()
    {
      Assert.Throws<ArgumentException>(() => Kata.Calculator(6, 2, '&'));
    }
  }
}