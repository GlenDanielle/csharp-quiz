namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method

        //switch statement
        //thou pogi lang to pero gamitin lang to 
        //if lahat is pede mo return
        return operation switch
        {
            "add" => num1 + num2,
            "subtract" => num1 - num2,
            "multiply" => num1 * num2,
            "divide" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero."),
            _ => throw new InvalidOperationException("Invalid operation.")

        };

        // throw new NotImplementedException();
    }
}