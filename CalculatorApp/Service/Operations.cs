using CalculatorApp.Interface;

namespace CalculatorApp.Service;

public class Operations : IOperations
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method

        return operation switch
        {
            "add" => Add(num1, num2),
            "subtract" => Subtract(num1, num2),
            "multiply" => Multiply(num1, num2),
            "divide" => Divide(num1, num2),
            _ => throw new InvalidOperationException("Invalid operation.")

        };
    }
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        return num2 != 0 ? num1 / num2 
            : 
            throw new DivideByZeroException("Cannot divide by zero.");
    }
}
