using Hiburan.Data;
using Hiburan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hiburan.Pages.Quiz
{
    [Authorize]
    public class DisplayQuizModel : PageModel
    {
        public DisplayQuizModel
            (
            ApplicationDbContext dbContext,
            UserManager<ApplicationUser> userManager
            )
        {
            ApplicationDbContext = dbContext;
            UserManager = userManager;
        }

        private ApplicationDbContext ApplicationDbContext { get; }
        public UserManager<ApplicationUser> UserManager { get; set; }

        public QuizProgress QuizProgress { get; set; }



        public async Task<IActionResult> OnGet(string quizname, int position = 0)
        {

            var quiz = await ApplicationDbContext.Quizzes.FirstOrDefaultAsync(x => x.Title == quizname);

            var user = await UserManager.GetUserAsync(User);
            QuizProgress = user.QuizProgresses.FirstOrDefault(x => x.Quiz.Id == quiz.Id);
            if (QuizProgress == null)
            {
                QuizProgress = new QuizProgress
                {
                    InProgress = true,
                    Quiz = quiz
                };
                user.QuizProgresses.Add(QuizProgress);
                await UserManager.UpdateAsync(user);
            }
            //Quiz = ApplicationDbContext.Quizzes.FirstOrDefault(x => x.Title == quizname);

            return Page();
        }
    }
}