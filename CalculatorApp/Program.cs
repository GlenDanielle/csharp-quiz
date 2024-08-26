using CalculatorApp.Interface;
using CalculatorApp.Service;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        IConverter converter = new Converter();
        IOperations operations = new Operations();
        Calculator calculator = new(operations, converter);
        calculator.Run();
    }
}