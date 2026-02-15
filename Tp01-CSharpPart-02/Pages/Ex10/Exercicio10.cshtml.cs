using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tp01_CSharpPart_02.Pages.Ex10;

public class Exercicio10 : PageModel
{
    [BindProperty] public string Name { get; set; }
    [BindProperty] public decimal Price { get; set; }

    public void OnGet()
    {
        Name = string.Empty;
        Price = 0;

    }

    public  void OnPost()
    {
       
    }

}