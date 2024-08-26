using NUnit.Framework;
using CalculatorApp.Interface;
using CalculatorApp.Service;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    //inject calculator app dependency
    private Converter _converter;
    private Operations _operations;

    [SetUp]
    public void SetUp()
    {
        _converter = new Converter();
        _operations = new Operations();
    }

    //TEST CASES!!!!!!!!!!!!!!!!!!

    //TEST Cases with valid inputs
    [TestCase(1, 1)]
    public void PerformOperation_Addition_ValidInput(double num1, double num2)
    {
        double result = _operations.Add(num1, num2);

        Assert.That(result, Is.EqualTo(2));
    }

    [TestCase(2, 2)]
    public void PerformOperation_Subtraction_ValidInput(double num1, double num2)
    {
        double result = _operations.Subtract(num1, num2);
        Assert.That(result, Is.EqualTo(0));
    }
    
    [TestCase(1, 20)]
    public void PerformOperation_Multiplication_ValidInput(double num1, double num2)
    {
        double result = _operations.Multiply(num1, num2);
        Assert.That(result, Is.EqualTo(20));
    }

    [TestCase(10, 10)]
    public void PerformOperation_Division_ValidInput(double num1, double num2)
    {
        double result = _operations.Divide(num1, num2);
        Assert.That(result, Is.EqualTo(1));
    }

    [TestCase(5, 5, "add", 10)]
    [TestCase(5, 5, "subtract", 0)]
    [TestCase(5, 5, "multiply", 25)]
    [TestCase(5, 5, "divide", 1)]
    public void PerformOperations_ValidInput(double num1, double num2, string operation, double expected)
    {
        double result = _operations.PerformOperation(num1, num2, operation);
        Assert.That(result, Is.EqualTo(expected));
    }

    //TEST Cases with invalid inputs

    [TestCase("abdul java ryze", "cheese sauce fries", "add")]
    public void PerformOperation_InvalidDataTypeInput(string input1, string input2, string operation)
    {

        var ex = Assert.Throws<FormatException>(() =>
        {
            var num1 = _converter.ConvertToDouble(input1);
            var num2 = _converter.ConvertToDouble(input2);
            _operations.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex.Message, Is.EqualTo("Invalid input. Please enter numeric values."));
    }

    [TestCase(20, 0, "divide")]
    public void PerformOperation_DivisionByZero(double num1, double num2, string operation)
    {

        var ex = Assert.Throws<DivideByZeroException>(() => {
            _operations.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
    }
    

    [TestCase(20, 1234, "SOLID")]
    public void PerformOperation_InvalidOperation(double num1, double num2, string operation)
    {
        var ex = Assert.Throws<InvalidOperationException>(() => {
            _operations.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex.Message, Is.EqualTo("Invalid operation."));
    }

}