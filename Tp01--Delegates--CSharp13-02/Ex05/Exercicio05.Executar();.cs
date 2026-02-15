using System.Threading;
namespace Delegate_Tp.Ex05;


public class Exercicio05
{
    
    public class  DownloadManager
    {
        public event Action DownloadCompleted;
        
        public void StartDownload()
        {
            Console.WriteLine(" Downloading...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Download has finished ");
            Console.ResetColor();

            DownloadCompleted?.Invoke();
            
        }
        
    }
    public static void Message()
    {
        Console.ForegroundColor=ConsoleColor. Green;
        Console.WriteLine($"Download has completed successfully");
        Console.ResetColor();

          
    }

    public static void Executar()
        {
          

            DownloadManager manager = new DownloadManager();
            manager.DownloadCompleted += Message;
            manager.StartDownload();
          
        }









}