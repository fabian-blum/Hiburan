using Hiburan.Data;
using Hiburan.Extensions;
using Hiburan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private UserManager<ApplicationUser> UserManager { get; set; }


        public QuizProgress QuizProgress { get; set; }

        [TempData]
        public bool? Success { get; set; }

        public int SelectedItem { get; set; } = -1;

        // HTTP Methods

        public async Task<IActionResult> OnGetAsync(int quizId)
        {
            if (quizId == 0)
            {
                return RedirectToPage("/Error", "Message", new { message = "Dieses Quiz gibt es nicht" });
            }

            Success = null;

            await LoadQuiz(quizId);

            HttpContext.Session.Set("QuizProgress", QuizProgress);

            return Page();
        }

        public IActionResult OnPostSelect(int selectedId)
        {
            QuizProgress = HttpContext.Session.Get<QuizProgress>("QuizProgress");

            SelectedItem = selectedId;

            Success = selectedId == QuizProgress.Quiz.Questions[QuizProgress.Position].CorrectOptionId;

            return Page();
        }

        public async Task<IActionResult> OnPostNextQuestionAsync()
        {
            QuizProgress = HttpContext.Session.Get<QuizProgress>("QuizProgress");

            var user = await UserManager.GetUserAsync(User);
            QuizProgress = user.QuizProgresses.FirstOrDefault(x => x.Quiz.Id == QuizProgress?.Quiz?.Id);

            if (QuizProgress != null && QuizProgress.Quiz.Questions.Count - 1 > QuizProgress.Position)
            {
                QuizProgress.Position++;
            }
            else if (QuizProgress != null && Success.HasValue && Success.Value)
            {
                QuizProgress.Finished = true;
            }

            await UserManager.UpdateAsync(user);

            return QuizProgress != null ?
                 RedirectToPage("/Quiz/DisplayQuiz", new { quizId = QuizProgress.Quiz.Id })
                 : RedirectToPage("/Quiz/DisplayQuiz");

        }

        // Private Methods

        private async Task LoadQuiz(int quizId)
        {
            var quiz = await ApplicationDbContext.Quizzes.FirstOrDefaultAsync(x => x.Id == quizId);

            var user = await UserManager.GetUserAsync(User);
            QuizProgress = user.QuizProgresses.FirstOrDefault(x => x.Quiz.Id == quiz?.Id);
            if (QuizProgress == null)
            {
                QuizProgress = new QuizProgress
                {
                    Finished = false,
                    Quiz = quiz
                };
                user.QuizProgresses.Add(QuizProgress);
                await UserManager.UpdateAsync(user);
            }
        }
    }
}