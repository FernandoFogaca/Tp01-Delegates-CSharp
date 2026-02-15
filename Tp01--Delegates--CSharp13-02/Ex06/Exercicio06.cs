namespace Delegate_Tp.Ex06;

public class Exercicio06
{

    public static void Executar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Initialising logging services...");
        Console.ResetColor();
        Thread.Sleep(1000);
        Logger logger = new Logger();
        Action<string> loggerDelegate = logger.LogToConsole;
        loggerDelegate += logger.LogToFile;
        loggerDelegate += logger.LogToDatabase;
        loggerDelegate("System started");



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