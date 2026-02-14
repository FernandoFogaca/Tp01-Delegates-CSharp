namespace Tp01__Delegates__CSharp13_02.Ex01;

public class Exercicio01
{
    public delegate decimal CalculateDiscount(decimal price);

    public static decimal Discount(decimal price)
    {
        decimal finalPrice = price * 0.90m;
        return finalPrice;
    }

    public static void Executar()
    {
        Console.WriteLine("Enter the product price in pounds (£):");
        string input = Console.ReadLine()!;

        decimal price;

        bool valid = decimal.TryParse(input, out price);

        if (!valid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That doesn't appear to be a valid number. Please try again.");
            Console.ResetColor();
            return;
        }

        CalculateDiscount offPrice = Discount;
        decimal value = offPrice(price);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The final price after 10% discount is £{value:F2}");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Cheers, and have a brilliant day!");
    }
}

    
