using System;
using Microsoft.Extensions.Logging;

class Program
{
    static void Main()
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole()
            .SetMinimumLevel(LogLevel.Debug);
        });

        ILogger logger = loggerFactory.CreateLogger<Program>();

        logger.LogDebug("This is a debug message");
        logger.LogInformation("This is a information message");
        logger.LogWarning("This is a warning message");
        logger.LogError("This is a error message");
        logger.LogCritical("This is a critical message");
    }
}