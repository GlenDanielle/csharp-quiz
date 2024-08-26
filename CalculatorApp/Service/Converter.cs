using System;
using CalculatorApp.Interface;

namespace CalculatorApp.Service;

public class Converter : IConverter
{
    public double ConvertToDouble(string input)
    {
        try
        {
            return Convert.ToDouble(input);
        }
        catch(FormatException)
        {
            throw new FormatException("Invalid input. Please enter numeric values.");
        }
    }
}
