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

        [BindProperty]
        public int SelectedItem { get; set; } = -1;

        public async Task<IActionResult> OnGetAsync(int quizId)
        {
            await LoadQuiz(quizId);

            HttpContext.Session.Set("QuizProgress", QuizProgress);

            return Page();
        }

        public async Task<IActionResult> OnPostSelectAsync(int id)
        {
            QuizProgress = HttpContext.Session.Get<QuizProgress>("QuizProgress");

            //var contact = await _db.Customers.FindAsync(id);

            //if (contact != null)
            //{
            //    _db.Customers.Remove(contact);
            //    await _db.SaveChangesAsync();
            //}

            return Page();
        }

        public async Task<IActionResult> OnPostNextQuestionAsync(int id)
        {
            //var contact = await _db.Customers.FindAsync(id);

            //if (contact != null)
            //{
            //    _db.Customers.Remove(contact);
            //    await _db.SaveChangesAsync();
            //}

            return Page();
        }

        private async Task LoadQuiz(int quizId)
        {
            var quiz = await ApplicationDbContext.Quizzes.FirstOrDefaultAsync(x => x.Id == quizId);

            var user = await UserManager.GetUserAsync(User);
            QuizProgress = user.QuizProgresses.FirstOrDefault(x => x.Quiz.Id == quiz?.Id);
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
        }
    }
}