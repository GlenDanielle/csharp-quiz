namespace CalculatorApp;

public class ExceptionHandler
{
    public void HandleExcep(Exception ex)
    {
        switch (ex)
        {
            case FormatException: //Invalid Input (non-numeric value in any number)
                Console.WriteLine("Invalid input. Please enter a valid number.");
                break;
            case DivideByZeroException: //Division by Zero
                Console.WriteLine("Cannot divide by zero."); 
                break;
            case InvalidOperationException: //Unsupported Operation
                Console.WriteLine("Invalid operation.");
                break;
            default: //catch all
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                break;
        }
        //Console.WriteLine(ex.Message);
    }
}
