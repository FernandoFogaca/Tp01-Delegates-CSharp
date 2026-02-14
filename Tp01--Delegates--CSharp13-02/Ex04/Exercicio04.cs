namespace Delegate_Tp.Ex04;

public class Exercicio04
{
    public static void Executar()
    {
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.TemperatureExceeded += ShowAlert;
        Console.WriteLine("Enter temperature");
        double temp = Convert.ToDouble(Console.ReadLine());
        sensor.CheckTemperature(temp);
    }

    public static void ShowAlert(double temperature)
    {
        Console.ForegroundColor = ConsoleColor.Red;   
        Console.WriteLine($"Temperature exceeded: {temperature}°C ");
        Console.ResetColor();
        

    }





    public class TemperatureSensor
    {
        public event Action<double> TemperatureExceeded;

        public void CheckTemperature(double temperature)
        {
            if (temperature > 100)
            {
                TemperatureExceeded?.Invoke(temperature);
            }
            else
            {
                 Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Undercontrol temperature ");
                Console.ResetColor();
               
            }


        }

    }
}