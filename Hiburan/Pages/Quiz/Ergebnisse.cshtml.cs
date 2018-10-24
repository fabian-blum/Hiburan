using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hiburan.Pages.Quiz
{
    [Authorize]
    public class ErgebnisseModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}