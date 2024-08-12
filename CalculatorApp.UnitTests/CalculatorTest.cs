using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    //inject calculator app dependency
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    //TEST CASES!!!!!!!!!!!!!!!!!!

    //TEST Cases with valid inputs
    [Test]
    public void PerformOperation_Addition_ValidInput()
    {
        // Arrange
        //you set up everything needed for the test. 
        //This includes initializing objects, setting up mock data, and configuring any dependencies.
        // basically a payload of required props to perform in operation
        double num1 = 1;
        double num2 = 1;
        string operation = "add";


        // Act
        //This is where you execute the code that you want to test.
        //It typically involves calling the method or functionality that you're testing.
        //my ling ling pls use Dependency Injection
        double result = _calculator.PerformOperation(num1, num2, operation);

        //This is where you check if the method under test produces the correct results.
        // Assert
        Assert.That(result, Is.EqualTo(2));

        //NOTE: USE "dotnet test" IF U PLAN ON USING VSCODE
    }

    [Test]
    public void PerformOperation_Subtraction_ValidInput()
    {
        double num1 = 2;
        double num2 = 2;
        string operation = "-";

        double result = _calculator.PerformOperation(num1, num2, operation);

        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void PerformOperation_Multiplication_ValidInput()
    {
        double num1 = 1;
        double num2 = 20;
        string operation = "*";

        double result = _calculator.PerformOperation(num1, num2, operation);

        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void PerformOperation_Division_ValidInput()
    {
        double num1 = 10;
        double num2 = 10;
        string operation = "/";

        double result = _calculator.PerformOperation(num1, num2, operation);

        Assert.That(result, Is.EqualTo(1));
    }

    //TEST Cases with invalid inputs

    [Test]
    public void PerformOperation_InvalidDataTypeInput()
    {
        var num1 = "abdul java ryze"; 
        var num2 = "cheese sauce fries"; 
        string operation = "+";

        var ex = Assert.Throws<FormatException>(() => {
            _calculator.PerformOperation(Convert.ToDouble(num1), Convert.ToDouble(num2), operation);
        });
        Assert.That(ex, Is.TypeOf<FormatException>());
    }

    [Test]
    public void PerformOperation_DivisionByZero()
    {
        double num1 = 20;
        double num2 = 0;
        string operation = "/";

        var ex = Assert.Throws<DivideByZeroException>(() => {
            _calculator.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex, Is.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void PerformOperation_InvalidOperation()
    {
        double num1 = 20;
        double num2 = 1324;
        string operation = "SOLID";

        var ex = Assert.Throws<InvalidOperationException>(() => {
            _calculator.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex, Is.TypeOf<InvalidOperationException>());
    }

}