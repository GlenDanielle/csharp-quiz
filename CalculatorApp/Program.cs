using Microsoft.Extensions.Logging;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator(); 
        double num1 = 0;
        double num2 = 0;

        var programLogger = LoggerProvider.CreateLogger<Program>();

        try
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToDouble(Console.ReadLine());


                programLogger.LogInformation("Both entered inputs are valid");
            }
            catch
            {
                
                throw new FormatException("Invalid input. Please enter a valid number.");
                
            }
            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;
          
            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }
        catch (FormatException fex)
        {
            programLogger.LogError(fex.Message);
            // Console.WriteLine(fex.Message);
        }
        catch (Exception ex)
        {
            programLogger.LogError(ex.Message);
            // Console.WriteLine(ex.Message);
        }
        finally{
            // Console.WriteLine("Calculation attempt finished.");
            programLogger.LogInformation("Calculation attempt finished.");
        }
    }
}