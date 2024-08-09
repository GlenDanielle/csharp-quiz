namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        // TODO: Implement the PerformOperation method

        switch (operation)
        {
            case "add":
            case "+":
                return num1 + num2;
               
            case "subtract":
            case "-":
                return num1 - num2;
               
            case "multiply":
            case "*":
                return num1 * num2;
               
            case "divide":
            case "/":
                return num1 / num2;
               
            default:
                throw new InvalidOperationException("Invalid operation.");
        }

        // throw new NotImplementedException();
    }
    
}