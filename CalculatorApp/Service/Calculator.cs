using CalculatorApp.Interface;
using Microsoft.Extensions.Logging;

namespace CalculatorApp.Service;

public class Calculator
{
    private readonly IOperations _operations;
    private readonly IConverter _converter;

        public Calculator(IOperations operations, IConverter converter)
        {
            _operations = operations;
            _converter = converter;
        }

    public void Run()
    {

        var logger = LoggerProvider.CreateLogger<Calculator>();

        try
        {
            Console.WriteLine("Enter the first number:");
            var num1 = _converter.ConvertToDouble(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter the second number:");
            var num2 = _converter.ConvertToDouble(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;
          
            double result = _operations.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            // Console.WriteLine(ex.Message);
        }
        finally{
            // Console.WriteLine("Calculation attempt finished.");
            logger.LogInformation("Calculation attempt finished.");
        }
    }
}