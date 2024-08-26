using System;

namespace CalculatorApp.Interface;

public interface IOperations
{
    double PerformOperation(double num1, double num2, string operation);
    double Add(double num1, double num2);
    double Subtract(double num1, double num2);
    double Multiply(double num1, double num2);
    double Divide(double num1, double num2);
}
