using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MamphoWebsite.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Hey pretty girllll, Mampho<3!";
        }
    }
}