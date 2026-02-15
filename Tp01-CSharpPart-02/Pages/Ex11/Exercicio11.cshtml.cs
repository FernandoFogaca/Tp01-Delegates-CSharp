using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tp01_CSharpPart_02.Pages.Ex11;

public class Exercicio11 : PageModel
{
    public  string Result { get; set; }



    public void OnGet()
    {
        Func<string, string, string> fullName = (first, surname) =>
        {
            return first + " " + surname;
        };
       

        string ToUpper(string first, string surname)
        {
            return (first + " " + surname).ToUpper();


        }

        string ReplaceSpaces(string first, string surname)
        {
            return (first +  ""+ surname).Replace(" ", "" );

            
        }

        fullName += ToUpper;
       fullName += ReplaceSpaces;
       Result = fullName("Fernando", "Fogaça");


    }
}