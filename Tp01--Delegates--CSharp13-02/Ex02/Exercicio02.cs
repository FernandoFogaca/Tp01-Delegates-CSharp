namespace Delegate_Tp.Ex02;

public class Exercicio02
{ 
   
    public static void Executar()
    {
        Action<string> welcomeMessage = null;
         string name = "";
       
        Console.WriteLine("Please, enter your name:");
         name = Console.ReadLine()!;
        Console.WriteLine("______Select the Language that suits you better______");
        Console.WriteLine();
        Console.WriteLine(" Options");
        Console.WriteLine(" 1 - Uk English\n" +
                          " 2 - Fr Français\n" +
                          " 3 - Br Português\n" +
                          " 4 - Es Español\n" +
                          " 5 - NL Nederlands");

        Console.WriteLine("Hey Old Chap!\n" +
                          "Please, Select an option.");
        string option = Console.ReadLine()!;
        switch (option)
        {
            case "1":
                welcomeMessage = EnglishMessage;
                break;
            case "2":
                welcomeMessage = FrancaisMessage;
                break;
            case "3":
                welcomeMessage = PortuguesMessage;
                break;
            case "4":
                welcomeMessage = EspanolMessage;
                break;
            case "5":
                welcomeMessage = NederlandseMessage;
                break;
           }
        
        if(welcomeMessage !=null) {
            welcomeMessage(name);
        }
        else
        {
            Console.WriteLine("Invalid option selected.");
            }
        
    }
   
        public static void EnglishMessage(string name){ Console.WriteLine($"Welcome{name}! We are delighted to have you here.\nDid you know? The United Kingdom has over 1,500 castles across the country.");}
        public static void FrancaisMessage(string name) { Console.WriteLine($" Bienvenue {name}! Nous sommes ravis de vous accueillir.\nLe saviez-vous? La France est le pays le plus visité au monde.\n ");}
        public static void PortuguesMessage(string name) { Console.WriteLine($" Seja bem-vindo{name}! Ficamos muito felizes com a sua visita.\nCuriosidade: O Brasil abriga a maior floresta tropical do mundo, a Amazônia.\n");}
        public static void EspanolMessage(string name) { Console.WriteLine($" ¡Bienvenido{name}! Estamos muy contentos de tenerte aquí.\nDato curioso: España es famosa por la fiesta de La Tomatina.\n");}
        public static void NederlandseMessage(string name) { Console.WriteLine($" Welkom{name}! We zijn blij dat je hier bent.\nWist je dat? Nederland heeft meer fietsen dan inwoners.\n");}
      
        


































}