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

    // [Test]
    // public void MethodUnderTest_Scenario_ExpectedBehavior()
    // {
    //     Assert.Pass();
    // }

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
    }

    //TEST Cases with invalid inputs
}