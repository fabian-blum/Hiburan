using Hiburan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hiburan.Pages.Components.Quiz
{
    public class QuizViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Question question)
        {
            return View("Default", question);
        }
    }
}
