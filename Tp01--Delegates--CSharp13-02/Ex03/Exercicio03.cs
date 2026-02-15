namespace Delegate_Tp.Ex03;

public class Exercicio03
{

    public static void Executar()
    {
        double baseValue;
        double hieghtValue;

        Console.WriteLine("BienVenue!!!");
        Console.WriteLine("S'il vous plaît");
        Console.WriteLine("");
        Console.WriteLine("Informer la base");
         bool validBase = double.TryParse(Console.ReadLine(), out baseValue);
        Console.WriteLine("La hauteur d'un rectangle");
        bool validHieght = double.TryParse(Console.ReadLine(), out hieghtValue);
        if (!validBase)
        {
            Console.WriteLine("Desolè, Valeur invalide");
            return;
        }
        if (!validHieght)
        {
            Console.WriteLine("Désolé, Valeur invalide");
            return;
        }
        
        Func<double, double, double> calculatedArea;
        calculatedArea = (b, h) => b * h;

        
        double area = calculatedArea(baseValue, hieghtValue);
        Console.WriteLine($"La surface du rectangle est: {area}");
        
        
        

    }
        



}