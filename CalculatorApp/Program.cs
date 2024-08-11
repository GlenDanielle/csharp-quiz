namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator(); 
        var exceptionHandler = new ExceptionHandler();
        //declared to as static only

        try{
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;
          
            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExcep(ex);
        }
        finally{
            Console.WriteLine("Calculation attempt finished.");
        }
    }
}