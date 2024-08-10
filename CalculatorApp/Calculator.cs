namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method

        return operation switch
        {
            "add" or "+" => num1 + num2,
            "subtract" or "-" => num1 - num2,
            "multiply" or "*" => num1 * num2,
            "divide" or "/" => num2 == 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero."),
            _ => throw new InvalidOperationException("Invalid operation.")

        };

        // throw new NotImplementedException();
    }
}