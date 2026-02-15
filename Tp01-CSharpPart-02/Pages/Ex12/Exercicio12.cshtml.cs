using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tp01_CSharpPart_02.Pages.Ex12;

public class Evenement
{ 
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
        
}

public class Exercicio12 : PageModel
{
        
    public event Action<Evenement> EventCreated;

    private void CallingEvent(Evenement e)// escuta evento
    {
        Console.WriteLine($" Event Created: {e.Title} - {e.Date} - {e.Location }");
    }

    [BindProperty] public string Title { get; set; }
    [BindProperty] public  DateTime  Date { get; set; }
    [BindProperty] public string Location { get; set; }
    

    public void OnGet()
    {
        EventCreated += CallingEvent;
       
        
    }
    
   

    public void OnPost()
    {
        Console.WriteLine("OnPost executed");
        EventCreated += CallingEvent;
        Evenement newEvent = new Evenement
        {
            Title = Title,
            Date = Date,
            Location = Location
            
        };

        EventCreated?.Invoke(newEvent);
    }


}