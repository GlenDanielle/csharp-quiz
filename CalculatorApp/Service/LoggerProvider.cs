using Microsoft.Extensions.Logging;

namespace CalculatorApp.Service;

public class LoggerProvider
{
    private static readonly ILoggerFactory LoggerFactory = Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
    {
        builder
            .AddFilter("Microsoft", LogLevel.Warning) // Only log warnings and above for Microsoft namespace
            .AddFilter("System", LogLevel.Warning) // Only log warnings and above for System namespace
            .AddFilter("CalculatorApp.Service", LogLevel.Debug) // Log debug and above for your application
            .AddConsole();
    });

    public static ILogger<T> CreateLogger<T>()
    {
        return LoggerFactory.CreateLogger<T>();
    }
}
