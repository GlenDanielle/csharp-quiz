

using CalculatorApp.Service;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new();
        Operations operations = new();
        Calculator calculator = new(operations, converter);
        calculator.Run();
    }
}