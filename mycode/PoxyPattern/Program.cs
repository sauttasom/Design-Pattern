// See https://aka.ms/new-console-template for more information
using PoxyPattern;

Console.WriteLine("Hello, World!");


// Create a proxy logging subsystem
ProxyLoggingSubsystem loggingSubsystem = new ProxyLoggingSubsystem();

// Log messages in testing mode (buffered)
loggingSubsystem.SetTestingMode(true);
loggingSubsystem.Log("Poxy Testing log message 1");
loggingSubsystem.Log("Poxy Testing log message 2");


loggingSubsystem.SetTestingMode(false);

loggingSubsystem.Log("Real log message 1");
loggingSubsystem.Log("Real log message 2");