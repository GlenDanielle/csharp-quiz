using NUnit.Framework;

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
    [TestCase(1, 1, "add")]
    public void PerformOperation_Addition_ValidInput(double num1, double num2, string operation)
    {
        // Arrange
        //you set up everything needed for the test. 
        //This includes initializing objects, setting up mock data, and configuring any dependencies.
        // basically a payload of required props to perform in operation

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

    [TestCase(2, 2, "subtract")]
    public void PerformOperation_Subtraction_ValidInput(double num1, double num2, string operation)
    {

        double result = _calculator.PerformOperation(num1, num2, operation);

        Assert.That(result, Is.EqualTo(0));
    }
    
    [TestCase(1, 20, "multiply")]
    public void PerformOperation_Multiplication_ValidInput(double num1, double num2, string operation)
    {


        double result = _calculator.PerformOperation(num1, num2, operation);

        Assert.That(result, Is.EqualTo(20));
    }

    [TestCase(10, 10, "divide")]
    public void PerformOperation_Division_ValidInput(double num1, double num2, string operation)
    {
        double result = _calculator.PerformOperation(num1, num2, operation);

        Assert.That(result, Is.EqualTo(1));
    }

    //TEST Cases with invalid inputs

    [TestCase("abdul java ryze", "cheese sauce fries", "add")]
    public void PerformOperation_InvalidDataTypeInput(string input1, string input2, string operation)
    {

        var ex = Assert.Throws<FormatException>(() =>
        {
            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);
            _calculator.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex.Message, Does.Contain($"The input string '{num1}' was not in a correct format.")
                                    .Or.Contain($"The input string '{num2}' was not in a correct format."));
    }

    [TestCase(20, 0, "divide")]
    public void PerformOperation_DivisionByZero(double num1, double num2, string operation)
    {

        var ex = Assert.Throws<DivideByZeroException>(() => {
            _calculator.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
    }
    

    [TestCase(20, 1234, "SOLID")]
    public void PerformOperation_InvalidOperation(double num1, double num2, string operation)
    {
        var ex = Assert.Throws<InvalidOperationException>(() => {
            _calculator.PerformOperation(num1, num2, operation);
        });
        Assert.That(ex.Message, Is.EqualTo("Invalid operation."));
    }

}