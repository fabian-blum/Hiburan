using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Hiburan.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual List<QuizProgress> QuizProgresses { get; set; } = new List<QuizProgress>();
    }
}
