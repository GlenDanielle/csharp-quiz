namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 1;
        double num2 = 0;

        try{
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException ex){
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.WriteLine(ex.Message);
            return;
        }
        

        Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
        string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

        var calculator = new Calculator();    
        double result = calculator.PerformOperation(num1, num2, operation);
        Console.WriteLine($"The result is: {result}");

        Console.WriteLine("Calculation attempt finished.");
    }
}