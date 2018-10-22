using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hiburan.Pages
{
    public class FAQModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
