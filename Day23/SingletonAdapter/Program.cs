using System;
using System.IO;
using System.Threading;

// Singleton Logger
public class Logger
{
    private static Logger instance;
    private StreamWriter fileWriter;
    private static readonly object lockObject = new object(); // Lock object for thread safety

    // Private constructor to prevent instantiation
    private Logger()
    {
        // Simulate opening log file
        fileWriter = new StreamWriter("log.txt", append: true);
    }

    public static Logger Instance
    {
        get
        {
            // Lazy initialization with thread safety using double-check locking
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }
    }

    // Property to access StreamWriter
    private StreamWriter FileWriter
    {
        get { return fileWriter; }
        set { fileWriter = value; }
    }

    public void Log(string message)
    {
        lock (lockObject)
        {
            // Simulate writing log to file
            FileWriter.WriteLine($"[{DateTime.Now}] - {message}");
            FileWriter.Flush(); // Ensure the message is written immediately
        }
    }
}

// Adapter Interface for Log Writing
public interface ILoggerAdapter
{
    void WriteLog(string message);
}

// Adapter Implementation for Logger
public class LoggerAdapter : ILoggerAdapter
{
    private Logger logger;

    public LoggerAdapter(Logger logger)
    {
        this.logger = logger;
    }

    public void WriteLog(string message)
    {
        // Use the Logger instance to write the log
        logger.Log(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Singleton instance of the logger
        Logger logger = Logger.Instance;

        // Adapter for log writing
        ILoggerAdapter loggerAdapter = new LoggerAdapter(logger);

        // Multiple programs running concurrently
        Thread program1Thread = new Thread(() =>
        {
            Program1 program1 = new Program1(loggerAdapter);
            program1.Run();
        });

        Thread program2Thread = new Thread(() =>
        {
            Program2 program2 = new Program2(loggerAdapter);
            program2.Run();
        });

        program1Thread.Start();
        program2Thread.Start();

        // Wait for programs to finish
        program1Thread.Join();
        program2Thread.Join();

        Console.WriteLine("All programs completed writing logs.");
    }
}

// Program 1
public class Program1
{
    private ILoggerAdapter loggerAdapter;

    public Program1(ILoggerAdapter loggerAdapter)
    {
        this.loggerAdapter = loggerAdapter;
    }

    public void Run()
    {
        // Simulate program 1 writing logs
        loggerAdapter.WriteLog("Log message from Program 1");
    }
}

// Program 2
public class Program2
{
    private ILoggerAdapter loggerAdapter;

    public Program2(ILoggerAdapter loggerAdapter)
    {
        this.loggerAdapter = loggerAdapter;
    }

    public void Run()
    {
        // Simulate program 2 writing logs
        loggerAdapter.WriteLog("Log message from Program 2");
    }
}
