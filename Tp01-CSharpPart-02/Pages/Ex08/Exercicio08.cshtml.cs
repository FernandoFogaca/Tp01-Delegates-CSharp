using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tp01_CSharpPart_02.Pages.Ex08;

public class Exercicio08 : PageModel
{
    public List<string> Products { get; set; }

    public void OnGet()
    {

        Products = new List<string>
        {
            "Laptop - 1200",
            "Tablet - 300",
            "Apple Mobile - 1700"
            


        };



    }
}