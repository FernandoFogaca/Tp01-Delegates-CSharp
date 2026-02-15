namespace Delegate_Tp.Ex07;

public class Exercicio07
{


    public static void Executar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Initialising logging services... With Invoke...");
        Console.ResetColor();
        Thread.Sleep(1000);
        Logger logger = new Logger();
        Action<string> loggerDelegate = logger.LogToConsole;
        loggerDelegate += logger.LogToFile;
        loggerDelegate += logger.LogToDatabase;
        loggerDelegate?.Invoke("System started");

    }
     
    

    public class Logger
    {
        
        public void LogToConsole(string message)
        {   Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Console: {message}");
            Console.ResetColor();
            Thread.Sleep(1000);
        }
        public void LogToFile(string message)
        {    Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"File: {message}");
            Console.ResetColor();
            Thread.Sleep(1000);
        }
        public void LogToDatabase(string message)
        {    Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Database: {message}");
            Console.ResetColor();
            Thread.Sleep(1000);
        }


    }
  






}
